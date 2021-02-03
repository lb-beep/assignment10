using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Exceptions;
using BakeryShoppingCart.Repositories.Implementation;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            UserRespository userRepo = new UserRespository();
            

            User newUser = new User();
            newUser.Email = "luis.email.com";
            newUser.UserId = 1;
            newUser.UserName = "Luis";

            User newUser2 = new User();
            newUser2.Email = "myra.email.com";
            newUser2.UserId = 2;
            newUser2.UserName = "Myra";

            User newUser3 = new User();
            newUser3.Email = "Luis.email.com";
            newUser3.UserId = 3;
            newUser3.UserName = "Luis";

            userRepo.Save(newUser);
            userRepo.Save(newUser2);
            userRepo.Save(newUser3);

            userRepo.GetAllUsersByName("2");

        }
    }
}
