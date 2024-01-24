using Newtonsoft.Json;

namespace EjemploIterator.Domain.Model
{
    public class ItemModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        public ItemModel() { }

    }
}
