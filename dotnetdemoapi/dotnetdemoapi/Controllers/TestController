using Microsoft.AspNetCore.Mvc;

namespace dotnetdemoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] tests = new[]
        {
            "test1", "employee", "test2", "test3"
        };

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public IEnumerable<TestModel> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new TestModel
            {
                number=index,
                Name = tests[Random.Shared.Next(tests.Length)]
            })
            .ToArray();
        }
    }
}
