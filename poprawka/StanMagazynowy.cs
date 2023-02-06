using System.ComponentModel.DataAnnotations;

namespace poprawka
{
    public class StanMagazynowy
    {
        [Key]
        public int ID { get; set; }
        public int Ilosc { get; set; }
        public int ID_Towaru { get; set; }


    }
}