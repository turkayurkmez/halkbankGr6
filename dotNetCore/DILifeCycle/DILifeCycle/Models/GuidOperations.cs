namespace DILifeCycle.Models
{
    public interface IGuidGenerator
    {
        Guid Guid { get; set; }
    }

    public interface ISingletonGuid : IGuidGenerator
    {

    }

    public interface IScopedGuid : IGuidGenerator { }
    public interface ITransientGuid : IGuidGenerator { }

    public class SingletonGuid : ISingletonGuid
    {
        public SingletonGuid()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid { get; set; }
    }

    public class ScopedGuid : IScopedGuid
    {
        public ScopedGuid()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid { get; set; }

    }

    public class TransientGuid : ITransientGuid
    {
        public TransientGuid()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid { get; set; }

    }

    public class GuidService
    {
        public ISingletonGuid Singleton { get; set; }
        public ITransientGuid Transient { get; set; }
        public IScopedGuid Scoped { get; set; }

        public GuidService(ISingletonGuid singleton, ITransientGuid transient, IScopedGuid scoped)
        {
            Singleton = singleton;
            Transient = transient;
            Scoped = scoped;
        }
    }
}
