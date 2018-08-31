using Clientes_WebAPI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes_WebAPI.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Data_Nascimento { get; set; }
        public int Idade { get; set; }
        public int Profissao_Id { get; set; }

        public void RegisterClient()
        {
            DAL objDAL = new DAL();

            string sql = "insert into clientes(nome, sobrenome, cpf, data_nascimento, idade, profissao_id)" +
            $"values('{Nome}','{Sobrenome}','{Cpf}','{DateTime.Parse(Data_Nascimento).ToString("yyyy/MM/dd")}'," +
               $"'{Idade}','{Profissao_Id}')";

            objDAL.ExecuteCommandSQL(sql);
        }

        public void UpdateClient()
        {
            DAL objDAL = new DAL();

            string sql = "update clientes set " +
                         $"nome = '{Nome}', " +
                         $"sobrenome = '{Sobrenome}'," +
                         $"cpf = '{Cpf}'," +
                         $"data_nascimento = '{DateTime.Parse(Data_Nascimento).ToString("yyyy/MM/dd")}', " +
                         $"idade = '{Idade}', " +
                         $"profissao_id = '{Profissao_Id}' where id={Id}";

            objDAL.ExecuteCommandSQL(sql);
        }

        public void Delete(int id)
        {
            DAL objDal = new DAL();

            string sql = $"delete from clientes where id = {id}";
            objDal.ExecuteCommandSQL(sql);
            
        }

        public List<ClientModel> Listing()
        {
            List<ClientModel> list = new List<ClientModel>();
            ClientModel item;

            DAL objDAL = new DAL();
            string sql = "select * from clientes order by nome asc";
            DataTable dados = objDAL.ReturnDataTable(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                item = new ClientModel()
                {
                    Id = int.Parse(dados.Rows[i]["Id"].ToString()),
                    Nome = dados.Rows[i]["Nome"].ToString(),
                    Sobrenome = dados.Rows[i]["Sobrenome"].ToString(),
                    Cpf = dados.Rows[i]["Cpf"].ToString(),
                    Data_Nascimento = DateTime.Parse(dados.Rows[i]["Data_Nascimento"].ToString()).ToString("dd/MM/yyyy"),
                    Idade = int.Parse(dados.Rows[i]["Idade"].ToString()),
                    Profissao_Id = int.Parse(dados.Rows[i]["Profissao_Id"].ToString())
                };

                list.Add(item);
            }

            return list;

        }

        public ClientModel ReturnClient(int id)
        {
            ClientModel item;
            DAL objDAL = new DAL();


            string sql = $"select * from clientes where id = {id}";
            DataTable dados = objDAL.ReturnDataTable(sql);

            item = new ClientModel()
            {
                Id = int.Parse(dados.Rows[0]["Id"].ToString()),
                Nome = dados.Rows[0]["Nome"].ToString(),
                Sobrenome = dados.Rows[0]["Sobrenome"].ToString(),
                Cpf = dados.Rows[0]["Cpf"].ToString(),
                Data_Nascimento = DateTime.Parse(dados.Rows[0]["Data_Nascimento"].ToString()).ToString("dd/MM/yyyy"),
                Idade = int.Parse(dados.Rows[0]["Idade"].ToString()),
                Profissao_Id = int.Parse(dados.Rows[0]["Profissao_Id"].ToString())
            };

            return item;
        }
    }
}
