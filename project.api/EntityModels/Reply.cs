using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.EntityModels
{
    public class Reply
    {
        [Key]
        public Guid ID_Reply { get; set; }
       
        [DataType(DataType.Text)]
        public string  Content_Reply { get; set; }
        public int Likes { get; set; }
        public DateTime Created_reply { get; set; }
        public Posts posts { get; set; }
    }
}
