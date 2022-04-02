using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AnomaliesApi.Entities;
using AnomaliesApi.Validation;

namespace AnomaliesApi.DTOs
{
    public class RessourceDTO
    {

        public int id { get; set; }
        public string description { get; set; }
        public string localisation { get; set; }

        public int UserId { get; set; }


    }
}



