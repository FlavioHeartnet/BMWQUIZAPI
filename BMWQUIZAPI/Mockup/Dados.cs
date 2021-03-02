using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMWQUIZAPI.Mockup
{
    public class Dados
    {

        public static string[] Options = { "England", "USA", "Germany", "Japan" };
        public static List<Quiz> RetornaQuestions()
        {
           return  new List<Quiz>() {

                new Quiz()
                {
                    Question = "BMW",
                    Anwser = "Germany",
                    Options = Options

                },
                new Quiz()
                {
                    Question = "Toyota",
                    Anwser = "Japan",
                    Options = Options

                },
                new Quiz()
                {
                    Question = "Mini",
                    Anwser = "England",
                    Options = Options

                },
                new Quiz()
                {
                    Question = "General Motors",
                    Anwser = "USA",
                    Options = Options

                },
                new Quiz()
                {
                    Question = "Rolls-Royce",
                    Anwser = "England",
                    Options = Options

                },


                };
        }
    }
}
