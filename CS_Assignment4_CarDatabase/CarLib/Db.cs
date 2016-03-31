using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace DB
{
    public class Db : DataContext
    {
        public Table<Car> cars;

        public Db() : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=Cars;Integrated Security=True")
        {

        }
    }
}
