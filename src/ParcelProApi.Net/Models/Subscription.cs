using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class Subscription : BaseRequest
    {
        [DataMember(Name = "Status", EmitDefaultValue = false, IsRequired = false)]
        public string Status { get; set; }

        [DataMember(Name = "Url", EmitDefaultValue = false, IsRequired = false)]
        public string Url { get; set; }

        [DataMember(Name = "Data", EmitDefaultValue = false, IsRequired = false)]
        public string Data { get; set; }
    }
}
