using System.Windows.Forms;

namespace OrdenamientoABB
{
    public partial class Form1 : Form
    {
        ABB arbol;
        public Form1()
        {
            InitializeComponent();        }

        private void btnIngresar_Click(object sender, EventArgs e)
        { agregar(false); }

        private void btnInvertidos_Click(object sender, EventArgs e)
        { agregar(true); }

        private void agregar(bool invertido)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) == true)
            { return; }

            arbol = new ABB();

            int[] datos = new int[int.Parse(txtCantidad.Text)];
            Random r = new Random();
            string cadena = "";
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = r.Next(-500, 500);
                cadena += ", " + datos[i]; 
            }
            txtSinOrdenar.Text = cadena;

            //invertido
            if (invertido)
            {
                double tiempoIniciali = double.Parse(DateTime.Now.Ticks.ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    arbol.Insertar(datos[i], invertido);
                }
                txtInorden.Text = arbol.Inorden();
                double tiempoFinali = double.Parse(DateTime.Now.Ticks.ToString());
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinali - tiempoIniciali) / 10000));
                return;
            }

            //no invertido
            double tiempoInicial = double.Parse(DateTime.Now.Ticks.ToString());
            for (int i = 0; i < datos.Length; i++)
            {
                arbol.Insertar(datos[i], invertido);
            }
            txtInorden.Text = arbol.Inorden();
            double tiempoFinal = double.Parse(DateTime.Now.Ticks.ToString());
            MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinal - tiempoInicial) / 10000));

            arbol = null;
        }
    }
}