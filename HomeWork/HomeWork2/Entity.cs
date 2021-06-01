﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity(int id)
        {
            Id = id;
        }

        public virtual decimal GetFullPrice()
        {
            return 10;
        }
    }
}