using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace BuzzleBot.Modules
{
    public class MsgSaveModule : ModuleBase<SocketCommandContext>
    {
        [Command("savethis")]
        [Summary("Save the mentioned message to your DM")]
        public async Task SaveThis()
        {
            var msg = Context.Message;
            var user = Context.User as SocketGuildUser;

            var refMsg = msg.ReferencedMessage;
            if (refMsg == null)
            {
                await Context.Channel.SendMessageAsync("You need to mention a message to save");
                return;
            }
            var embed = new EmbedBuilder();
            embed.WithTitle("Message saved!");
            embed.AddField("From", $"{refMsg.Author.Username}#{refMsg.Author.Discriminator} in {refMsg.Channel.Name} on {Context.Guild.Name}");
            embed.AddField("Location", $"{refMsg.GetJumpUrl()}");
            if (refMsg.Content.Length > 0)
            {
                embed.AddField("Content", refMsg.Content);
            }
            if (refMsg.Attachments.Count > 0)
            {
                embed.AddField("Attachments", string.Join(", ", refMsg.Attachments.Select(x => x.Url)));
                embed.WithImageUrl(refMsg.Attachments.First().Url);
            }
            else if (refMsg.Embeds.Count > 0)
            {
                embed.AddField("Embeds", string.Join(", ", refMsg.Embeds.Select(x => x.Url)));
                embed.WithImageUrl(refMsg.Embeds.First().Url);
            }
            embed.WithFooter(refMsg.Author.Username, refMsg.Author.GetAvatarUrl());
            embed.WithTimestamp(refMsg.Timestamp);
            await user!.GetOrCreateDMChannelAsync().Result.SendMessageAsync("", false, embed.Build());
        }
    }
}
