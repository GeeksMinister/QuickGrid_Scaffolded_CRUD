namespace QuickGrid_Scaffolded_CRUD.Models
{
    public class DbObj
    {
        [Key]
        public string ID { get; set; }
    }

    public class House : DbObj
    {
        public string Address { get; set; }
        public int Area { get; set; }

        public RoofTypes RoofTypes { get; set; }
    }

    public enum RoofTypes
    {
        Flat,
        Saddle,
    }
}
