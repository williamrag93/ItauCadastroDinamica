using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnaliseCreditoItau.Models
{
    
    public class CadastroContext :DbContext
    {
        //Local central de acesso a dados via Entity
        //DbCadastroClientes é a conectionstring que está configurada lá no web.config
        public CadastroContext() : base("DbCadastroClientes")
        {

        }

        //DbSet representa uma abstração da tabela clientes que será gerada no banco de dados
        public DbSet<Cliente> Clientes { get; set; }
    }
}