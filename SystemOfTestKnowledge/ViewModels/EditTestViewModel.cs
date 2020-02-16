using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebTest.Models;

namespace MyWebTest.ViewModels
{
    public class EditTestViewModel
    {
        public List<TestingQuestion> Questions { get; set; }
        public int TestId { get; set; }
    }
}
