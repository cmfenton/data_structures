using System.Data.Linq.Mapping;

namespace DB
{
    public class Truck : Car
    {
        [Column()]
        public string Axles;
        [Column()]
        public string Tonnage;
    }
}
