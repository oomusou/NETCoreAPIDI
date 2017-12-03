using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreAPIDI.Services;

namespace NETCoreAPIDI.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        // GET api/order
        [HttpGet]
        public string Get()
        {
            return this.orderService.CreateOrder();
        }
    }
}
