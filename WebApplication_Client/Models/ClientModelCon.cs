using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Client.Util;
using Newtonsoft.Json;

namespace WebApplication_Client.Models
{
    public class ClientModelCon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Data_Nascimento { get; set; }
        public int Idade { get; set; }
        public int Profissao_Id { get; set; }

        public List<ClientModelCon> ListAllClients()
        {
            List<ClientModelCon> returnService = new List<ClientModelCon>();
            string json = WebAPI.RequestGET("listing", string.Empty);

            returnService = JsonConvert.DeserializeObject<List<ClientModelCon>>(json);
            return returnService;
        }

        
        public ClientModelCon ToCharge(int? id)
        {
            ClientModelCon returnService = new ClientModelCon();
            string json = WebAPI.RequestGET("update", id.ToString());

            returnService = JsonConvert.DeserializeObject<ClientModelCon>(json);
            return returnService;
        }

        public void Insert()
        {

            string jsonData = JsonConvert.SerializeObject(this);
            string json = string.Empty;

            if (Id == 0)
            {
                WebAPI.RequestPOST("registerclient", jsonData);
            }
            else
            {
                WebAPI.RequestPUT("update/"+Id, jsonData);
            }
        }

        public void Delete(int id)
        {
            string json = WebAPI.RequestDELETE("delete", id.ToString());
        }



        
           
    }
}
