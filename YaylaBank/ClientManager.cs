using System;
using System.Collections.Generic;
using System.Text;

namespace YaylaBank
{
    class ClientManager
    {
        
        public string Giris()
        {
            Console.WriteLine("(1)Müşteri Ekle\n(2)Müşteri Ara\n(3)Müşteri Listele\nSeçiminiz ==>");
            string secim = Console.ReadLine();
            Console.WriteLine("*********************************************");
            return secim;
            
        }
        public bool Back()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("(1)Geri Dön\nSeçiminiz");
            string secim = Console.ReadLine();
            Console.WriteLine("*********************************************");
            bool BackType = false;
            if (secim == "1")
            {
                BackType = true;
                return BackType;
            }
            else
            {
                return BackType;
            }

        }
        public Client AddInfo(List<Client> costumers)
        {
            Client client = new Client();
            Console.WriteLine("Ad ==>");
            client.Name = Console.ReadLine();
            Console.WriteLine("Soyisim ==>");
            client.Surname = Console.ReadLine();
            Console.WriteLine("Bakiye ==>");
            client.Bakiye = Convert.ToInt32(Console.ReadLine());
            client.Id = costumers.Count;
            Console.WriteLine("*********************************************");
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine("*********************************************");
            return client;
        }
        public void PersonAbout(Client client)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine(client.Id+ " ID'li Müşterimiz ==> "+client.Name+" "+client.Surname+"'nin Bakiyesi ==> "+client.Bakiye);
            Console.WriteLine("*********************************************");
        }
         
        


    }
}

        
