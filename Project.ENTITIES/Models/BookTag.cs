using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class BookTag:BaseEntity
	{
		public int BookID { get; set; }
		public int TagID { get; set; }
		//Relatioanl Properties

		public virtual Book Book  { get; set; }
		public virtual Tag Tag { get; set; }
	}
}
