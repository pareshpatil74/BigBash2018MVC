using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace BusinessLayer
{
    public class AddBigBash
    {
        [Required(ErrorMessage = "Match Name can't be empty")]
        [Display(Name = "Add Match Name")]
        public string Match_Name { get; set; }

        [Required(ErrorMessage = "Match Date can't be empty")]
        [Display(Name = "Add Match Date")]
        public DateTime Match_Date { get; set; }

        [Required(ErrorMessage = "6 Number can't be empty")]
        [Display(Name = "Add 6 Number")]
        public string Six_Number { get; set; }

        [Required(ErrorMessage = "7 Number can't be empty")]
        [Display(Name = "Add 7 Number")]
        public string Seven_Number { get; set; }

        [Required(ErrorMessage = "8 Number can't be empty")]
        [Display(Name = "Add 8 Number")]
        public string Eight_Number { get; set; }

        [Required(ErrorMessage = "9 Number can't be empty")]
        [Display(Name = "Add 9 Number")]
        public string Nine_Number { get; set; }

        [Required(ErrorMessage = "6 Number Amount can't be empty")]
        [Display(Name = "Amount")]
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Six_Number_amount { get; set; }

        [Required(ErrorMessage = "7 Number Amount can't be empty")]
        [Display(Name = "Amount")]
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Seven_Number_amount { get; set; }

        [Required(ErrorMessage = "8 Number Amount can't be empty")]
        [Display(Name = "Amount")]
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Eight_Number_amount { get; set; }

        [Required(ErrorMessage = "9 Number Amount can't be empty")]
        [Display(Name = "Amount")]
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Nine_Number_amount { get; set; }


    }

    public class GetBigBashTable
    {
        [Display(Name = "Match Name")]
        public string Match_Name { get; set; }

        [Display(Name = "Date")]
        public DateTime Match_Date { get; set; }

        [Display(Name = "6th Number")]
        public string Six_Number { get; set; }

        [Display(Name = "Add 7th Number")]
        public string Seven_Number { get; set; }

        [Display(Name = "Add 8th Number")]
        public string Eight_Number { get; set; }

        [Display(Name = "Add 9th Number")]
        public string Nine_Number { get; set; }

        [Display(Name = "6th Amount")]
        public string Six_Number_amount { get; set; }

        [Display(Name = "7th Amount")]
        public string Seven_Number_amount { get; set; }

        [Display(Name = "8th Amount")]
        public string Eight_Number_amount { get; set; }

        [Display(Name = "9th Amount")]
        public string Nine_Number_amount { get; set; }
    }


    public class GetBigBashTableNew
    {
        [Display(Name = "Match Name")]
        public string Match_Name_New { get; set; }

        [Display(Name = "Date")]
        public DateTime Match_Date_New { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Rank")]
        public int Rank { get; set; }

        [Display(Name = "Amount")]
        public int Amount_new { get; set; }
    }


    public class AddBigBashNew
    {
        [Required(ErrorMessage = "Match Name can't be empty")]
        [Display(Name = "Add Match Name")]
        public string Match_Name_New { get; set; }

        [Required(ErrorMessage = "Match Date can't be empty")]
        [Display(Name = "Add Match Date")]
        public DateTime Match_Date_New { get; set; }

        [Required(ErrorMessage = "Name can't be empty")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Rank can't be empty")]
        [Display(Name = "Rank")]
        public int Rank { get; set; }

        [Required(ErrorMessage = "Amount can't be empty")]
        [Display(Name = "Amount")]
        public int Amount_new { get; set; }

    }




}
