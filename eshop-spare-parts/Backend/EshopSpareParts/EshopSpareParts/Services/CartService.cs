using EshopSpareParts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EshopSpareParts.Models.Hashers;

namespace EshopSpareParts.Services
{
    public class CartService
    {

        private ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public string GetUnhashedCart(string cipherText)
        {
            return EncryptionHelper.Decrypt(cipherText);
        }
        public string GetHashedCart(string text)
        {
            return EncryptionHelper.Encrypt(text);
        }
    }
}