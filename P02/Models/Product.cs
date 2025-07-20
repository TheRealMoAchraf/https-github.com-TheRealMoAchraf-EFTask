﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Models
{
    internal class Product
    {
       
            public int ProductId { get; set; }

            [MaxLength(50)]
            public string Name { get; set; }

            public int Quantity { get; set; }

            public decimal Price { get; set; }

            public ICollection<Sale> Sales { get; set; }
            [MaxLength(250)]
            public string Description { get; set; } = "No description";
    }

    }

