namespace ComponentesVisuais01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvando o arquivo.");
        }
    }
}