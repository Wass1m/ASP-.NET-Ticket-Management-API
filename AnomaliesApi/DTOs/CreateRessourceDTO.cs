using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AnomaliesApi.Entities;
using AnomaliesApi.Validation;

namespace AnomaliesApi.DTOs
{
    public class CreateRessourceDTO
    {
        [Required(ErrorMessage = "description is required")]
        public string description { get; set; }
        [StringLength(10)]
        [FirstLetterUpperCaseValidation]
        public string localisation { get; set; }

        public int UserId { get; set; }


    }
}



