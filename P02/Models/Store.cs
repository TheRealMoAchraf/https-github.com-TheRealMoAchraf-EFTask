﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Models
{
    internal class Store
    {
            public int StoreId { get; set; }

            [MaxLength(80)]
            public string Name { get; set; }

            public ICollection<Sale> Sales { get; set; }
        }

    }
