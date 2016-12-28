using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hatali_altin_problemi
{
   public class BinaryS
   {
       int sayac = 0;
       Stopwatch stopwatch = new Stopwatch();
       int sure = 0;

       public int Search(int[] liste, int altinsayisi,int baslangic, int hatalialtin ,int say1ac)
       {
           
           stopwatch.Start();
           int bitis = altinsayisi-1;

           while(baslangic<=bitis)
           {
               int orta = (baslangic + bitis) / 2; 
               if(orta>hatalialtin)
               {
                   sayac++;
                   bitis = orta;
               }
               else if(orta<hatalialtin)
               {
                   sayac++;
                   baslangic =orta;
               }
               else
               {
                   
                   return orta;
               }
              
           }
           
           return 0;
           
       }
       
       public int sayacyolla()
       {
           return sayac;
       }
       public int sureyolla()
       {
           stopwatch.Stop();
           sure = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
           return sure;
       }

    }
}
