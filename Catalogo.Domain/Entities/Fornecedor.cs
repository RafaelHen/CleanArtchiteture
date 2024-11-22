﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities
{
	public class Fornecedor : Entity
	{
		public Fornecedor() { }

		public string Name { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }

	}
}
