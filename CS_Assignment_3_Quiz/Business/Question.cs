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
    public class Question
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;
        [Column]
        public string Txt;

        //relation with Quiz
        private EntityRef<Quiz> quiz = new EntityRef<Quiz>();
        [Column]
        private int QuizId;
        [Association(IsForeignKey = true, Storage = "quiz", ThisKey = "QuizId")]
        public Quiz _quiz
        {
            get { return quiz.Entity; }
            set { quiz.Entity = value; }
        }

        //relation with option
        private EntitySet<Option> options = new EntitySet<Option>();
        [Association(Storage = "options", OtherKey = "QuestionId", ThisKey = "Id")]
        public ICollection<Option> _options
        {
            get { return options; }
            set { options.Assign(value); }
        }
    }
}
