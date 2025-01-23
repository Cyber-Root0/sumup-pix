namespace SumUp.SDK.Client.Checkout
{
    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class AvailablePayments
    {
        public List<Item> items { get; set; }
    }


}