﻿/*
 *Author:Mudrenko Oksana
 * Created on 08.04.2021, 20:00
 * 
 */

using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main() {
        
            double a = 3, b = 12, c = 7, x1 = 6, x2 = 19, dx = 2;
            for (double x = x1; x2 >= x; x += dx)
            {
                Console.WriteLine ("|F={0}|",x + GetFanctionValue(x, a, b, c) * dx);
            }
            
            Console.WriteLine("------------------------------------------------------------------------------------");
            
            double dy = 0.2;
            for (double y = -1.0; y < 1; y +=dy)
            {
                Console.WriteLine("|F={0}|", y + GetSeriesValue(y, 0.0001) * dy);
            }
        }
    
        static double GetFanctionValue (double x, double a, double b, double c){
        
            if (c < 0 && b != 0){
                return a * x + b * b * x;
            }
        
            else if (c > 0 && b == 0){
                return (x + a) / (x + c);
            }
        
            else{
                return x / c;
            }
        }

        static double GetSeriesValue(double x, double eps)
        {
            double start = x;
            double sum = 0;
            int n = 1;

            do
            {
                sum += start;
                start *= (n * x) / n + 1;
                ++n;
            } while (start > eps);

            return sum * -1;
        }
    }
}