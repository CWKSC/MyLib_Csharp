﻿using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ProgramStructure
    {


        // Return MyVoid //
        public static MyVoid ReturnVoid() => MyVoid.instance;
        public static MyVoid ReturnVoid<Any>(this Any _) => ReturnVoid();
        public static MyVoid ReturnVoid(Action action)
        {
            action();
            return ReturnVoid();
        }
        public static MyVoid Start() => ReturnVoid();


        // Delcare //
        public static T Delcare<T>(out T variable, T init = default) => 
            variable = init;
        public static T Delcare<Any, T>(this Any _, out T variable, T init = default) =>
            variable = init;


        // Expression //
        public static T Expression<Any, T>(this Any _, T expression) => 
            expression;
        public static T _<Any, T>(this Any _, T expression) =>
            expression;

#pragma warning disable IDE1006 // 命名樣式

        // Action Adapter //
        public static Action _a(Action action) =>
            action;
        public static Action<T> _a<T>(Action<T> actionT) =>
            actionT;
        public static Action<T1, T2> _a<T1, T2>(Action<T1, T2> actionTT) =>
            actionTT;

        // Func Adapter //

        public static Func<R> _f<R>(Func<R> func) =>
            func;
        public static Func<T, R> _f<T, R>(Func<T, R> funcT) =>
            funcT;
        public static Func<T1, T2, R> _f<T1, T2, R>(Func<T1, T2, R> funcTT) =>
            funcTT;

#pragma warning restore IDE1006 // 命名樣式


        // Call //
        public static Any Call<Any>(this Any _, Action action)
        {
            action();
            return _;
        }
        public static R Call<T, R>(this T input, Func<T, R> func) => 
            func(input);
        public static Any Call<Any, R>(this Any _, Func<R> func)
        {
            func();
            return _;
        }


        // If Else //
        public static bool If(this bool condition, Action action)
        {
            if (condition) action();
            return condition;
        }
        public static bool Else(this bool condition, Action action) =>
            If(!condition, action);

        // For //
        public static (int start, int end, int step) For(this (int start, int end, int step) args, Action<int> action)
        {
            for (int i = args.start; i <= args.end; i += args.step)
                action(i);
            return args;
        }

        // While //
        public static Func<bool> While(this Func<bool> condition, Action action)
        {
            while (condition())
                action();
            return condition;
        }


    }
}