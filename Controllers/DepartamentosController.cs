using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCorePostgresEC2V2.Models;
using MvcCorePostgresEC2V2.Repository;

namespace MvcCorePostgresEC2V2.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }

        public async Task<IActionResult> Details(int id)
        {
            Departamento dept = await this.repo.FindDepartamentoAsync(id);
            return View(dept);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento dept)
        {
            await this.repo.InsertDepartamentoAsync(dept.Id, dept.Nombre, dept.Localidad);
            return RedirectToAction("Index");
        }
    }
}
