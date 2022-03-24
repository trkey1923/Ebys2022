using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebys2022
{
    public class Metod
    {

        public void islemYap(int hız)
        {
            try
            {

                WIN32.SolMouseClick(88, 45);
                System.Threading.Thread.Sleep(hız);
                WIN32.SolMouseClick(94, 159);
                System.Threading.Thread.Sleep(hız);

            }
            catch (Exception)
            {

                
            }
            finally
            {
                
            }
        }
    }
}
