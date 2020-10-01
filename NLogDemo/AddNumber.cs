﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    class AddNumber
    {
        Nlog nLog = new Nlog();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nLog.LogDebug("Debug Successful : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("a & b shouldnot be equal to 0");
            }

            int c = a + b;
            nLog.LogDebug("Debug Successful : Sum()");
            nLog.LogInfo("Sum method passed, Result" + c);
            return c;

        }
    }
}
