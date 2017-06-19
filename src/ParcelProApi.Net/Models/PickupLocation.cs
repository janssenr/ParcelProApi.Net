using System;
using System.Runtime.Serialization;

namespace ParcelProApi.Net.Models
{
    [DataContract]
    public class PickupLocation
    {
        [DataMember(Name = "Id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }

        [DataMember(Name = "LocationType", EmitDefaultValue = false, IsRequired = false)]
        public string LocationType { get; set; }

        [DataMember(Name = "LocationTypeId", EmitDefaultValue = false, IsRequired = false)]
        public string LocationTypeId { get; set; }

        [DataMember(Name = "Name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "Street", EmitDefaultValue = false, IsRequired = false)]
        public string Street { get; set; }

        [DataMember(Name = "PostalcodeNumeric", EmitDefaultValue = false, IsRequired = false)]
        public string PostalcodeNumeric { get; set; }

        [DataMember(Name = "PostalcodeAlpha", EmitDefaultValue = false, IsRequired = false)]
        public string PostalcodeAlpha { get; set; }

        [DataMember(Name = "City", EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        [DataMember(Name = "Housenumber", EmitDefaultValue = false, IsRequired = false)]
        public string Housenumber { get; set; }

        [DataMember(Name = "HousenumberAdditional", EmitDefaultValue = false, IsRequired = false)]
        public string HousenumberAdditional { get; set; }

        [DataMember(Name = "Phonenumber", EmitDefaultValue = false, IsRequired = false)]
        public string Phonenumber { get; set; }

        [DataMember(Name = "OpeningHourTypes", EmitDefaultValue = false, IsRequired = false)]
        public string OpeningHourTypes { get; set; }

        [DataMember(Name = "IconPath", EmitDefaultValue = false, IsRequired = false)]
        public string IconPath { get; set; }

        [DataMember(Name = "OpeningMonday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingMonday;

        public string[] OpeningMonday
        {
            get
            {
                var obj = _openingMonday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingMonday = value; }
        }

        [DataMember(Name = "OpeningTuesday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingTuesday;

        public string[] OpeningTuesday
        {
            get
            {
                var obj = _openingTuesday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingTuesday = value; }
        }

        [DataMember(Name = "OpeningWednesday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingWednesday;

        public string[] OpeningWednesday
        {
            get
            {
                var obj = _openingWednesday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingWednesday = value; }
        }

        [DataMember(Name = "OpeningThursday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingThursday;

        public string[] OpeningThursday
        {
            get
            {
                var obj = _openingThursday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingThursday = value; }
        }

        [DataMember(Name = "OpeningFriday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingFriday;

        public string[] OpeningFriday
        {
            get
            {
                var obj = _openingFriday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingFriday = value; }
        }

        [DataMember(Name = "OpeningSaturday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingSaturday;

        public string[] OpeningSaturday
        {
            get
            {
                var obj = _openingSaturday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingSaturday = value; }
        }

        [DataMember(Name = "OpeningSunday", EmitDefaultValue = false, IsRequired = false)]
        private dynamic _openingSunday;

        public string[] OpeningSunday
        {
            get
            {
                var obj = _openingSunday;
                if (obj is string)
                {
                    return new[] { (string)obj };
                }
                if (obj is Array)
                {
                    int length = ((object[])obj).Length;
                    var openinghours = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        openinghours[i] = obj[i].ToString();
                    }
                    return openinghours;
                }
                return new string[0];
            }
            set { _openingSunday = value; }
        }

        [DataMember(Name = "IsActive", EmitDefaultValue = false, IsRequired = false)]
        public bool IsActive { get; set; }

        [DataMember(Name = "ProductCode", EmitDefaultValue = false, IsRequired = false)]
        public string ProductCode { get; set; }

        [DataMember(Name = "lat", EmitDefaultValue = false, IsRequired = false)]
        public string Latitude { get; set; }

        [DataMember(Name = "lng", EmitDefaultValue = false, IsRequired = false)]
        public string Longitude { get; set; }

        [DataMember(Name = "afstand", EmitDefaultValue = false, IsRequired = false)]
        public string Distance { get; set; }
    }
}
