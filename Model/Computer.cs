
using System;
using DependencyInjectionIntermidiate.Interfaces;

namespace DependencyInjectionIntermidiate.Model
{
    class Computer : IComputer
    {
        public string BrandName { get; set; }

        public int Generation { get; set; }

        public void GetMessage()
        {
            Console.WriteLine("It is DI Intermediate Project");
        }
    }
}
