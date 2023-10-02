using DI.Lifetime.Sample.Pages;

namespace DI.Lifetime.Sample.Data
{
    public interface IOperation
    {
        public Guid OperationId { get; }
        public ServiceLifetime LifeTime { get; }
    }

    public interface ITransientOperation : IOperation
    {
        ServiceLifetime IOperation.LifeTime => ServiceLifetime.Transient;
    }
    public interface IScopedOperation : IOperation {
        ServiceLifetime IOperation.LifeTime => ServiceLifetime.Scoped;
    }
    public interface ISingletonOperation: IOperation {
        ServiceLifetime IOperation.LifeTime => ServiceLifetime.Singleton;
    }

}
