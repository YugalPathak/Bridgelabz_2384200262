﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class ResetRequest
    {
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }
}
