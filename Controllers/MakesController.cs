using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularWebApp.Models;
using AngularWebApp.Persistence;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AngularWebApp.Controllers.Resources;

namespace AngularWebApp.Controllers
{
    public class MakesController : Controller
    {
        private readonly AngularWebAppDbContext context;
        private readonly IMapper mapper;

        public MakesController(AngularWebAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}