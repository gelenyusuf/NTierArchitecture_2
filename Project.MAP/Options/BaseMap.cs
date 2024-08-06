using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Project.MAP.Options
{
	public class BaseMap<T>:EntityTypeConfiguration<T>  where   T:BaseEntity
	{
		public BaseMap()
		{
			//tip belirlemesi ,sütun isimlendirmesi yapılır burada

			//Property(x => x.CreatedDate).HasColumnType("datetime2");
		}
	}
}
