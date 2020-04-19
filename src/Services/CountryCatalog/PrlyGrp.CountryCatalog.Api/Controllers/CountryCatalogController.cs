using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using PrlyGrp.CountryCatalog.ApplicationCore.Interfaces;
using PrlyGrp.CountryCatalog.Infrastructure.Data;

namespace PrlyGrp.CountryCatalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryCatalogController : ControllerBase
    {
        public CountryCatalogController(CountryCatalogDbContext countryContext, IAsyncRepository<Country> countryRepo)
        {
            _countryContext = countryContext;
            _countryRepo = countryRepo;
        }

        private readonly CountryCatalogDbContext _countryContext;
        private readonly IAsyncRepository<Country> _countryRepo;

        public IEnumerable<Country> Get()
        {
            return _countryRepo.ListAllAsync().Result.ToArray();
        }

    }
}