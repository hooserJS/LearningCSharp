namespace ASPCoreWebAPI
{
    public class Cars
    {
        public string Model { get; set; }
        public int MaintenancePeriod { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Cars(string model, int maintenancePeriod, string color, int price)
        {
            Model = model;
            MaintenancePeriod = maintenancePeriod;
            Color = color;
            Price = price;
        }
    }
}
