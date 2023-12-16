using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentInfoApp.Data;
using StudentInfoApp.Module;

namespace StudentInfoApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentInfoApp.Data.StudentInfoAppContext _context;

        public IndexModel(StudentInfoApp.Data.StudentInfoAppContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
