using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Shelf:BaseEntity
	{
		public string No { get; set; }
		public int? RoomID { get; set; }
		//Relational Properties

		public virtual Room Room { get; set; }
		public virtual List<Book> Books { get; set; }
	}
}
