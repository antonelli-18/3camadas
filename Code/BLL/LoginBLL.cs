using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DAL;
using Projeto3Camadas.Code.DTO;


namespace Projeto3Camadas.Code.BLL
{
    class LoginBLL
    {
        Conexao conecao = new Conexao();
        string tabela = "tbl_login";


        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {tabela} where nome = '{loginDTO.Nomeusuario}' and senha = '{loginDTO.Senha}'";
            DataTable dt = conecao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }



    }
}
