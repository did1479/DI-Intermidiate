using DependencyInjectionIntermidiate.Interfaces;
using DependencyInjectionIntermidiate.Model;

namespace DependencyInjectionIntermidiate.Builder
{
    class ProcessorBuilder
    {
        public IProcessor CreateInstance()
        {
            return new Processor();
        }
    }
}