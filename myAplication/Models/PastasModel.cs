namespace myAplication.Models
{
    public class PastasModel
    {
        public string ImageTitle { get; set; }
        public string PastaName { get; set; }
        public float BasePrice { get; set; } = 70;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Mushroom { get; set; }
        public bool Ham { get; set; }
        public bool Tuna { get; set; }
        public float TotalPrice { get; set; }
    }
}
