using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.EntityModels

{
    public class Posts
    {
      
        //attribute posts
        [Key]
        public Guid ID_Post { get; set; }
        public string Post_Content { get; set; }
        public int Likes { get; set; }
        public DateTime Data_Created { get; set; }
        //one post to many reply
        public ICollection<Reply> reply { get; set; }
        //one user to many posts
        public User user { get; set; }
        public Guid ID_User { get; set; }
        [ForeignKey(nameof(ID_User))]
        //many posrt toone category
        public Guid ID_Category { get; set; }
        [ForeignKey(nameof(ID_Category))]
        public Category category { get; set; }


    }
}
