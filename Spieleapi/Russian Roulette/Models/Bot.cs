namespace Russian_Roulette.Models
{
    public class Bot
    {
        public int Id { get; set; }

        public int Leben { get; set; } = 3;
        public bool AmLeben { get; set; } = true;

        public bool istSpielerAmZug { get; set; }
    }
}
