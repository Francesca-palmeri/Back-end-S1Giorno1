

namespace Giorno1
{
    public class Dipendente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }

        public void ShowData()
        {
            Console.WriteLine("In data odierna il dipendente " + FirstName + " " + LastName + " di età " + Age + " il cui ruolo è " + Role + " ha completato con successo il corso sulla sicurezza");
        }


    }
}
