using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class ApiKey
    {
        [DataMember(Name = "valid", EmitDefaultValue = false, IsRequired = false)]
        public bool Valid { get; set; }
    }
}
