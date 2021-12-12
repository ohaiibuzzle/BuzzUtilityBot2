namespace BuzzleBot.Models.SauceNao
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SauceNaoResponse
    {
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public SauceNaoResponseHeader Header { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<SauceNaoResult> Results { get; set; }
    }

    public partial class SauceNaoResponseHeader
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? UserId { get; set; }

        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? AccountType { get; set; }

        [JsonProperty("short_limit", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ShortLimit { get; set; }

        [JsonProperty("long_limit", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? LongLimit { get; set; }

        [JsonProperty("long_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongRemaining { get; set; }

        [JsonProperty("short_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShortRemaining { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("results_requested", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResultsRequested { get; set; }

        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Index> Index { get; set; }

        [JsonProperty("search_depth", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? SearchDepth { get; set; }

        [JsonProperty("minimum_similarity", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinimumSimilarity { get; set; }

        [JsonProperty("query_image_display", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryImageDisplay { get; set; }

        [JsonProperty("query_image", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryImage { get; set; }

        [JsonProperty("results_returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResultsReturned { get; set; }
    }

    public partial class Index
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public long? Results { get; set; }
    }

    public partial class SauceNaoResult
    {
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public ResultHeader Header { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("ext_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<Uri> ExtUrls { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("pixiv_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PixivId { get; set; }

        [JsonProperty("member_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberName { get; set; }

        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MemberId { get; set; }

        [JsonProperty("danbooru_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? DanbooruId { get; set; }

        [JsonProperty("gelbooru_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? GelbooruId { get; set; }

        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public Creator? Creator { get; set; }

        [JsonProperty("material", NullValueHandling = NullValueHandling.Ignore)]
        public string Material { get; set; }

        [JsonProperty("characters", NullValueHandling = NullValueHandling.Ignore)]
        public string Characters { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("eng_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngName { get; set; }

        [JsonProperty("jp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JpName { get; set; }

        [JsonProperty("md_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MdId { get; set; }

        [JsonProperty("mu_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MuId { get; set; }

        [JsonProperty("mal_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MalId { get; set; }

        [JsonProperty("part", NullValueHandling = NullValueHandling.Ignore)]
        public string Part { get; set; }

        [JsonProperty("artist", NullValueHandling = NullValueHandling.Ignore)]
        public string Artist { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("bcy_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BcyId { get; set; }

        [JsonProperty("member_link_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MemberLinkId { get; set; }

        [JsonProperty("bcy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BcyType { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("tweet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TweetId { get; set; }

        [JsonProperty("twitter_user_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TwitterUserId { get; set; }

        [JsonProperty("twitter_user_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string TwitterUserHandle { get; set; }

        [JsonProperty("da_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? DaId { get; set; }

        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        [JsonProperty("author_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AuthorUrl { get; set; }

        [JsonProperty("seiga_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SeigaId { get; set; }

        [JsonProperty("fa_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? FaId { get; set; }
    }

    public partial class ResultHeader
    {
        [JsonProperty("similarity", NullValueHandling = NullValueHandling.Ignore)]
        public string Similarity { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }

        [JsonProperty("index_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? IndexId { get; set; }

        [JsonProperty("index_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexName { get; set; }

        [JsonProperty("dupes", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dupes { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hidden { get; set; }
    }

    public partial struct Creator
    {
        public string String;
        public List<string> StringArray;

        public static implicit operator Creator(string String) => new Creator { String = String };
        public static implicit operator Creator(List<string> StringArray) => new Creator { StringArray = StringArray };
    }

    public partial class SauceNaoResponse
    {
        public static SauceNaoResponse FromJson(string json) => JsonConvert.DeserializeObject<SauceNaoResponse>(json, BuzzleBot.Models.SauceNao.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SauceNaoResponse self) => JsonConvert.SerializeObject(self, BuzzleBot.Models.SauceNao.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CreatorConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CreatorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Creator) || t == typeof(Creator?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Creator { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new Creator { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Creator");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Creator)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type Creator");
        }

        public static readonly CreatorConverter Singleton = new CreatorConverter();
    }
}
