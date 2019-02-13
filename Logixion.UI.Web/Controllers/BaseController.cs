using System.Linq;
using Logixion.Services.IService;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Logixion.UI.Web.Controllers
{
    public abstract class BaseController<TBusinessModel, TEntity, Tkey> : Controller where TBusinessModel:class where TEntity:class where Tkey:struct
    {
        private readonly IGenericService<TBusinessModel, TEntity, Tkey> _genericService;
        protected int Count=0;
        public BaseController(IGenericService<TBusinessModel, TEntity, Tkey> genericService)
        {
            _genericService = genericService;
        }
        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            var modelList =await _genericService.GetAsync();
            Count = modelList.Count();
            ViewBag.Total = Count;
            return View(modelList);
        }
        [HttpGet]
        public virtual async Task<ActionResult> Detail(Tkey id)
        {
            var model = await _genericService.GetAsync(id); 
            return View(model);
        }
    }
}