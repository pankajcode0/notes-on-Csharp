//Running c# on ubuntu using mono.
// date 21 june 2019

// for compiling use : mcs -out:helloWorld.exe helloWorld.cs
// for executing the code use : mono helloWorld.exe

using System;

namespace Project_1 {
    class MainClass {
        public static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            Console.ReadKey ();
        }
    }
}