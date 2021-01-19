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

            client[] Costumers = { Müsteri1, Müsteri2 };
            Menü menü = new Menü();
            menü.Giris(Costumers);



        }
    }
}
