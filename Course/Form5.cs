using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course
{
    public partial class Cadastroplataforma : Form
    {
        public Cadastroplataforma()
        {
            InitializeComponent();
        }

        private void Cadastroplataforma_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new VideoGamesContext())
                {
                    try
                    {

                        Platform novoplataforma = new Platform
                        {
                            PlatformName = textBox1.Text,

                        };

                        // Adiciona o novo jogo ao contexto e salva as alterações no banco de dados
                        context.Platforms.Add(novoplataforma);
                        context.SaveChanges();

                        // Exibe uma mensagem de sucesso
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Exibe uma mensagem de erro se ocorrer uma exceção durante o cadastro
                        MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                // Exibe uma mensagem de erro se ocorrer uma exceção ao conectar ao banco de dados
                MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

