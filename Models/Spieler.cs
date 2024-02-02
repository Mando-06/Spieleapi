namespace Russian_Roulette.Models
{
    public class Spieler
    {
        //id
        public int Id { get; set; }

        //player
        public int Leben { get; set; } = 3;
        public bool AmLeben { get; set; } = true;

        //turn
        public bool istSpielerAmZug { get; set; }

        //chambers
        public int loadedChamber { get; set; }
        public int shotChamber { get; set; }
    }
}
