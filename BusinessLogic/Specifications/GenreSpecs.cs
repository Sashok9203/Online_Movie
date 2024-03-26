﻿using Ardalis.Specification;
using BusinessLogic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Specifications
{
	public static class GenreSpecs
	{
		public class GetAll : Specification<Genre>
		{
			public GetAll() => Query.Where(x => true);
		}
	}
}
