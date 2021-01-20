using System;

namespace YaylaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            client Müsteri1 = new client();
            Müsteri1.Name = "Eren";
            Müsteri1.Surname = "Yaylacı";
            Müsteri1.Bakiye = 780;
            Müsteri1.Id = 0;

            client Müsteri2 = new client();
            Müsteri2.Name = "Taha";
            Müsteri2.Surname = "Yaylacı";
            Müsteri2.Bakiye = 950;
            Müsteri2.Id = 1;

            client Müsteri3 = new client();
            Müsteri3.Name = "Zeynep";
            Müsteri3.Surname = "Yaylacı";
            Müsteri3.Bakiye = 91550;
            Müsteri3.Id = 2;

            client[] Costumers = { Müsteri1, Müsteri2,Müsteri3 };
            Menü menü = new Menü();
            menü.Giris(Costumers);



        }
    }
}
