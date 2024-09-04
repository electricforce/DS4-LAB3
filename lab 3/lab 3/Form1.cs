namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBPalabra_TextChanged(object sender, EventArgs e)
        {
            // Obt�n el texto del TextBox
            string palabra = tBPalabra.Text;

            // Limpia el ListBox antes de agregar nuevos elementos
            listBoxVocales.Items.Clear();

            // Define un conjunto de vocales
            string vocales = "aeiouAEIOU";

            // Recorre cada car�cter de la palabra
            foreach (char c in palabra)
            {
                // Verifica si el car�cter es una vocal
                if (vocales.Contains(c))
                {
                    // Agrega la vocal al ListBox
                    listBoxVocales.Items.Add(c);
                }
            }
        }
    }
}
