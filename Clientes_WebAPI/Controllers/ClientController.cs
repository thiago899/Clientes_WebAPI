using System;
using System.Collections.Generic;
using System.Data;
using Clientes_WebAPI.Models;
using Clientes_WebAPI.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clientes_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        Authentification AuthenficateService;

        public ClientController(IHttpContextAccessor context)
        {
            AuthenficateService = new Authentification(context);
        }

        // GET api/values
        [HttpGet]
        [Route("listing")]
        public List<ClientModel> Listing()

        {
            return new ClientModel().Listing();
         
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Route("client/{id}")]
        public ClientModel ReturnClient(int id)
        {
            return new ClientModel().ReturnClient(id);
        }

        // POST api/values
        [HttpPost]
        [Route("registerclient")]
        public ReturnAllServices RegisterClient([FromBody] ClientModel dados)
        {
            ReturnAllServices returnService = new ReturnAllServices();

            try
            {
                dados.RegisterClient();
                returnService.Result = true;
                returnService.ErrorMessage = string.Empty;
            }
            catch(Exception ex)
            {
                returnService.Result = false;
                returnService.ErrorMessage = "Erro ao tentar registrar um cliente: " + ex.Message;
            }

            return returnService;
            
        }

        // PUT api/values/5
        [HttpPut]
        [Route("update/{id}")]
        public ReturnAllServices Update(int id, [FromBody] ClientModel dados)
        {
            ReturnAllServices returnService = new ReturnAllServices();

            try
            {
                dados.Id = id;
                dados.UpdateClient();
                returnService.Result = true;
                returnService.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                returnService.Result = false;
                returnService.ErrorMessage = "Erro ao tentar atualizar um cliente: " + ex.Message;
            }

            return returnService;
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("delete/{id}")]
        public ReturnAllServices Delete(int id)
        {
            ReturnAllServices returnService = new ReturnAllServices();
            try
            {
                returnService.Result = true;
                returnService.ErrorMessage = "Cliente excluído com sucesso!";
                AuthenficateService.Authenticate();
                new ClientModel().Delete(id);
            }
            catch(Exception ex)
            {
                returnService.Result = false;
                returnService.ErrorMessage = ex.Message;
                
            }
            return returnService;

        }
    }
}
