﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true, message) 
        {
            
        }

        public ErrorResult() : base(true)
        {
            
        }

    }

}
