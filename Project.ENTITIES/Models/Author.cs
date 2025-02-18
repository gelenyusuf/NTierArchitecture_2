﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Author:BaseEntity
	{
		public string  FirstName { get; set; }
		public string LastName { get; set; }

		//Relational Properties

		public virtual List<Book> Books { get; set; }

		public virtual AuthorProfile AuthorProfile { get; set; }
	}
}
