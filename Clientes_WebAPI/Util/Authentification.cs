using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes_WebAPI.Util
{
    public class Authentification
    {
        public static string TOKEN = "123safaspazAjiSgAkoZjA8Amk";
        public static string FAIL_AUTHENTIFICATION = "Falha na Autentificação... O Token informado é inválido!";
        IHttpContextAccessor contextAccessor;

        public Authentification(IHttpContextAccessor context)
        {
            contextAccessor = context;
        }

        public void Authenticate()
        {
            try
            {
                string TokenReceived = contextAccessor.HttpContext.Request.Headers["Token"].ToString();
                if (String.Equals(TOKEN, TokenReceived) == false)
                {
                    throw new Exception(FAIL_AUTHENTIFICATION);
                }
            }
            catch (Exception)
            {

                throw new Exception(FAIL_AUTHENTIFICATION);
            }
        }
    }
}
