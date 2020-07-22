using DependencyInjectionIntermidiate.Builder;
using DependencyInjectionIntermidiate.Interfaces;

namespace DependencyInjectionIntermidiate.WebContext
{
    class Context : IMetacubeGoalProject, IApplicationContext
    {
        public IComputer Computer
        {
            get => new ComputerBuilder().CreateInstance() as IComputer;
            set => Computer = value;
        }

        public IProcessor Process
        {
            get => new ProcessorBuilder().CreateInstance() as IProcessor;
            set => Process = value;
        }
    }
}
