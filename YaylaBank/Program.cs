using System;
using System.Collections.Generic;

namespace YaylaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> Costumers = new List<Client>();
            ClientManager clientManager = new ClientManager();
            bool back = true;
            while (back == true)
            {
                

                string secim = clientManager.Giris();
                if (secim == "1")
                {
                    Client client = clientManager.AddInfo(Costumers);
                    Costumers.Add(client);
                    back = clientManager.Back();

                }
                if (secim == "2")
                {
                    Console.WriteLine("Aramak istediğiniz Müşterinin ID'si ==> ");
                    int SearchId = Convert.ToInt32(Console.ReadLine());
                    foreach (Client costumer in Costumers)
                    {
                        if (SearchId == costumer.Id)
                        {
                            clientManager.PersonAbout(costumer);
                        }
                    }
                    back = clientManager.Back();
                }
                if (secim == "3")
                {
                    foreach (Client costumer in Costumers)
                    { 
                        clientManager.PersonAbout(costumer);
                    }
                    back = clientManager.Back();

                }


            }
            
        }
    }
}
