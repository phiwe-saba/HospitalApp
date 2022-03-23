#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalAppCore.Entites;
using HospitalAppDAL;

namespace HospitalApp.Views.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HospitalAppDAL.HospitalDbContext _context;

        public IndexModel(HospitalAppDAL.HospitalDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; }

        public async Task OnGetAsync()
        {
            Patient = await _context.Patients.ToListAsync();
        }
    }
}
