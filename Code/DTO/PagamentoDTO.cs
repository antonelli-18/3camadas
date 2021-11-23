using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class Pagamento_DTO
    {
        private string _id;
        private string _namefuncionario;
        private double _preco;

        public string Id { get => _id; set => _id = value; }
        public string Namefuncionario { get => _namefuncionario; set => _namefuncionario = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
