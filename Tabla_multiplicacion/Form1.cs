namespace Tabla_multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonver_Click(object sender, EventArgs e)
        {
            this.mostrarTabla();
        }
        private void mostrarTabla()
        {
            int n = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxresultados.AppendText(tabla);
        }
    }
}
