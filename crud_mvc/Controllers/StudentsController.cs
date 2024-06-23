using crud_mvc.Models;
using crud_mvc.Models.entity;
using crud_mvc.service;
using Microsoft.AspNetCore.Mvc;

namespace crud_mvc.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AplicationDbcontextClass dbContext;

        public StudentsController(AplicationDbcontextClass dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Add(AddStudentViewModel viewModel)
        {

            var student = new Student {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone=viewModel.Phone,
                Subscribed=viewModel.Subscribed,
            };
            await dbContext.Students.AddAsync(student);

            await dbContext.SaveChangesAsync();
            return View();
        }

    }
}
