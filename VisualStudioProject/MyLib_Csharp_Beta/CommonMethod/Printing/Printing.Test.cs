﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class Printing
    {

        public static void Test()
        {
            "Hello World!".Print();
            lnln();

            // Element Print //
            int intValue = 42;
            string stringValue = "it is string";
            bool boolValue = true;

            intValue.Println();
            stringValue.Println();
            boolValue.Print();
            ln(2);

            // Array Print //
            int[] intArray = { 1, 10007, 42, 456 };
            intArray.Printlnln();

            // 2D Array Print //
            int[,] int2dArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int2dArray.Println();

        }

    }
}
