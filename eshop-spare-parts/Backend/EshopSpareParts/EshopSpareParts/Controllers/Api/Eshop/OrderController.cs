using EshopSpareParts.Models;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class OrderController : ApiController
    {
        private ApplicationDbContext _context;
        private OrderService _service;

        public OrderController(ApplicationDbContext contex, OrderService service)
        {
            _context = contex;
            _service = service;
        }

        [HttpGet, Route("api/get/order/transport/companies")]
        public async Task<IHttpActionResult> GetTransportCompanies()
        {
            var orderServiceDto = await _service.GetTranspoertCompaniesAsync();

            return Ok(orderServiceDto);
        }
        [HttpPost, Route("api/create/order")]
        public async Task<IHttpActionResult> CreateOrder(OrderDto order)
        {
            var orderServiceDto = await _service.CreateOrderAsync(order);

            return Ok(orderServiceDto);
        }
        [HttpGet, Route("api/get/order/{code}")]
        public async Task<IHttpActionResult> GetOrder(string code)
        {
            var orderServiceDto = await _service.GetOrderAsync(code);

            return Ok(orderServiceDto);
        }
        [HttpGet, Route("api/get/orders/{userId}")]
        public async Task<IHttpActionResult> GetOrders(int userId)
        {
            var orderServiceDto = await _service.GetOrdersAsync(userId);

            return Ok(orderServiceDto);
        }
        [HttpGet, Route("api/get/all/orders")]
        public async Task<IHttpActionResult> GetAllOrders()
        {
            var orderServiceDto = await _service.GetAllOrdersAsync();

            return Ok(orderServiceDto);
        }
        [HttpPost, Route("api/send/question")]
        public async void SendQuestion(QuestionDto question)
        {
            using (EmailService emailService = new EmailService("info@ndusti.cz"))
            {
                emailService.SendQuestionEmail(question);
            }

        }
    }
}
