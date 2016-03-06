using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Business
{
    [Table]
    public class Examinee
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;
        [Column]
        public string Name;
        
        //relation with quiz        
        private EntitySet<Quiz> quizzes = new EntitySet<Quiz>();
        [Association(Storage = "quizzes", OtherKey = "ExamineeId", ThisKey = "Id")]
        public ICollection<Quiz> _quizzes
        {
            get { return quizzes; }
            set { quizzes.Assign(value); }
        }      
    }
}
