﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA.Models
{
    public abstract class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}