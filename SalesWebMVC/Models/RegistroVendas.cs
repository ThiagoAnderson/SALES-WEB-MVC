using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusVenda  StatusVenda { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {
            
        }

        public RegistroVendas(int id, DateTime data, double quantia, StatusVenda statusVenda, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            StatusVenda = statusVenda;
            Vendedor = vendedor;
        }
    }
}
