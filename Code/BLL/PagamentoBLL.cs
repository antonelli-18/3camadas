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
    class Pagamento_BLL
    {
        Conexao conecao = new Conexao();
        string tabela = "tbl_pagamento";

       

        public void Inserir(Pagamento_DTO pagDTO) 
        {
            string inserir = $"insert into {tabela} value (null, '{pagDTO.Namefuncionario}', '{pagDTO.Preco}')";
            conecao.ExecutarComando(inserir);
        }

       


        public void Editar(Pagamento_DTO pagDTO) 
        {
            string alterar = $"update {tabela} set nomefuncionario = '{pagDTO.Namefuncionario}', preco = '{pagDTO.Preco}'," +
                $" where id = '{pagDTO.Id}' ";
            conecao.ExecutarComando(alterar);
        }


        public void Exclui(Pagamento_DTO pagDTO) 
        {
            string excluir = $"delete from {tabela} where id = '{pagDTO.Id}'";
            conecao.ExecutarComando(excluir);
        }

        public DataTable Listar() 
        {
            string sql = $"select * from {tabela} order by id;";
            return conecao.ExecutarConsulta(sql); 
        }  

    }
}
