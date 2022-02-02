using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ShoppingProgramStart();

        }

    }
}

