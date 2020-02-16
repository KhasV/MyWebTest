using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebTest.Models;

namespace MyWebTest.ViewModels
{
    public class EditQuestionViewModel
    {
        public String Title { get; set; }
        public String AnswerOptions { get; set; }
        public String CorrectAnswer { get; set; }
        public int Id { get; set; }
        public int TestId { get; set; }

    }
}
