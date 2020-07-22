using DependencyInjectionIntermidiate.Interfaces;
using DependencyInjectionIntermidiate.WebContext;

namespace DependencyInjectionIntermidiate
{
    class IoC
    {
        public static IComputer Comp => ((IMetacubeGoalProject)ContextFactory.Current).Computer;

        public static IProcessor Processor => ((IMetacubeGoalProject)ContextFactory.Current).Process;
    }
}
