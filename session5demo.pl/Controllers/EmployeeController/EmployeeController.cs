using Microsoft.AspNetCore.Mvc;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.bl.DtoS.EmployeeDtoS;
using session5demo.bl.Sevices.DpartmentServices;
using session5demo.bl.Sevices.EmployeeServices;
using session5demo.pl.ViewModels.DepartmentViewModel;
using session5demo.pl.ViewModels.Employeeupdatevm;

namespace session5demo.pl.Controllers.EmployeeController
{
    public class EmployeeController:Controller
    {
        private readonly IemployeeServices _d;
        private readonly ILogger<EmployeeController> logger;
        private readonly IWebHostEnvironment webHost;

        public EmployeeController(IemployeeServices d, ILogger<EmployeeController> log, IWebHostEnvironment webHost)
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
        public IActionResult Create(createemployeedto d)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var res = _d.addemployee(d);
                    if (res > 0)
                    {
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "cant create employee");
                        return View(d);

                    }
                }

                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(d);
                    }
                    else
                    {
                        throw;
                    }
                }

            }

            else
            {
                return View(d);
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
            var res = new Employeeupdatevm()
            {
                Id = dep.Id,
                Name = dep.Name,
                Age = dep.Age,
                Salary = dep.Salary,
                IsActive = dep.IsActive,
                Email = dep.Email,
                Gender = dep.Gender,
                EmployeeType = dep.EmployeeType

            };
            return View(res);

        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, updateemployeedto dep)
        {
            if (!ModelState.IsValid) return View(dep);
            var emp = new updateemployeedto()
            {
                Id = dep.Id,
                Name = dep.Name,
                Age = dep.Age,
                Salary = dep.Salary,
                IsActive = dep.IsActive,
                Email = dep.Email,
                Gender = dep.Gender,
                EmployeeType = dep.EmployeeType
            };
            if (ModelState.IsValid)
            {
                try
                {
                    var res2 = _d.updateemployee(emp);
                    if (res2 > 0)
                    {
                        return RedirectToAction("index");

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "cant create employee");
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
        public IActionResult Delete(int id)
        {
            var res = _d.deleteemployee(id);
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
