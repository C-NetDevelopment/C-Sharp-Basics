﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLab
{
    [Serializable]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
    }

    
}
