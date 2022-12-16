namespace BindowanieTextBox
{
    interface ICzynnosciCzlowiek
    {
        string Mowi();
        string Pisze();
        string Chodzi();
    }
    public class CzynnosciCzlowiek: ICzynnosciCzlowiek
    {
        public string Mowi()
        {
            return "Mowi";
        }
        public string Pisze()
        {
            return "Pisze";
        }
        public string Chodzi()
        {
            return "Chodzi";
        }
    }
}
