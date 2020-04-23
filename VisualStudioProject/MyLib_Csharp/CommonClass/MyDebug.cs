﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyDebug
    {

        [Conditional("MyDebug")] public void Log(string msg) => Console.Write(msg);
        [Conditional("MyDebug")] public void Logln(string msg) => Console.WriteLine(msg);

        [Conditional("MyDebug")] public void Call(Action action) => action();
        [Conditional("MyDebug")] public void Call(Action<object[]> action, params object[] parameters) => action(parameters);
        [Conditional("MyDebug")] public void Call<T>(Func<T> func) => func();
        [Conditional("MyDebug")] public void Call<T>(Func<object[], T> func, params object[] parameters) => func(parameters);


        // https://stackoverflow.com/a/171974/11693034
        /// <summary>
        /// Not work int StartCoroutine, IEnumerator method<br/>
        /// Use LogCaller() is better and faster.
        /// </summary>
        [Conditional("MyDebug")]
        public static void LogMethod() => Console.WriteLine(new StackFrame(1).GetMethod().Name);

        // https://stackoverflow.com/a/9621581/11693034
        [Conditional("MyDebug")]
        public static void LogCaller([CallerMemberName] string callerName = "") => Console.WriteLine(callerName);

    }
}
