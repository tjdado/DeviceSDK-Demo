﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Suprema;

namespace BSDemo
{
    class Program : UnitTest
    {
        private ZoneControl zc = new ZoneControl();

        protected override void runImpl(UInt32 deviceID)
        {
            zc.execute(sdkContext, deviceID, true);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Title = "Test for zone control";
            program.run();
        }
    }
}
