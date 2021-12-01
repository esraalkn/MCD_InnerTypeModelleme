﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil olarak kullanılan properties
        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciId { get; set; }
        #endregion

        #region Inner Type gerektiren alanlar
        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgisileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
            musteriIletisimBilgisileri = new MusteriIletisimBilgisi[3];
        }
        #endregion


    }
}
