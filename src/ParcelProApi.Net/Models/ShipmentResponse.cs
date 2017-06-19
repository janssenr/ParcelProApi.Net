namespace ParcelProApi.Net.Models
{
    public class ShipmentResponse
    {
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string LabelUrl { get; set; }
        public string TrackingUrl { get; set; }
    }
}
