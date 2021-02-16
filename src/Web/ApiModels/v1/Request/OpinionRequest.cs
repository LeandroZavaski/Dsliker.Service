using Domain.Entities;
using System.Text.Json.Serialization;

namespace Web.ApiModels.v1.Request
{
    public class OpinionRequest
    {
        [JsonIgnore]
        public string Id { get; set; }
        public long Fingerprint { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public UrlInfoRequest UrlInfo { get; set; }

        public static implicit operator Opinion(OpinionRequest opn)
        {
            return opn is null ? null : new Opinion()
            {
                Id = opn.Id,
                Description = opn.Description,
                Fingerprint = opn.Fingerprint,
                Type = opn.Type,
                Url = opn.Url,
                UrlInfo = opn.UrlInfo
            };
        }
    }

    public class UrlInfoRequest
    {
        public string FullUrl { get; set; }

        public string Host { get; set; }

        public string Subject { get; set; }

        public static implicit operator UrlInfo(UrlInfoRequest url)
        {
            return url is null ? null : new UrlInfo()
            {
                FullUrl = url.FullUrl,
                Host = url.Host,
                Subject = url.Subject
            };
        }
    }
}
