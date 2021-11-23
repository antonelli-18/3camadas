using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class LoginDTO
    {
        private string _id;
        private string _nomeusuario;
        private string _senha;

        public string Id { get => _id; set => _id = value; }
        public string Nomeusuario { get => _nomeusuario; set => _nomeusuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
