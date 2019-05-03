﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarFunctions
{
    public class Function
    {
        public string name;
        public int numOfArg;
        public string[] dataTypes;

        public Function(string name, int numOfArg)
        {
            this.name = name;
            this.numOfArg = numOfArg;
            dataTypes = new string[numOfArg];
        }
    }
}