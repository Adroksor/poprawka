using System.ComponentModel.DataAnnotations;

namespace poprawka
{
    public class Towar
    {
        [Key]
        public int ID { get; set; }
        public string Nazwa { get; set; }

        public string Jednostka { get; set; }
    }
}