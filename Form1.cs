using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CursoC_
{

    public partial class Form1 : Form
    {
        //Importar Redondeos
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,      //Coordenada x de la esquina superior izquierda
            int nTopRect,       //Coordenada y de la esquina superior izquierda
            int nRightRect,     //Coordenada x de la esquina inferior derecha
            int nBottomRect,    //Coordenada y de la esquina inferior derecha
            int nWidthEllipse,  //Ancho de la elipse
            int nHeightEllipse  //Altura de la elipse
        );
        //Mover La ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public Form1()
        {
            InitializeComponent();

            // Aplicar bordes redondeados a los botones
            ApplyRoundedCorners(Autologobtn, 20, 20); // Reemplaza Autologobtn con el nombre de tu botón
            ApplyRoundedCorners(Ticketbtn, 20, 20); // Reemplaza Ticketbtn con el nombre de tu botón
            ApplyRoundedCorners(Dllbtn, 20, 20); // Reemplaza Dllbtn con el nombre de tu botón
            ApplyRoundedCorners(Scriptbtn, 20, 20); // Reemplaza Scriptbtn con el nombre de tu botón
            ApplyRoundedCorners(label1, 20, 20); // Reemplaza Label1 con el nombre de tu boton
        }

        // Método para aplicar bordes redondeados a cualquier control (botón)
        private void ApplyRoundedCorners(Control control, int widthEllipse, int heightEllipse)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, control.Width, control.Height, widthEllipse, heightEllipse);
            control.Region = Region.FromHrgn(ptr);
        }

        private void Buttom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Autologobtn_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ticketbtn_Click(object sender, EventArgs e)
        {

        }

        private void Dllbtn_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Para mover la ventata
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Scriptbtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            Console.WriteLine("hola mundo");
            Console.ReadLine();
        }

    }
}
