using Domain.Entities;
using System;
using System.Text.Json.Serialization;

namespace Web.ApiModels.v1.Request
{
    public class DescriptionRequest
    {
        [JsonIgnore]
        public string Id { get; set; }
        public long Fingerprint { get; set; }

        public string Url { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }

        public UrlInfoRequest UrlInfo { get; set; }

        public static implicit operator Description(DescriptionRequest opn)
        {
            return opn is null ? null : new Description()
            {
                Id = string.IsNullOrWhiteSpace(opn.Id) ? Guid.NewGuid().ToString() : opn.Id,
                Text = opn.Text,
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
