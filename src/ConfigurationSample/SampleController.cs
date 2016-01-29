using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConfigurationSample
{
    public class SampleController : Controller
    {
        private readonly IMyInterface _service;

        public SampleController(IMyInterface service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        [Route("api/sample")]
        public string Get()
        {
            return _service.GetOption();
        }
 
    }
}
