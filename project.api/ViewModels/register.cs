using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.ViewModels
{
    public class register
    {

        public Guid ID_User { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public DateTime Birth_date { get; set; }
        public string Gender { get; set; }


    }
}
