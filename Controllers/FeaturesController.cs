using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWebApp.Controllers.Resources;
using AngularWebApp.Persistence;
using AutoMapper;
using AngularWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularWebApp.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly AngularWebAppDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(AngularWebAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResources>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResources>>(features);
        }
    }
}