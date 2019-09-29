using System;
using System.Runtime.InteropServices;


namespace PCSleep
{
    public class DragableWindow
    {

        // USAGE
        //  DragableWindow drag = new DragableWindow();
        //  drag.DragWindow(this.Handle);
        //

        // DLLs ------------------------------------------------------------

        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // ----------------------------------------------------------------


        public void DragWindow(IntPtr frm)
        {
            ReleaseCapture();
            SendMessage(frm, 0x112, 0xf012, 0);
        }
    }
}
