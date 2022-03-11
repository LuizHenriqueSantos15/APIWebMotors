using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMotors.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Preco { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Quilometragem { get; set; }
        public string Consumo { get; set; }
        public string Localidade { get; set; }
        public string Foto { get; set; }
    }
}
