using AutoMapper;
using EshopSpareParts.Models;
using EshopSpareParts.Models.CustomReturnCodes;
using EshopSpareParts.Models.Db;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Models.DTO.ServicesReturnClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EshopSpareParts.Services
{
    public class OrderService : Service
    {
        private ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<OrderServiceDto> GetTranspoertCompaniesAsync()
        {
            var transportCompanies = await _context.TransportCompanies.ToListAsync();

            var transportCompaniesDto = new List<TransportCompanyDto>();

            foreach (var transportCompany in transportCompanies)
            {
                var transportCompanyDto = Mapper.Map<TransportCompany, TransportCompanyDto>(transportCompany);

                transportCompaniesDto.Add(transportCompanyDto);
            }

            return new OrderServiceDto { TransportCompaniesDto = transportCompaniesDto, StatusCode = ReturnCodes.Ok };

        }

        public async Task<OrderServiceDto> GetOrderAsync(string code)
        {
            var orderInDb = await _context.Orders
                                          .Include(o => o.CompleteOrderSummary)
                                          .Include(o => o.Status)
                                          .SingleOrDefaultAsync(c => c.Code == code);

            if (orderInDb == null)
                return new OrderServiceDto { StatusCode = ReturnCodes.BadRequest };

            var orderTransport = await _context.OrderTransports
                                          .Include(o => o.TransportCompany)
                                          .SingleOrDefaultAsync(c => c.Id == orderInDb.CompleteOrderSummary.OrderTransportId);

            var orderDto = new OrderDto();

            orderDto.created = orderInDb.Created;
            orderDto.finished = orderInDb.Finished;

            orderDto.status = new StatusDto()
            {
                code = orderInDb.Status.Code
            };

            orderDto.orderSummary = new CompleteOrderSummaryDto()
            {
                email = orderInDb.CompleteOrderSummary.Email,
                name = orderInDb.CompleteOrderSummary.Name,
                surname = orderInDb.CompleteOrderSummary.Surname,
                phone = orderInDb.CompleteOrderSummary.Phone,
                totalPrice = orderInDb.CompleteOrderSummary.TotalPrice,
                deliveryTown = orderInDb.CompleteOrderSummary.DeliveryTown,
                deliveryTownStreet = orderInDb.CompleteOrderSummary.DeliveryTownStreet,
                deliveryTownNumber = orderInDb.CompleteOrderSummary.DeliveryTownNumber,
                invoiceTown = orderInDb.CompleteOrderSummary.InvoiceTown,
                invoiceTownStreet = orderInDb.CompleteOrderSummary.InvoiceTownStreet,
                invoiceTownNumber = orderInDb.CompleteOrderSummary.InvoiceTownNumber,
            };
            orderDto.orderTransport = new OrderTransportDto()
            {
                name = orderTransport.TransportCompany.Name,
                weight = orderTransport.Weight,
                transportPrice = orderTransport.TransportPrice.ToString()
            };

            var items = new List<ItemDto>();

            var itemsForOrder = _context.OrderItems.Include(i => i.Item)
                                                   .Where(c => c.OrderId == orderInDb.Id);

            foreach (var item in itemsForOrder)
            {
                var itemDto = new ItemDto()
                {
                    countInCart = item.ItemCount,
                    price = item.ItemPrice,
                    imagePath = item.Item.ImagePath,
                    id = item.ItemId,
                    title = item.Item.Title
                };

                items.Add(itemDto);
            }

            orderDto.items = items;

            return new OrderServiceDto { OrderDto = orderDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<OrderServiceDto> GetOrdersAsync(int userId)
        {
            var ordersInDb = await _context.Orders
                                          .Include(o => o.CompleteOrderSummary)
                                          .Include(o => o.Status)
                                          .Where(c => c.CompleteOrderSummary.UserId == userId)
                                          .OrderByDescending(c => c.Id)
                                          .ToListAsync();

            if (ordersInDb == null)
                return new OrderServiceDto { StatusCode = ReturnCodes.BadRequest };

            var ordersDto = new List<OrderDto>();

            foreach(var order in ordersInDb)
            {
                var orderDto = new OrderDto()
                {
                    code = order.Code,
                    created = order.Created,
                    finished = order.Finished,
                };

                orderDto.status = new StatusDto()
                {
                    code = order.Status.Code
                };

                ordersDto.Add(orderDto);
            }

            return new OrderServiceDto { Orders = ordersDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<OrderServiceDto> GetAllOrdersAsync()
        {
            var ordersInDb = await _context.Orders
                                          .Include(o => o.CompleteOrderSummary)
                                          .Include(o => o.Status)
                                          .ToListAsync();

            if (ordersInDb == null)
                return new OrderServiceDto { StatusCode = ReturnCodes.BadRequest };

            var ordersDto = new List<OrderDto>();

            foreach (var order in ordersInDb)
            {
                var orderDto = new OrderDto()
                {
                    code = order.Code,
                    created = order.Created,
                    finished = order.Finished,
                };

                orderDto.status = new StatusDto()
                {
                    code = order.Status.Code
                };

                ordersDto.Add(orderDto);
            }

            return new OrderServiceDto { Orders = ordersDto, StatusCode = ReturnCodes.Ok };
        }
        private int GetPrice(int deliveryCompanyId, float weight)
        {
            if (deliveryCompanyId == TransportCompany.CeskaPosta)
                return GetPriceForCeskaPosta(weight);
            else if (deliveryCompanyId == TransportCompany.DPP)
                return GetPriceForDPP(weight);
            else return 9999999;
        }
        private int GetPriceForCeskaPosta(float weight)
        {
            if (weight < 1)
            {
                return 99;
            }
            else if (weight >= 1 && weight < 5)
            {
                return 180;
            }
            else if (weight >= 5 && weight < 30)
            {
                return 250;
            }
            else
            {
                return 0;
            }
        }
        private int GetPriceForDPP(float weight)
        {
            if (weight < 1)
            {
                return 155;
            }
            else if (weight >= 1 && weight < 5)
            {
                return 185;
            }
            else if (weight >= 5 && weight < 30)
            {
                return 275;
            }
            else if (weight >= 30 && weight <= 50)
            {
                return 571;
            }
            else
            {
                return 0;
            }
        }
        private string WeightReplace(string weight)
        {
            return weight.Replace('.', ',');
        }

        public async Task<OrderServiceDto> CreateOrderAsync(OrderDto orderDto)
        {

            var orderTransport = new OrderTransport()
            {
                TransportCompanyId = orderDto.orderTransport.transportCompanyId,
                TransportPrice = Convert.ToInt32(orderDto.orderTransport.transportPrice),
                Weight = orderDto.orderTransport.weight
            };

            _context.OrderTransports.Add(orderTransport);

            await _context.SaveChangesAsync();


            var orderSummary = Mapper.Map<CompleteOrderSummaryDto, CompleteOrderSummary>(orderDto.orderSummary);

            if (orderDto.user.Id == 0)
                orderSummary.UserId = null;
            else
                orderSummary.UserId = orderDto.user.Id;

            orderSummary.OrderTransportId = orderTransport.Id;

            _context.CompleteOrderSummaries.Add(orderSummary);

            await _context.SaveChangesAsync();

            var order = new Order()
            {
                CompleteOrderSummaryId = orderSummary.Id,
                Created = DateTime.Now,
                StatusId = Status.Pending,
                Code = Guid.NewGuid() + orderSummary.Id.ToString()
            };

            _context.Orders.Add(order);

            orderDto.created = order.Created;
            orderDto.code = order.Code;

            await _context.SaveChangesAsync();

            var orderItems = new List<OrderItem>();

            foreach (var item in orderDto.items)
            {
                var orderItem = new OrderItem()
                {
                    ItemCount = item.countInCart,
                    ItemPrice = item.price,
                    ItemId = item.id,
                    OrderId = order.Id
                };

                orderItems.Add(orderItem);
            }

            _context.OrderItems.AddRange(orderItems);

            await _context.SaveChangesAsync();

            using (EmailService emailService = new EmailService(orderDto.orderSummary.email))
            {
                emailService.SendEmail(orderDto);
            }

            using (EmailService emailService = new EmailService("info@ndusti.cz"))
            {
                emailService.SendEmail(orderDto);
            }

            return new OrderServiceDto { StatusCode = ReturnCodes.Ok };

        }

    }
}
