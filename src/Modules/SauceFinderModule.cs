using Discord;
using Discord.Commands;
using Discord.WebSocket;
using BuzzleBot.Models.SauceNao;
using Newtonsoft.Json;

namespace BuzzleBot.Modules
{
    public class SauceFinderModule : ModuleBase<SocketCommandContext>
    {
        [Command("sauce")]
        public async Task Sauce()
        {
            var msg = Context.Message;
            var refMsg = msg.ReferencedMessage;
            if (refMsg == null)
            {
                await msg.Channel.SendMessageAsync("Mention a messsage with an image to use this command.");
                return;
            }
            if (refMsg.Attachments.Count == 0 && refMsg.Embeds.Count == 0)
            {
                await msg.Channel.SendMessageAsync("Mention a messsage with an image to use this command.");
                return;
            }
            var url = refMsg.Attachments.Count > 0 ? refMsg.Attachments.FirstOrDefault().Url : refMsg.Embeds.FirstOrDefault().Url;
            var sauce = await GetSauce(url);
            if (sauce == null)
            {
                await msg.Channel.SendMessageAsync("No sauce found.");
                return;
            }
            if (Double.Parse(sauce.Header.Similarity) < 50)
            {
                await msg.Channel.SendMessageAsync("No sauce found.");
                return;
            }

            var embed = new EmbedBuilder();
            embed.WithTitle($"Sauce found!");
            if (sauce.Data.Title != null)
                embed.AddField("Title", sauce.Data.Title);
            embed.AddField("Similarity", $"{sauce.Header.Similarity}%");

            if (sauce.Data.AuthorName != null || sauce.Data.MemberName != null || sauce.Data.TwitterUserHandle != null)
            {
                embed.AddField("Author", sauce.Data.AuthorName ?? sauce.Data.MemberName ?? sauce.Data.TwitterUserHandle);
            }
            if (sauce.Data.Source != null || (sauce.Data.ExtUrls != null && sauce.Data.ExtUrls.Count != 0) || sauce.Data.Url != null)
            {
                embed.AddField("Source", sauce.Data.Source ?? sauce.Data.ExtUrls[0].ToString() ?? sauce.Data.Url.ToString());
            }
            embed.AddField("Index", sauce.Header.IndexName);

            embed.WithThumbnailUrl(sauce.Header.Thumbnail.ToString());
            embed.WithTimestamp(msg.Timestamp);
            await msg.Channel.SendMessageAsync("", false, embed.Build());
        }
        public async Task<SauceNaoResult?> GetSauce(string url)
        {
            System.Console.WriteLine($"Getting sauce for {url}");
            var token = TokenProvider.Instance.GetToken("saucenao");
            Console.WriteLine($"Token: {token}");
            string endpoint = $"https://saucenao.com/search.php?dbmask=1443126841888&output_type=2&hide=3&numres=1&url={url}&api_key={token}";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
            var response = await client.GetAsync(endpoint);
            var content = await response.Content.ReadAsStringAsync();
            System.Console.WriteLine($"Got response {content}");
            var sauce = SauceNaoResponse.FromJson(content);
            var results = sauce.Results.ToList();

            return results[0];
        }
    }
}