
using Newtonsoft.Json;

namespace EjemploIterator.Domain.Iterator
{
    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        public Item(string _nom)
        {
            Nombre = _nom;
        }

        public Item(string _nom, int id)
        {
            Id = id;
            Nombre = _nom;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
