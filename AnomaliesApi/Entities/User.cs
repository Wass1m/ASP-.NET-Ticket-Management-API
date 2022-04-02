using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnomaliesApi.Entities
{
    public class User
    {
        public int id { get; set; }
        // public int responsableID { get; set; }
        [Required(ErrorMessage = "firstName is required")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "lastName is required")]

        public string lastName { get; set; }

        [Required(ErrorMessage = "email is required")]

        public string email { get; set; }
        [Required(ErrorMessage = "lastName is required")]

        public string password { get; set; }



        public int RoleId { get; set; }

        public Role Role { get; set; }


    }
}