using System;
using DependencyInjectionIntermidiate.Interfaces;

namespace DependencyInjectionIntermidiate.WebContext
{
    class ContextFactory
    {
        public static Lazy<ContextFactory> ContextFactoryLazy = new Lazy<ContextFactory>(() => new ContextFactory());

        private IApplicationContext wrappedContext;

        public static IApplicationContext Current
        {
            get => ContextFactory.ContextFactoryLazy.Value.wrappedContext;
            set => ContextFactory.ContextFactoryLazy.Value.wrappedContext = value;
        }
    }
}
