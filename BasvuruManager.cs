using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            crediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
