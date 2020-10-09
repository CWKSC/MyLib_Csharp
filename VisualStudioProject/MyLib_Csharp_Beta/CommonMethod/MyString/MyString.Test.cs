﻿using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.CommonMethod.Printing;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {

        public static void Test()
        {
            // AllAdd, AllAddFront //
            string[] OneToFive = { "1", "2", "3", "4", "5" };
            OneToFive.AllAdd("0").Println();
            OneToFive.AllAddFront("S").Printlnln();
            // 10, 20, 30, 40, 50
            // S10, S20, S30, S40, S50


            // Mix two string[] //
            string[] ABCD = { "a", "b", "c", "d" };
            string[] OneToFour = { "1", "2", "3", "4" };
            ABCD.Mix(OneToFour).Printlnln();
            // a1, b2, c3, d4


            new string[] { "1", "2", "3", "4" }.ConcatToOneString().Println();
            // 1234


            string[] OneToThree = { "1", "2", "3" };
            AllPrintlnln(
                OneToThree.ToUpperTriangular()
                // 1
                // 1, 2
                // 1, 2, 3
                ,
                OneToThree.ToConcat1dArray()
                // 1, 12, 123
                ,
                OneToThree.ToConcat1dArray_SeparateBy("*")
                // 1, 1*2, 1*2*3
            );

            string t = "T";
            AllPrintlnln(
                t.ToUpperTriangular(5)
                // T
                // T, T
                // T, T, T
                // T, T, T, T
                // T, T, T, T, T
                ,
                t.ToConcat1dArray_SeparateBy(5, "*")
                // T, T*T, T*T*T, T*T*T*T, T*T*T*T*T
                ,
                t.ToRepeatValue(5)
                // TTTTT
                ,
                t.ToRepeatArray(5)
                // T, T, T, T, T
            );


            // string ConcatSubArrayToString(this string[] array, int index, int length) //
            string[] ABCDEF = { "a", "b", "c", "d", "e", "f"};
            AllPrintln(
                ABCDEF.ConcatSubArrayToString(0, 2),
                ABCDEF.ConcatSubArrayToString(0, 4),
                ABCDEF.ConcatSubArrayToString(2, 2),
                ABCDEF.ConcatSubArrayToString(2, 4)
            ).ln();
            // ab
            // abcd
            // cd
            // cdef


            AllPrintln(
                Xn("X", 4)
                // X0, X1, X2, X3
                ,
                GenericType(5)
                // T0, T1, T2, T3, T4
            );

        }
        /* Output:
        10, 20, 30, 40, 50
        S10, S20, S30, S40, S50

        a1, b2, c3, d4

        1234
        1
        1, 2
        1, 2, 3

        1, 12, 123

        1, 1*2, 1*2*3

        T
        T, T
        T, T, T
        T, T, T, T
        T, T, T, T, T

        T, T*T, T*T*T, T*T*T*T, T*T*T*T*T

        TTTTT

        T, T, T, T, T

        ab
        abcd
        cd
        cdef

        X0, X1, X2, X3
        T0, T1, T2, T3, T4
        */

    }
}
