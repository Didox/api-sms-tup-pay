using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_sms_tup_pay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_sms_tup_pay.Controllers
{
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ILogger<SmsController> _logger;

        public SmsController(ILogger<SmsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public string Index(){
            return "Bem vindo a API de SMS tup pay";
        }


        [HttpPost]
        [Route("/sms/enviar")]
        public SmsResultado Envio([FromBody] Sms sms)
        {
            return new SmsResultado(){
                IdConfirmacaoEnvio = new DateTime().ToString("ddmmyyyHHMMSS"),
                Status = "Enviado com sucesso"
            };
        }
    }
}
