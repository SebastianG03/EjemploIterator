namespace EjemploIterator.Domain.Iterator
{
    public abstract class Iterator
    {
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}
