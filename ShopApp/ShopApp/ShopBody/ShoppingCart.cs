using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ShopApp
{
    internal class ShoppingCart
    {

        public List<Product> cartList = new List<Product>();

        public void ShoppingProgramStart()
        {
            var sweetsRepository = new SweetsRepository();
            var meatsRepository = new MeatsRepository();
            var veggiesRepository = new VeggiesRepository();
            var drinksRepository = new DrinksRepository();
            Console.WriteLine(" ---Program shop---");
            Console.WriteLine(" Enter amount of money you have: ");

            decimal Wallet = decimal.Parse(Console.ReadLine());
            while (true)
                if (Wallet > 0)
                {

                    Console.WriteLine($" Your balance is : {Wallet}Eur");
                    Console.WriteLine(" 1.View  menu \n 2.View Shopping Cart \n 3.Add to your shopping cart \n 4.Remove item from  your shopping cart \n 5.Checkout \n 6.Clear view \n 7.Send Receipt to Email \n 8.Exit");
                    var userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine(" 1.Sweets menu \n 2.Meats menu \n 3.Vegetables menu \n 4.Drinks menu");
                            var userChoice = Convert.ToInt32(Console.ReadLine());
                            switch (userChoice)
                            {
                                case 1:
                                    sweetsRepository.PrintSweetsList();
                                    break;
                                case 2:
                                    meatsRepository.PrintMeatsList();
                                    break;
                                case 3:
                                    veggiesRepository.PrintVeggiesList();
                                    break;
                                case 4:
                                    drinksRepository.PrintDrinksList();
                                    break;
                            }
                            break;
                        case 2:
                            PrintShoppingCart();
                            break;
                        case 3:
                            sweetsRepository.PrintSweetsList();
                            meatsRepository.PrintMeatsList();
                            veggiesRepository.PrintVeggiesList();
                            drinksRepository.PrintDrinksList();
                            Console.WriteLine(" Pick product : [1] [2] [3] etc . . .");
                            var usersChoice = int.Parse(Console.ReadLine());
                            switch (usersChoice)
                            {
                                case 1:
                                    cartList.Add(sweetsRepository.SweetsList[0]);
                                    break;
                                case 2:
                                    cartList.Add(sweetsRepository.SweetsList[1]);
                                    break;
                                case 3:
                                    cartList.Add(sweetsRepository.SweetsList[2]);
                                    break;
                                case 4:
                                    cartList.Add(meatsRepository.meatsList[0]);
                                    break;
                                case 5:
                                    cartList.Add(meatsRepository.meatsList[1]);
                                    break;
                                case 6:
                                    cartList.Add(meatsRepository.meatsList[2]);
                                    break;
                                case 7:
                                    cartList.Add(veggiesRepository.veggiesList[0]);
                                    break;
                                case 8:
                                    cartList.Add(veggiesRepository.veggiesList[1]);
                                    break;
                                case 9:
                                    cartList.Add(veggiesRepository.veggiesList[0]);
                                    break;
                                case 10:
                                    cartList.Add(drinksRepository.drinkList[0]);
                                    break;
                                case 11:
                                    cartList.Add(drinksRepository.drinkList[1]);
                                    break;
                                case 12:
                                    cartList.Add(drinksRepository.drinkList[2]);
                                    break;

                            }
                            break;
                        case 4:
                            PrintShoppingCart();
                            Console.WriteLine(" Pick product to remove : [1] [2] [3] etc . . .");
                            var userRemove = int.Parse(Console.ReadLine());
                            switch (userRemove)
                            {
                                case 1:
                                    cartList.RemoveAt(0);
                                    break;
                                case 2:
                                    cartList.RemoveAt(1);
                                    break;
                                case 3:
                                    cartList.RemoveAt(2);
                                    break;
                                case 4:
                                    cartList.RemoveAt(3);
                                    break;
                                case 5:
                                    cartList.RemoveAt(4);
                                    break;
                                case 6:
                                    cartList.RemoveAt(5);
                                    break;
                                case 7:
                                    cartList.RemoveAt(6);
                                    break;
                                case 8:
                                    cartList.RemoveAt(7);
                                    break;
                                case 9:
                                    cartList.RemoveAt(8);
                                    break;
                                case 10:
                                    cartList.RemoveAt(9);
                                    break;
                                case 11:
                                    cartList.RemoveAt(10);
                                    break;
                                case 12:
                                    cartList.RemoveAt(11);
                                    break;


                            }
                            break;


                        case 5:
                            if (Wallet >= GetCartPrice())
                            {
                                var timeNow = DateTime.Now;
                                PrintShoppingCart();
                                Console.WriteLine($" Total price : {GetCartPrice()}Eur");
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient funds.");
                            }
                            break;

                        case 6:
                            Console.Clear();
                            break;
                        case 7:
                            var timeNow2 = DateTime.Now;
                            async Task SendEmail()
                            {
                                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                                {
                                    UseDefaultCredentials = false,
                                    Credentials = new NetworkCredential("utakis.arturas@gmail.com", "**********"),
                                    EnableSsl = true,
                                    DeliveryMethod = SmtpDeliveryMethod.Network,
                                    Port = 587

                                });
                                Email.DefaultSender = sender;
                                var email = await Email
                                    .From("utakis.arturas@gmail.com")
                                    .To("utakis.arturas@gmail.com", "Arturas")
                                    .Subject("Receipt")
                                    .Body($" Thanks for buying ! \n Your purchase :  {StringShoppingCart()}  \n Total spendings :  {GetCartPrice()}Eur  \n {timeNow2}")
                                    .SendAsync();
                            }
                            SendEmail();

                            break;
                        case 8:
                            System.Environment.Exit(0);
                            break;
                    }

                }
                else
                {
                    Console.WriteLine($" 1.View  menu \n 2.Clear view \n 3.Exit ");
                    var userInput2 = int.Parse(Console.ReadLine());
                    switch (userInput2)
                    {
                        case 1:
                            Console.WriteLine(" 1.Sweets menu \n 2.Meats menu \n 3.Vegetables menu \n 4.Drinks menu");
                            var userChoice = Convert.ToInt32(Console.ReadLine());
                            switch (userChoice)
                            {
                                case 1:
                                    sweetsRepository.PrintSweetsList();
                                    break;
                                case 2:
                                    meatsRepository.PrintMeatsList();
                                    break;
                                case 3:
                                    veggiesRepository.PrintVeggiesList();
                                    break;
                                case 4:
                                    drinksRepository.PrintDrinksList();
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            break;
                        case 3:
                            System.Environment.Exit(0);
                            break;


                    }

                }


        }
        public decimal GetCartPrice()
        {
            decimal cartPrice = 0;
            foreach (var item in cartList)
            {
                cartPrice += item.Price;
            }
            return cartPrice;
        }

        public void PrintShoppingCart()
        {
            foreach (var item in cartList)
            {
                Console.WriteLine($" | {item.Barcode} | {item.Price}Eur |");
            }

        }

        public string StringShoppingCart()
        {
            var barcode = " ";
            var price = " ";
            var combined = " ";
            foreach (var item in cartList)
            {
                barcode = item.Barcode.ToString();
                price = item.Price.ToString();
                combined += $"\n {barcode} || {price}Eur";

            }
            return combined;
        }


    }
}
