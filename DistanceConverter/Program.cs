﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if(args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1,10);
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1,10);
            }
        }

        private static void PrintMeterToFeetList(int start,int stop) {
            for(int meter = start; meter <= stop; meter++) {
                FeetConverter con = new FeetConverter();
                double f = con.FromMeter(meter);
                Console.WriteLine("{0}m={1:0.0000}ft", meter,f);
            }
        }

        private static void PrintFeetToMeterList(int start,int stop) {
            for(int feet = start; feet <= stop; feet++) {
                FeetConverter con = new FeetConverter();
                double m = con.ToMeter(feet);
                Console.WriteLine("{0} ft={1:0.0000}m", feet,m);
            }
        }
    }
}
