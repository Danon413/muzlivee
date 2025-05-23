﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout"), Authorize]
        public async Task<ActionResult<string>> CreateCheckoutSession([FromBody] OrderBookingRequest request)
        {
            var session = await _paymentService.CreateCheckoutSession(request.BookingDate);
            return Ok(session.Url);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> FulfillOrder()
        {
            var response = await _paymentService.FulfillOrder(Request);
            if (!response.Success)
                return BadRequest(response.Message);

            return Ok(response);
        }
    }

    // Добавь этот класс, если его нет в проекте:
    public class OrderBookingRequest
    {
        public DateTime? BookingDate { get; set; }
    }
}
