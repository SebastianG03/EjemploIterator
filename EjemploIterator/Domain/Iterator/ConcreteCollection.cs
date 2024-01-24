namespace EjemploIterator.Domain.Iterator
{
    public class ConcreteCollection : Collection
    {
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion;

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override void Agregar(Item _item)
        {
            _listaItems.Add(_item);
        }

        public override Item Index(int _index)
        {
            _item = _listaItems[_index];
            _posicion = _index;
            return _item;
        }

        public override int Count()
        {
            return _listaItems.Count;
        }

        public override int Posicion()
        {
            return _posicion;
        }

    }
}
