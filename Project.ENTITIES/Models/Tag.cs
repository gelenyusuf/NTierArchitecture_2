using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class Tag:BaseEntity
	{
		public string Title { get; set; }

		//Relatioanl Properties

		public virtual List<BookTag> BookTags { get; set; }
	}
}
