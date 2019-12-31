﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary.Core
{
	public class Restaurant
	{
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[Required, StringLength(100)]
		public string Location { get; set; }
		public CuisineType Cuisine { get; set; }
	}
}
