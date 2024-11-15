using ExistingApp;
using ProxyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repo = new UserRepositoryProxy();

                Session.CanSave = false;
                Session.CanGetAll = false;

                User giova = new User("Giovanna", "estrellita123");

                repo.Save(giova);

                foreach(var item in repo.GetAll())
                {
                    Console.WriteLine($"Nombre de usuario: {item.Username}, Password: {item.Password}");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
