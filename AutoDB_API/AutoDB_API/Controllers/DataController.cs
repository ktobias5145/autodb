using AutoDB_API.DAL;
using AutoDB_API.DAL.DAO;
using AutoDB_API.DAL.DomainClasses;
using AutoDB_API.DAL.HelperClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Data.Common;

namespace AutoDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public VehicleController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

         [HttpGet]
         public async Task<ActionResult<List<VehicleHelper>>> GetAllVehicles()
         {
            VehicleDAO dao = new(_appDbContext);
             List<VehicleHelper> list = await dao.GetAllVehicles();
             return list;
         } 
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController :ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ManufacturerController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Manufacturers>>> Index()
        {
            ManufacturerDAO dao = new(_appDbContext);
            List<Manufacturers> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class BodyStyleController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public BodyStyleController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<BodyStyles>>> Index()
        {
            BodyStyleDAO dao = new(_appDbContext);
            List<BodyStyles> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ModelController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models>>> Index()
        {
            ModelDAO dao = new(_appDbContext);
            List<Models> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class InteriorController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public InteriorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Interiors>>> Index()
        {
            InteriorDAO dao = new(_appDbContext);
            List<Interiors> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class InfotainmentController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public InfotainmentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Infotainments>>> Index()
        {
            InfotainmentDAO dao = new(_appDbContext);
            List<Infotainments> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ExteriorController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ExteriorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Exteriors>>> Index()
        {
            ExteriorDAO dao = new(_appDbContext);
            List<Exteriors> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public DimensionController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Dimensions>>> Index()
        {
            DimensionDAO dao = new(_appDbContext);
            List<Dimensions> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TrimLevelController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public TrimLevelController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<TrimLevels>>> Index()
        {
            TrimLevelDAO dao = new(_appDbContext);
            List<TrimLevels> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class GearingController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public GearingController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Gearings>>> Index()
        {
           GearingDAO dao = new(_appDbContext);
            List<Gearings> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public TransmissionController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<TransmissionTypes>>> Index()
        {
            TransmissionTypeDAO dao = new(_appDbContext);
            List<TransmissionTypes> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicalController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public MechanicalController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mechanicals>>> Index()
        {
            MechanicalDAO dao = new(_appDbContext);
            List<Mechanicals> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVarationController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ProductVarationController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductVarations>>> Index()
        {
            ProductVarationDAO dao = new(_appDbContext);
            List<ProductVarations> list = await dao.GetAll();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVarationHelperController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ProductVarationHelperController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductVarationHelper>>> Index()
        {
            ProductHelperDAO dao = new(_appDbContext);
            List<ProductVarationHelper> list = dao.GetAllProductVarations();
            return list;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleHelperController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public VehicleHelperController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<List<VehicleHelper>>> Index([FromBody]List<ParamaterList> parameters)
        {

            VehicleHelperDAO dao = new(_appDbContext);
            List<VehicleHelper> list = dao.GetAllVehicleVarations(parameters);
            return Ok(list);
            //return Ok();
        }
    }
}
