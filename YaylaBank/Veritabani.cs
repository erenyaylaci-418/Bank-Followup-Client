using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace YaylaBank
{
    class Veritabani
    {
        
        public void WriteClient(int Id,string Name,string Surname,double Bakiye,client[] Costumers)
        {
            client Client = new client();

            Client.Id = Id;
            Client.Name = Name;
            Client.Surname = Surname;
            Client.Bakiye = Bakiye;

            Costumers[Id] = Client;

        }
        

    }
}
