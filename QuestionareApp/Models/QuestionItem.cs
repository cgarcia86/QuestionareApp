using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionareApp.Models
{
    public class QuestionItem
    {
        public string Id { get; set; }
        public string  strQuestion { get; set; }
        //public string[] strAnswerData { get; set; }
        public List<String> strAnswerData = new List<String>();
        public int intAnsResponse { get; set; }

    }
}