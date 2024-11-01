namespace Purple_Buzz.Entities
{
    public class Pricing : BaseEntity
    {
        public string Name { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string? Description5 { get; set; }
        public string Price { get; set; }
    }
}
