using System.Data.Linq.Mapping;

namespace DB
{
    public class Passenger : Car
    {
        [Column()]
        public string TrimCode;
    }
}
