namespace DependencyInjectionIntermidiate.Interfaces
{
    interface IMetacubeGoalProject
    {
        IComputer Computer { get; set; }

        IProcessor Process { get; set; }
    }
}
