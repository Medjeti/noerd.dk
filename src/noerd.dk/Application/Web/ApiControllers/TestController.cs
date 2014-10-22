using System.Web.Http;

namespace noerd.dk.Application.Web.ApiControllers
{
    public class TestController : ApiController
    {
        /// <summary>
        /// /api/test/heartbeat
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Heartbeat()
        {
            return "We're alive!!";
        }
    }
}
