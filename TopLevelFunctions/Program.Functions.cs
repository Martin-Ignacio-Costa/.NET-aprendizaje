using static System.Console;
partial class Program
{
    static void WhatMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}",
            typeof(Program).Namespace ?? "null");
    }

}