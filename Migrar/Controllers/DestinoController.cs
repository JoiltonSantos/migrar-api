using Migrar.Data;
using Migrar.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Migrar.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class DestinoController : ControllerBase
  {

    private readonly DataContext _dataContext;


    public DestinoController(DataContext dataContext)
    {
      _dataContext = dataContext;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destino>>> GetDestinos()
    {
      return await _dataContext.Destinos.ToListAsync();
    }

  }

}