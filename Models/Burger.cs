namespace MC_dostalas.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string? Name { get; set; }
        public Boolean WithCheese { get; set; }

        public List<Promo>? Promo { get; set; }
            
    }
}
