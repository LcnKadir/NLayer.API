﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Category : BaseEntitiy
    {
        public string Name { get; set; }


        public ICollection<Product> Products { get; set; }
    }

}
