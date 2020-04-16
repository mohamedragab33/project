using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.EntityModels

{
	public class catguser
	{//many to many
		[Key]
		public Guid ID { get; set; }
		public Guid ID_User { get; set; }
		[ForeignKey(nameof(ID_User))]
		public User user { get; set; }
		public Guid ID_Category { get; set; }
		[ForeignKey(nameof(ID_Category))]
		public Category category { get; set; }





	}
}
		