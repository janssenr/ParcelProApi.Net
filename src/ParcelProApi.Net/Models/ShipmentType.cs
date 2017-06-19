using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class ShipmentType
    {
        [DataMember(Name="Id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }

        [DataMember(Name = "Type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "Code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "Label", EmitDefaultValue = false, IsRequired = false)]
        public string Label { get; set; }

        [DataMember(Name = "Carrier_Id", EmitDefaultValue = false, IsRequired = false)]
        public string CarrierId { get; set; }

        [DataMember(Name = "Carrier", EmitDefaultValue = false, IsRequired = false)]
        public string Carrier { get; set; }

        [DataMember(Name = "CarrierNaam", EmitDefaultValue = false, IsRequired = false)]
        public string CarrierName { get; set; }

        [DataMember(Name = "CarrierLabel", EmitDefaultValue = false, IsRequired = false)]
        public string CarrierLabel { get; set; }

        [DataMember(Name = "CarrierKlantcode", EmitDefaultValue = false, IsRequired = false)]
        public string CarrierCustomerCode { get; set; }

        [DataMember(Name = "Test", EmitDefaultValue = false, IsRequired = false)]
        public bool Test { get; set; }

        [DataMember(Name = "Buitenland", EmitDefaultValue = false, IsRequired = false)]
        public bool? Abroad { get; set; }

        [DataMember(Name = "Benelux", EmitDefaultValue = false, IsRequired = false)]
        public bool? Benelux { get; set; }

        [DataMember(Name = "EU", EmitDefaultValue = false, IsRequired = false)]
        public bool? EuropeanUnion { get; set; }

        [DataMember(Name = "WorldWide", EmitDefaultValue = false, IsRequired = false)]
        public bool? WorldWide { get; set; }

        [DataMember(Name = "Land", EmitDefaultValue = false, IsRequired = false)]
        public string Country { get; set; }

        [DataMember(Name = "Tolplichtig", EmitDefaultValue = false, IsRequired = false)]
        public bool? TollRequired { get; set; }

        [DataMember(Name = "ServicePoint", EmitDefaultValue = false, IsRequired = false)]
        public bool? ServicePoint { get; set; }

        [DataMember(Name = "HandtekeningVoorOntvangst", EmitDefaultValue = false, IsRequired = false)]
        public bool? Signature { get; set; }

        [DataMember(Name = "NietBijBuren", EmitDefaultValue = false, IsRequired = false)]
        public bool? OnlyRecipient { get; set; }

        [DataMember(Name = "AvondLevering", EmitDefaultValue = false, IsRequired = false)]
        public bool? EveningDelivery { get; set; }

        [DataMember(Name = "ZaterdagLevering", EmitDefaultValue = false, IsRequired = false)]
        public bool? SaturdayDelivery { get; set; }

        [DataMember(Name = "1100Levering", EmitDefaultValue = false, IsRequired = false)]
        public bool? SaturdayBeforeElevenDeliveryDelivery { get; set; }

        [DataMember(Name = "VerhoogdAansprakelijk", EmitDefaultValue = false, IsRequired = false)]
        public bool? IncreasedLiable { get; set; }

        [DataMember(Name = "Rembours", EmitDefaultValue = false, IsRequired = false)]
        public bool? CashOnDelivery { get; set; }

        [DataMember(Name = "MiniPallet", EmitDefaultValue = false, IsRequired = false)]
        public bool? MiniPallet { get; set; }

        [DataMember(Name = "Pallet", EmitDefaultValue = false, IsRequired = false)]
        public bool? Pallet { get; set; }

        [DataMember(Name = "Collo", EmitDefaultValue = false, IsRequired = false)]
        public bool? Package { get; set; }
    }
}
