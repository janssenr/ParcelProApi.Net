using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class BaseRequest
    {
        [DataMember(Name="GebruikerId")]
        internal int LoginId { get; set; }

        [DataMember(Name = "Datum")]
        internal string Date { get; set; }

        [DataMember(Name = "HmacSha256")]
        internal string HmacSha256 { get; set; }
    }
}
