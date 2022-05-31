namespace BarberShop.Models.Barbeiros
{
    public class BarbeiroModel
    {
        public int Barbeiro_Id { get; set; }
        public string Name { get; set; }
        public Services Servicos { get; set; }
        public bool Status { get; set; }
    }
}
