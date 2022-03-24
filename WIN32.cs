using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Ebys2022
{
   public class WIN32

    {
        [DllImport("User32.Dll")]        
        public static extern long SetCursorPos(int x, int y); //Fareyi ilgili lokasyona çakmak işlevini yapar.

        [DllImport("User32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint); //Farenin lokasyonunu öğrenmek için kullanacağız.

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        [DllImport("User32.Dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);// DLL den çağırılacak olan fonksiyonu extern ile bildiriyoruz.
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;//Burada sol tuş basma kodunu hex türünden değişkene aktarıyoruz.
        public const int MOUSEEVENTF_LEFTUP = 0x0004;// Burada sol tuşu bırakmanın kodunu hex türünde değişkene aktarıyoruz.
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;


        public static void SolMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            //Sol Bıraktı
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        public static void SolMouseBasiliClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
        }
        public static void SolMouseBirakClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        public static void SagMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sağ Tıkladı
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            //Sağ Bıraktı
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
        }
        public static void SagMouseBasiliClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sağ Tıkladı
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
        }

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }
    }
}
