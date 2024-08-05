using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly IBusinessClass _businessClass;
        public ValuesController(IBusinessClass businessclass)

        {
            _businessClass = businessclass;


        }

        [HttpGet]
        public int Get(int i, int j)
        {
            //BusinessLogic businessLogic = new BusinessLogic();
            var data = _businessClass.sumoftwo(i, j);
            return data;
        }
    }
}
