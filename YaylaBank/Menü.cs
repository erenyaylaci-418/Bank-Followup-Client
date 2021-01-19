using System;
using System.Collections.Generic;
using System.Text;

namespace YaylaBank
{
    class Menü
    {
        public void Giris(client[] Costumers)
        {
            Console.WriteLine("1-Müşteri Listele\n2-Müşteri Ara\n3-Müşteri Ekleme\nSeçiminiz: ");
            
            string deger = Console.ReadLine();
            //int a =Convert.ToInt32(deger);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("************************************");
            Console.WriteLine("------------------------------------");
            Menü menü = new Menü();
            if (deger == "1")
            {
                menü.List(Costumers);

            }
            if (deger == "2")
            {
                menü.Search(Costumers);
            }
            if (deger == "3")
            {
                int a = 0;
                menü.ClientAdd(Costumers,a);
            }
           
            

        }

        public void List(client[] Costumers)
        {
            foreach (client Costumer  in Costumers)
            {
                Console.WriteLine(Costumer.Id+" ID'li "+Costumer.Name+" "+Costumer.Surname+" Kişisi'nin Bakiyesi: "+ Costumer.Bakiye);

            }

            Menü menü = new Menü();
            menü.Back(Costumers);



        }


        public void Search(client[] Costumers)
        {
            Console.WriteLine("Müşteri ID'si ==> ");
            int id = Int32.Parse(Console.ReadLine());

            client ClientSearch = Costumers[id];
            Console.WriteLine(ClientSearch.Id + " ID'li " + ClientSearch.Name + " " + ClientSearch.Surname + " Kişisi'nin Bakiyesi: " + ClientSearch.Bakiye);
            Menü menü = new Menü();
            menü.Back(Costumers);
                
            



        }
        public void ClientAdd(client[] Costumers,int ID)
        {

            client Costumer = new client();

            Console.WriteLine("Ad => ");
            Costumer.Name = Console.ReadLine();
            Console.WriteLine("Soyad => ");
            Costumer.Surname = Console.ReadLine();
            Console.WriteLine("Bakiye => ");
            Costumer.Bakiye = Int32.Parse(Console.ReadLine());
            
            Costumer.Id = ID;
            ID++;

            Console.WriteLine("**********************************");
            Console.WriteLine("1-Giriş Menüsüne Dön 2-Yeni Ekle\nSeçiminiz: ");
            string a = Console.ReadLine();
            Console.WriteLine("**********************************");
            Menü menü = new Menü();
            if (a == "1")
            {
                menü.Giris(Costumers);
            }
            if (a == "2")
            {
                
                menü.ClientAdd(Costumers, ID);
            }
            
        }

        public void Back(client[] Costumers)
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("1-Giriş Menüsüne Dön \nSeçiminiz: ");
            string a = Console.ReadLine();
            Console.WriteLine("///////////////////////////////////");
            Menü menü = new Menü();
            if (a == "1")
            {
                menü.Giris(Costumers);
            }
        }

    }
}

        
