using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BMWQUIZAPI.Mockup;

namespace BMWQUIZAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        // GET: QuizController
        [HttpGet]
        
        public List<Quiz> Get()
        {
            return Dados.RetornaQuestions();
        }
    }
}
