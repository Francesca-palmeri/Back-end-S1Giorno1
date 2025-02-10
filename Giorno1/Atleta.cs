
namespace Giorno1
{
    public class Atleta
    {
        private string _firstName;
        private string _lastName;
        private string _country;
        private int _age;
        private string _mainSport;
        public string FirstName {
            get
            {
                return _firstName; 
            }
                 set {

                _firstName = value; 
            } 
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {

                _lastName = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {

                _country = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {

                _age = value;
            }
        }
        public string MainSport
        {
            get
            {
                return _mainSport;
            }
            set
            {

                _mainSport = value;
            }
        }

    }
}
