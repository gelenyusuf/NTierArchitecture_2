using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Room:BaseEntity
	{
		public string Name { get; set; }

		//Relational Properties
		public virtual List<Shelf> Shelves { get; set; }
	}
}
