using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TigerPad1.ViewModel
{
    public class Inquiry
    {

        public int postInqID { get; set; }

        public string userID { get; set; }

        [Display(Name = "PostInqDate")]
        public DateTime postInqDate { get; set; }

        [Display(Name = "PostInq")]
        public string postInq { get; set; }


    }
}
