﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website.Shared.Models.Children
{
    public class MUserProfile : MUser
    {
        public int Sales { get; set; }
        public List<MProduct> Products { get; set; }
    }
}