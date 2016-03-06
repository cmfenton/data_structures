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
    public class Option
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;
        [Column]
        public string Txt;
        [Column]
        public bool CorrectAnswer;

        //relation with Question
        private EntityRef<Question> question = new EntityRef<Question>();
        [Column]
        private int QuestionId;
        [Association(IsForeignKey = true, Storage = "question", ThisKey = "QuestionId")]
        public Question _question
        {
            get { return question.Entity; }
            set { question.Entity = value; }
        }
    }
}
