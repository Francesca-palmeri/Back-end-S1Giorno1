

namespace Giorno1
{
    public class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Età { get; set; }
        public string Habitat { get; set; }
        public void ShowAnimal()
        {
            Console.WriteLine("Il mio animale si chiama " + Nome + " è un " + Specie + " ha compiuto " + Età + " anni e il suo habitat naturale è " + Habitat);
        }
    }

    
}
