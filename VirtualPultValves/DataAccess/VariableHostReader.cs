﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fmslapi.WPF.Variables;

namespace VirtualPultValves.DataAccess
{
    class VariableHostReader
    {

        private static VariablesHost vh = new VariablesHost("PeterNeptun");
        
        public static VariablesHost GetVH
        {
            get { return VariableHostReader.vh; }
        }
    }
}
