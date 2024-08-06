using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class AuthorProfile:BaseEntity
	{
		public string Biograpy { get; set; }
		public string  Country { get; set; }

		public DateTime BirthDay { get; set; }

		public DateTime?  DeathDate { get; set; }

		//Relational Properties

		public virtual Author Author  { get; set; }
	}
}
