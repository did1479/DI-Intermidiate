using DependencyInjectionIntermidiate.Interfaces;

namespace DependencyInjectionIntermidiate.Model
{
    class Processor : IProcessor
    {
        public string CompanyName { get; set; }

        public string ClockSpeed { get; set; }
    }
}
