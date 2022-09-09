using ChatService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {

        private readonly IMessageService _messageService;

        public ClientController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        [Route("connect")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Connect(string name)
        {
            return Ok(_messageService.AddClient(name));
        }
    }
}