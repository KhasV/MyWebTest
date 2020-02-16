using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebTest.Models;

namespace MyWebTest
{
    public class SampleData
    {
        public static void Initialize(SystemContext context)
        {
            
            if (!context.Questions.Any())
            {
                context.Questions.AddRange
                (
                    new TestingQuestion
                    {
                        Text = "Выберите любую фигуру",
                        CorrectAnswer = "■",
                        AnswerOptions = "■ ♦ ▲ • ♥",
                        TestId = 1
                    },
                    new TestingQuestion
                    {
                        Text = "Любимый цвет автора вопроса : а) Красный; б) Синий; в) Зеленый; г) Жёлтый; д) Фиолетовый;",
                        CorrectAnswer = "б",
                        AnswerOptions = "а б в г д",
                        TestId = 1
                    },
                    new TestingQuestion
                    {
                        Text = "Сколько времени на часах было при создании этого вопроса : ",
                        CorrectAnswer = "09:47",
                        AnswerOptions = "12:02 15:46 09:47 03:26 22:11",
                        TestId = 1
                    }
                );
                context.SaveChanges();
            }
            if (!context.TestTable.Any())
            {
                context.TestTable.AddRange
                (
                    new Test
                    {
                        Title = "Орёл или решка? ",
                        Id = 1,
                        KnowledgeArea = "Интуиция "
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
