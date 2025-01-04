using database.Model;
using Database.Context;
using System.Data;

namespace DbTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            var db = new TokenManagementSystemContext();
            Console.WriteLine(DateTime.Now);

            UserInfo myUser = new UserInfo();
            myUser.Name = "rakin";
            myUser.Mobile = "013454675757";
            myUser.Email = "admin@admin.admin";
            myUser.PasswordHash = "Hash";
            myUser.RoleId = 1;

            db.UserInfo.Add(myUser);
            db.SaveChanges(); 



            for (int i = 1; i <= 10; i++)
            {
                db.UserInfo.Add(new UserInfo
                {
                    Name = "Manager-" + i,
                    Mobile =$"{i}",
                    Email = "manager" + i + "@manager.manager",
                    PasswordHash = "Hash" + i,
                    RoleId = 2
                });
            }
            
            db.SaveChanges();
            Console.WriteLine(DateTime.Now);
        }
    }

}