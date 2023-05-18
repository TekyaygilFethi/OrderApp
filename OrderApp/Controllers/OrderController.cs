﻿using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using OrderApp.Repository.Services;

namespace OrderApp.API.Controllers
{
    public class OrderController : CustomBaseController
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService orderService)
        {
            _service = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            return Ok(await _service.RemoveAsync(id));
        }
    }
}
