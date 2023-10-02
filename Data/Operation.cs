namespace DI.Lifetime.Sample.Data
{
    public class TransientOperation : ITransientOperation
    {
         Guid IOperation.OperationId { get; } = Guid.NewGuid();
        
    }

    public class ScopedOperation : IScopedOperation
    {
        Guid IOperation.OperationId { get; } = Guid.NewGuid();
    }

    public class SingletonOperation: ISingletonOperation
    {
        Guid IOperation.OperationId { get;} = Guid.NewGuid();
    }
}
