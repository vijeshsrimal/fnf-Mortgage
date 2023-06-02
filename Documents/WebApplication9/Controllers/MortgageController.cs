using Microsoft.AspNetCore.Mvc;
using System;
using Interfaces;
using MortgageFraudsDetectionModels.Models;

namespace WebApplication9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MortgageController : Controller
    {

        private readonly IMortagageFraudService _service;

        public MortgageController(IMortagageFraudService service)
        {
            _service = service;
        }

        [HttpGet("PurchasePower")]
        public async Task<string> PurchasePower()
        {
            return await _service.PurchasePower();
        }

        [HttpGet("CheckMarketvalue")]
        public async Task<string> ChecKMarketValue()
        {
            return await _service.CheckMarketValue();
        }

        [HttpGet("CheckLawyerOpinion")]
        public async Task<bool> CheckLawyerOpinion()
        {
            return await _service.CheckLawyerOpinion();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
