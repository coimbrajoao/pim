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
    public partial class Editar : Form
    {
        private Platform ParaEditar;
        public Editar(Platform platform)
        {
            InitializeComponent();
            ParaEditar = platform;

            // Preencha os controles com os valores atuais do registro

            textBox3.Text = platform.PlatformName;

            textBox2.Text = platform.Id.ToString();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            var id = textBox2.Text;
            using (var context = new VideoGamesContext())
            {
                try
                {
                    if (int.TryParse(textBox2.Text.ToString(), out int gameid))
                    {

                        // Obtenha o objeto Game do banco de dados com base no ID
                        var plataformaexistente = context.Platforms.Find(gameid);


                        if (plataformaexistente != null)
                        {

                            // Extrai o ID do gênero do item selecionado no ComboBox
                            try
                            {

                                // Atualize o objeto Game com os valores dos controles
                                plataformaexistente.PlatformName = textBox3.Text;


                                // Realize a operação de atualização no banco de dados

                                context.SaveChanges();
                                MessageBox.Show("Atualização realizada com sucesso!!");
                                // Feche o formulário de edição
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não salvo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione um gênero válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um gênero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
