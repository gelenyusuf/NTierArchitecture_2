using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Category:BaseEntity
	{
		public string CategoryName  { get; set; }
		public string  Description { get; set; }

		//Relatioanl Properties

		public virtual List<Book> Books { get; set; }
	}
}
