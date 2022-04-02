using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AnomaliesApi.Validation;

namespace AnomaliesApi.Entities
{
    public class Ressource
    {

        public int id { get; set; }
        // public int responsableID { get; set; }
        [Required(ErrorMessage = "description is required")]
        public string description { get; set; }
        [StringLength(10)]
        [FirstLetterUpperCaseValidation]
        public string localisation { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }


    }
}



