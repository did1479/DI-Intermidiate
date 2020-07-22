using System;
using DependencyInjectionIntermidiate;
using DependencyInjectionIntermidiate.WebContext;

namespace MetacubeGoalProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.WebAppInitialization();
            IoC.Comp.GetMessage();
            Console.ReadLine();
        }

        private static void WebAppInitialization()
        {
            ContextFactory.Current = new Context();
        }
    }
}
