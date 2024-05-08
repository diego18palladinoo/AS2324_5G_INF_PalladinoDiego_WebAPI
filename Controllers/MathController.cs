using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AS2324_5G_INF_PalladinoDiego_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        // 2. Dati due numeri indicare se il primo è un multiplo intero del secondo multiplointero(int num, int factor) (1 punto)
        [HttpGet("GetMultiplo")]
        public JsonResult GetMultiplo(int num, int factor)
        {
            bool multiplo = true;
            string status_result = "OK";
            if(num%factor == 0)
            {
                return new JsonResult(new {output = multiplo, message ="il numero "+ num + " è multiplo di " + factor, status = status_result});
            }
            else
            {
                multiplo = false;
                return new JsonResult(new { output = multiplo, message = "il numero " + num + " non è multiplo di " + factor });
            }

        }

        // 3. Dati un numero calcolarne l'elevamento a potenza potenza(int b, int esponente) (2 punto)
        [HttpGet("GetPotenza")]
        public JsonResult GetPotenza(int b, int esponente)
        {
            string status_result = "OK";
            int res = 1;
            for(int i = 0; i< esponente; i++)
            {
                res = res * b;
            }
            return new JsonResult(new { output = res, message = "l'elevamento a potenza di " + b + " è " + res, status = status_result});
        }

        // 4. Dato un anno indicare se è bisestile bisestile(int anno) (2 punto)
        [HttpGet("GetAnnoBisestile")]
        public JsonResult GetAnnoBisestile(int anno)
        {
            bool anno_bisestile = true;
            string status_result = "OK";
            if((anno % 4 == 0 &&  anno % 100 != 0) || anno % 400 == 0)
            {
                return new JsonResult(new {output = anno_bisestile, message = "l'anno " + anno + " è bisestile", status = status_result }); 
            }
            else
            {
                return new JsonResult(new { message = "l'anno " + anno + " non è bisestile", status = status_result });
            }
        }

        // 5. Dato i valori dei due cateti calcolare l'ipotenusa ipotenusa(double cateto1, double cateto2) (2 punto) 
        [HttpGet("GetIpotenusa")]
        public JsonResult GetIpotenusa(double cateto1, double cateto2)
        {
            string status_result = "OK";
            double ipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
            return new JsonResult(new { output = ipotenusa, message = "l'ipotenusa è " + ipotenusa, status = status_result });
        }

    }
}
