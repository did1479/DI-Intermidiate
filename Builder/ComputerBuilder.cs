using DependencyInjectionIntermidiate.Interfaces;
using DependencyInjectionIntermidiate.Model;

namespace DependencyInjectionIntermidiate.Builder
{
    class ComputerBuilder
    {
        public IComputer CreateInstance()
        {
            return new Computer();
        }
    }
}
