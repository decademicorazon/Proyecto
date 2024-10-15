using CapaNegocios;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Negocios cn = new Negocios();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void butEntrar_Click(object sender, EventArgs e)
        {
            int tipo = cn.Validarusuario(txtUsuario.Text, txtClave.Text);

            switch (tipo)
            {
                case 1:


                    if (cn.ValidarUser(txtUsuario.Text, txtClave.Text) == 1)
                    {
                        string rutaCancion = @"C:\Users\Thomas\Downloads\videoplayback (1).m4a";
                        axWindowsMediaPlayer1.URL = rutaCancion;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        this.Controls.Clear();
                        Button btnActualizarProductos = new Button();
                        btnActualizarProductos.Text = "Actualizar Productos";
                        btnActualizarProductos.Location = new System.Drawing.Point(50, 50);
                        btnActualizarProductos.Size = new System.Drawing.Size(200, 50);
                        this.Controls.Add(btnActualizarProductos);

                        Button btnCompraProductos = new Button();
                        btnCompraProductos.Text = "Compra de Productos";
                        btnCompraProductos.Location = new System.Drawing.Point(50, 120);
                        btnCompraProductos.Size = new System.Drawing.Size(200, 50);
                        this.Controls.Add(btnCompraProductos);

                        Button btnVentaProductos = new Button();
                        btnVentaProductos.Text = "Venta de Productos";
                        btnVentaProductos.Location = new System.Drawing.Point(50, 200);
                        btnVentaProductos.Size = new System.Drawing.Size(200, 50);
                        this.Controls.Add(btnVentaProductos);

                        Button btnConsultaMovimientos = new Button();
                        btnConsultaMovimientos.Text = "Consulta de Movimientos";
                        btnConsultaMovimientos.Location = new System.Drawing.Point(50, 280);
                        btnConsultaMovimientos.Size = new System.Drawing.Size(200, 75);
                        this.Controls.Add(btnConsultaMovimientos);

                    }









                    break;


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
