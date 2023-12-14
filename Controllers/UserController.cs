using Microsoft.AspNetCore.Mvc;

namespace module33.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        public UserController(ILogger logger) 
        {
            _logger= logger;
            _logger.WriteEvent("Сообщение о действии");
            _logger.WriteError("Сообщение об ошибке");
        }
        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Email = "test@mail.ru",
                Login = "test",
                Password = "test"
            }; 
        }
    }
}
