using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class Error
    {
        [DataMember(Name="level")]
        public string Level { get; set; }

        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "omschrijving")]
        public string Message { get; set; }
    }
}
