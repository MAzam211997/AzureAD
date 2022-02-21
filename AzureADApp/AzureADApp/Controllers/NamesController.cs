using AzureADApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureADApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        [Authorize(Roles = "Api.ReadWriteClient,Api.ReadOnlyClientApp")]
        [Route("GetNames")]
        public IActionResult GetNames()
        {
            return Ok(Data.NamesList);
        }

        [Authorize(Roles = "Api.ReadWriteClient")]
        [Route("PostName")]
        public IActionResult PostName([FromBody] NamesModel model)
        {
            Data.NamesList.Add(model);
            return Ok(Data.NamesList);
        }
    }
}
