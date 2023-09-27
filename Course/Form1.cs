using System.Windows.Forms;

namespace Course
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro(); // Crie uma instância do Form2
            Cadastro.ShowDialog();
        }

        private void buscarPorJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscadejogos buscadejogos = new Buscadejogos();
            buscadejogos.ShowDialog();
        }

        private void novaPlataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastroplataforma cadastroplataforma = new Cadastroplataforma();
            cadastroplataforma.ShowDialog();
        }

        private void buscaDePlataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busca busca = new Busca();
            busca.ShowDialog();
        }
    }
}