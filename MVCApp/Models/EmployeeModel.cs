using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ConfirmEmail { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }



    }
}