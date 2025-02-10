using Giorno1;

var atleta1 = new Atleta();

atleta1.MainSport = "Pallavolo";
atleta1.Country = "Italy";

Console.WriteLine(atleta1.Country + " " + atleta1.MainSport);

var dipendente1 = new Dipendente()
{
    FirstName = "Giulia",
    LastName = "Raimondi", 
    Age = 23,
    Gender = "Donna",
    Role = "Segretaria"
};

dipendente1.ShowData();