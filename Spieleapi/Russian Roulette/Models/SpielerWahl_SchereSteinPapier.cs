namespace Russian_Roulette.Models
{
    public class SpielerWahl_SchereSteinPapier
    {
        public int Id { get; set; } 
        public bool Schere { get; set; } = false;
        public bool Stein { get; set; } = false;
        public bool Papier { get; set; } = false;
    }
}
