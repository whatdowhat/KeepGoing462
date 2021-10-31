﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeepGoing462.Models
{
    public class Student
    {
        [Key]
        public int Seq { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}