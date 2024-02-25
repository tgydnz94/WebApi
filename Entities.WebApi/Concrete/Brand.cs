﻿using Core.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.WebApi.Concrete
{
    public class Brand : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
