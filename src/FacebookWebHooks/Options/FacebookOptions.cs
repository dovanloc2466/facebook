﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookWebHooks
{
    public class FacebookOptions
    {
        public string VerifyToken { get; set; }
        public bool ShouldVerifySignature { get; set; }
        public string AppSecret { get; set; }
        public string AppToken { get; set; }
    }
}
