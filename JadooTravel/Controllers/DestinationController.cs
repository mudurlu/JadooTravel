﻿using JadooTravel.Dtos.DestinationDtos;
using JadooTravel.Services.DestinationServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JadooTravel.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IActionResult> DestinationList()
        {
            var values = await _destinationService.GetAllDestinationAsync();
            return View(values);
        }

        public IActionResult CreateDestination()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDestination(CreateDestinationDto createDestinationDto)
        {
            await _destinationService.CreateDestinationAsync(createDestinationDto);
            return RedirectToAction("DestinationList");
        }

        public async Task<IActionResult> DeleteDestination(string id)
        {
            await _destinationService.DeleteDestinationAsync(id);
            return RedirectToAction("DestinationList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDestination(string id)
        {
            var values = await _destinationService.GetDestinationByIdAsync(id);
            return View(values);
        }


        public async Task<IActionResult> UpdateDestination(UpdateDestinationDto updateDestinationDto)
        {
            await _destinationService.UpdateDestinationAsync(updateDestinationDto);
            return RedirectToAction("DestinationList");
        }
    }
}
