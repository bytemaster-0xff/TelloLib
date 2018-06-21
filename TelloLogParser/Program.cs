﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelloLogParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllBytes("F:/Projects/Tello/droneLog/1521698715178.dat");
            var allLines = new List<string>();
            //skip header and parse rest. 
            var records = TelloLib.TelloLog.Parse(data.Skip(0x100).ToArray());

            foreach(var record in records)
            {
            }

        }
    }
}