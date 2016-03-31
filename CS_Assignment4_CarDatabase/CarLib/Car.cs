using System.Data.Linq.Mapping;

namespace DB
{
    //Base type Car linking to database table Car
    [Table]
    [InheritanceMapping(Code = "C", Type = typeof(Car), IsDefault = true)]
    [InheritanceMapping(Code = "T", Type = typeof(Truck))]
    [InheritanceMapping(Code = "P", Type = typeof(Passenger))]
    public class Car
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public string model;
        [Column]
        public string make;
        [Column]
        public string year;
        [Column(IsDiscriminator = true)]
        public string type;
        [Column]
        public string VIN;
    }
}
