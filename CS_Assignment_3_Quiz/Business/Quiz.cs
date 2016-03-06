using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
namespace Business
{
    [Table]
    public class Quiz
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;
        [Column]
        public int Score;
        [Column]
        public DateTime Date;
        [Column]
        public string Name;

        //relation with Examinee
        private EntityRef<Examinee> examinee = new EntityRef<Examinee>();
        [Column]
        private int ExamineeId;
        [Association(IsForeignKey = true, Storage = "examinee", ThisKey = "ExamineeId")]
        public Examinee _examinee
        {
            get { return examinee.Entity; }
            set { examinee.Entity = value; }
        }

        //relation with Question
        private EntitySet<Question> questions = new EntitySet<Question>();
        [Association(Storage = "questions", OtherKey = "QuizId", ThisKey = "Id")]
        public ICollection<Question> _questions
        {
            get { return questions; }
            set { questions.Assign(value); }
        }
    }
}
