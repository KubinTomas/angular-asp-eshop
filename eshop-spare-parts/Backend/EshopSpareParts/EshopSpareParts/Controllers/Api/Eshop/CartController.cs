using EshopSpareParts.Models.DTO;
using EshopSpareParts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class CartController : ApiController
    {
        private CartService _service;

        public CartController(CartService service)
        {
            _service = service;
        }

        //[HttpGet, Route("api/get/hashed/cart")]
        //public IHttpActionResult GetHashedString()
        //{

        //    var headers = Request.Headers;

        //    string cart = headers.GetValues("cart").FirstOrDefault();

        //    var res = _service.GetHashedCart(cart);

        //    return Ok(res);
        //}
        //[HttpGet, Route("api/get/unhashed/cart")]
        //public IHttpActionResult GetUnhashedString()
        //{
        //    var headers = Request.Headers;

        //    string cart = headers.GetValues("cart").FirstOrDefault();

        //    var res = cart;

        //    if (Regex.IsMatch(cart, @"^[a-zA-Z0-9\+/]*={0,2}$"))
        //         res = _service.GetUnhashedCart(cart);

        //    return Ok(res);
        //}
        [HttpPost, Route("api/get/hashed/cart")]
        public IHttpActionResult GetHashedString(CartDto cartDto)
        {
            var res = _service.GetHashedCart(cartDto.cart);

            return Ok(res);
        }

        [HttpPost, Route("api/get/unhashed/cart")]
        public IHttpActionResult GetUnhashedString(CartDto cartDto)
        {

            var res = cartDto.cart;

            if (Regex.IsMatch(cartDto.cart, @"^[a-zA-Z0-9\+/]*={0,2}$"))
                res = _service.GetUnhashedCart(cartDto.cart);

            return Ok(res);
        }

    }
}
