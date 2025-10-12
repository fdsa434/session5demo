using Microsoft.AspNetCore.Mvc;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.bl.Sevices.DpartmentServices;
using session5demo.pl.ViewModels.DepartmentViewModel;
using System.Runtime.Intrinsics.Arm;

namespace session5demo.pl.Controllers.DepartmentController
{
    public class DepartmentController:Controller
    {
        private readonly IdepartmentServices _d;
        private readonly ILogger<DepartmentController> logger;
        private readonly IWebHostEnvironment webHost;

        public DepartmentController(IdepartmentServices d, ILogger<DepartmentController> log, IWebHostEnvironment webHost)
        {
            _d = d;
            logger = log;
            this.webHost = webHost;
        }
        public IActionResult Index()
        {
            var res = _d.getallservice();
            return View(res);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Updateddepartmentvm dep)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var depart = new createdepartmentdto()
                    {
                        
                        Name = dep.Name,
                        Code = dep.Code,
                        Description = dep.Description
                    };
                    var res = _d.adddept(depart);
              

                    if (res > 0)
                    {
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "cant create depaertment");
                        return View(dep);

                    }
                }

                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(dep);
                    }
                    else
                    {
                        throw;
                    }
                }

            }

            else
            {
                return View(dep);
            }

        }
        public IActionResult Details([FromRoute] int? id)
        {
            if (id is null) return BadRequest();
            var res = _d.getdetails(id.Value);
            if (res is null) return NotFound();

            return View(res);

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null) return BadRequest();
            var dep = _d.getdetails(id.Value);
            if (dep is null) return NotFound();
            var res = new Updateddepartmentvm()
            {
               Id = dep.Id,
                Name = dep.Name,
                Code = dep.Code,
                Description = dep.Description
            };
            return View(res);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int? id, Updateddepartmentvm dep)
        {
            if (!ModelState.IsValid) return View(dep);
            var depart = new updatedeprtmentdto()
            {
                Id = dep.Id,
                Name = dep.Name,
                Code = dep.Code,
                Description = dep.Description
            };
            if (ModelState.IsValid)
            {
                try
                {
                    var res2 = _d.updatedept(depart);
                    if (res2 > 0)
                    {
                        return RedirectToAction("index");

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "cant create depaertment");
                        return View(dep);

                    }
                }

                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(dep);
                    }
                    else
                    {
                        throw;
                    }
                }

            }

            else
            {
                return View(dep);
            }

        }
        [HttpGet]

        public IActionResult Delete(int? id)
        {
            if (id is null) return BadRequest();
            var dep = _d.getdetails(id.Value);
            if (dep is null) return NotFound();

            return View(dep);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete(int id)
        {
            var res = _d.deletedepartment(id);
            if (res > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }
    }
}

