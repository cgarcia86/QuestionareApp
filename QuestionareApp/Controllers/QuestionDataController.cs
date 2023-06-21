using QuestionareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionareApp.Controllers
{
    public class QuestionDataController : Controller
    {
        // GET: QuestionData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewQuestion(QuestionItem postedQuestion)
        {
            QuestionItem question = new QuestionItem();

            //Gather Question Data
            question.Id = Guid.NewGuid().ToString();
           
            question.strQuestion = postedQuestion.strQuestion;

            foreach (string answers in postedQuestion.strAnswerData)
            {
                question.strAnswerData.Add(answers);
            }

            question.intAnsResponse = postedQuestion.intAnsResponse;

            return View(question);
        }

        public ActionResult AddQuestion()
        {
            return View();
        }
    }
}