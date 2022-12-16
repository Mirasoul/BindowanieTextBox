namespace BindowanieTextBox
{
 
    public struct CechyCzlowiek
    {
        // public byte Age;
        // public byte Height;
        public string Name;
        public string Surname;
    }

    public class Czlowiek
    {    
        // private string _imie;
        private CechyCzlowiek _imie;
        private CechyCzlowiek _nazwisko;
        private string _dzialanie;

        public string ImieNaszegoCzlowieka
        {
            get
            {
                return _imie.Name;
            }

        }
        public string NazwiskoNaszegoCzlowieka
        {
            get
            {
                return _nazwisko.Surname;
            }

        }
        public string DzialanieNaszegoCzlowieka
        {
            get
            {
                return _dzialanie;
            }
            set
            {
                _dzialanie = value;
            }
        }

        public Czlowiek()
        {
            CzynnosciCzlowiek _czynnosci = new CzynnosciCzlowiek();
            _dzialanie = _czynnosci.Chodzi();
            _imie.Name = "Arkadiusz";
            _nazwisko.Surname = "Brzeczyszczykiewicz";
        }

    }
}
