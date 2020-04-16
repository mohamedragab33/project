using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.EntityModels

{
    public class Category
    {
        [Key]
        public Guid ID_Category { get; set; }
        public string Category_Name { get; set; }
       //one categoret in many posts 
        public ICollection<Reply> reply { get; set; }

        //many user can choose one category
        public ICollection<catguser> catgusers{ get; set; }
    }
}
