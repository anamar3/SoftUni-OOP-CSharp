﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICalling
    {
        public string Number { get; set; }
        void CheckIfValid();
       
    }
}
