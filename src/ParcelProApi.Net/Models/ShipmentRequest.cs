using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class ShipmentRequest : BaseRequest
    {
        [DataMember(Name = "Carrier", EmitDefaultValue = false, IsRequired = false)]
        public string Carrier { get; set; }

        [DataMember(Name = "Type", EmitDefaultValue = false, IsRequired = false)]
        public string ShipmentType { get; set; }

        [DataMember(Name = "HandtekeningBijAflevering", EmitDefaultValue = false, IsRequired = false)]
        public bool Signature { get; set; }

        [DataMember(Name = "NietLeverenBijDeBuren", EmitDefaultValue = false, IsRequired = false)]
        public bool OnlyRecipient { get; set; }

        [DataMember(Name = "DirecteAvondlevering", EmitDefaultValue = false, IsRequired = false)]
        public bool DirectEveningDelivery { get; set; }

        [DataMember(Name = "Zaterdaglevering", EmitDefaultValue = false, IsRequired = false)]
        public bool SaturdayDelivery { get; set; }

        [DataMember(Name = "1100levering", EmitDefaultValue = false, IsRequired = false)]
        public bool BeforeElevenDelivery { get; set; }

        [DataMember(Name = "InleverenOpServicepoint", EmitDefaultValue = false, IsRequired = false)]
        public bool SubmitAtServicePoint { get; set; }

        [DataMember(Name = "Extrazeker", EmitDefaultValue = false, IsRequired = false)]
        public bool ExtraSure { get; set; }

        [DataMember(Name = "Rembours", EmitDefaultValue = false, IsRequired = false)]
        public decimal CashOnDelivery { get; set; }

        [DataMember(Name = "VerzekerdBedrag", EmitDefaultValue = false, IsRequired = false)]
        public int Insurance { get; set; }

        [DataMember(Name = "Brievenbuslevering", EmitDefaultValue = false, IsRequired = false)]
        public bool MailboxDelivery { get; set; }

        [DataMember(Name = "Rekeningnummer", EmitDefaultValue = false, IsRequired = false)]
        public string AccountNumber { get; set; }

        [DataMember(Name = "OrderNR", EmitDefaultValue = false, IsRequired = false)]
        public string OrderNumber { get; set; }

        [DataMember(Name = "Referentie", EmitDefaultValue = false, IsRequired = false)]
        public string Reference { get; set; }

        [DataMember(Name = "PickupTijdstip", EmitDefaultValue = false, IsRequired = false)]
        public string PickupTime { get; set; }

        [DataMember(Name = "NaamAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderName { get; set; }

        [DataMember(Name = "ContactpersoonAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderContactName { get; set; }

        [DataMember(Name = "StraatAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderStreet { get; set; }

        [DataMember(Name = "NummerAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderHousenumber { get; set; }

        [DataMember(Name = "PostcodeAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderPostalcode { get; set; }

        [DataMember(Name = "PlaatsAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderCity { get; set; }

        [DataMember(Name = "LandAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderCountry { get; set; }

        [DataMember(Name = "EmailAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderEmail { get; set; }

        [DataMember(Name = "TelefoonnummerAfzender", EmitDefaultValue = false, IsRequired = false)]
        public string SenderPhone { get; set; }

        [DataMember(Name = "LocationTypeUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationLocationType { get; set; }

        [DataMember(Name = "NameUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationName { get; set; }

        [DataMember(Name = "StreetUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationStreet { get; set; }

        [DataMember(Name = "PostalcodeNumericUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationPostalcodeNumeric { get; set; }

        [DataMember(Name = "PostalcodeAlphaUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationPostalcodeAlpha { get; set; }

        [DataMember(Name = "CityUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationCity { get; set; }

        [DataMember(Name = "HousenumberUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationHousenumber { get; set; }

        [DataMember(Name = "HousenumeberAdditionalUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationHousenumeberAdditional { get; set; }

        [DataMember(Name = "ProductCodeUitreiklocatie", EmitDefaultValue = false, IsRequired = false)]
        public string PickupLocationProductCode { get; set; }

        [DataMember(Name = "Naam", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientName { get; set; }

        [DataMember(Name = "Tav", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientContactName { get; set; }

        [DataMember(Name = "Afdeling", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientDepartment { get; set; }

        [DataMember(Name = "Straat", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientStreet { get; set; }

        [DataMember(Name = "Nummer", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientHousenumber { get; set; }

        [DataMember(Name = "Postcode", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientPostalcode { get; set; }

        [DataMember(Name = "Plaats", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientCity { get; set; }

        [DataMember(Name = "Land", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientCountry { get; set; }

        [DataMember(Name = "Email", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientEmail { get; set; }

        [DataMember(Name = "Telefoonnummer", EmitDefaultValue = false, IsRequired = false)]
        public string RecipientPhone { get; set; }

        [DataMember(Name = "AantalPakketten", EmitDefaultValue = false, IsRequired = false)]
        public int NumberOfPackages { get; set; }

        [DataMember(Name = "Gewicht", EmitDefaultValue = false, IsRequired = false)]
        public string Weight { get; set; }

        [DataMember(Name = "Opmerking", EmitDefaultValue = false, IsRequired = false)]
        public string Remark { get; set; }
    }
}
