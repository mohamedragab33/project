using Microsoft.AspNetCore.Identity;
using System;using System.Collections.Generic;using System.ComponentModel.DataAnnotations;
using System.Linq;using System.Threading.Tasks;namespace project.api.EntityModels{    public class User :IdentityUser    {
       

        public string Gender { get; set; }                             [DataType(DataType.Date)]        public DateTime Birth_date  {get; set; }                     public ICollection<Posts> Posts { get; set; }              public ICollection<Reply> reply { get; set; }               public ICollection<catguser> catgusers { get; set; }    }}