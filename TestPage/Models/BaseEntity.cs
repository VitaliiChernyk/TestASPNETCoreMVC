﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPage.Models
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime AssedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }
    }
}