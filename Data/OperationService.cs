namespace DI.Lifetime.Sample.Data
{
    public class OperationService
    {
        public ITransientOperation TransientOperation { get; }
        public IScopedOperation ScopedOperation { get; }
        public ISingletonOperation SingletonOperation { get; }

        public OperationService(ITransientOperation transientOperation, 
            ISingletonOperation singletonOperation, 
            IScopedOperation scopedOperation)
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
        }
    }
}
