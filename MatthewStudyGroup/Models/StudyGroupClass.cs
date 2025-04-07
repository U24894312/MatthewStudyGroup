using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MatthewStudyGroup.Models
{
	public class StudyGroupClass
	{

        [Display(Name = "Student Number")]
        public string stNumber { get; set; }

        [Display(Name = "Name")]
		public string FirstName { get; set; }

        [Display(Name = " Surname")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }

        [Display(Name = "Delete")]
        public string Delete { get; set; }

    }
}