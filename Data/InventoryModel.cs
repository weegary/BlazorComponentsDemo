namespace ComponentsDemo.Data
{
    public class InventoryModel
    {
        public string StockName { get; set; }
        public string StockID { get; set; }
        public DateTime BuyDate { get; set; }
        public int BuyVolume { get; set; }
        public double BuyPrice { get; set; }
        public string BrokerName { get; set; }
        public double MarketPrice { get; set; }
        public string Type { get; set; }
    }
}
