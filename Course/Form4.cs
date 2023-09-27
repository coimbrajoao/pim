using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class FormularioDeEdicao : Form
    {
        private Game gameParaEditar;
        private List<Genre> ListadeGeneros;
        public FormularioDeEdicao(Game game)
        {
            InitializeComponent();
            gameParaEditar = game;

            // Preencha os controles com os valores atuais do registro

            textBox1.Text = game.GameName;
            comboBox1.SelectedValue = game.GenreId;
            textBox2.Text = game.Id.ToString();
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
                        var jogoExistente = context.Games.Find(gameid);


                        if (jogoExistente != null)
                        {

                            // Extrai o ID do gênero do item selecionado no ComboBox
                            if (comboBox1.SelectedItem != null)
                            {
                                string selectedItemText = comboBox1.SelectedItem.ToString();
                                string[] parts = selectedItemText.Split('-');

                                if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int genreId))
                                {
                                    try
                                    {

                                        // Atualize o objeto Game com os valores dos controles
                                        jogoExistente.GameName = textBox1.Text;
                                        jogoExistente.GenreId = genreId;

                                        // Realize a operação de atualização no banco de dados

                                        context.SaveChanges();

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
                        else
                        {
                            MessageBox.Show("O jogo que você está tentando editar não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O jogo que você está tentando editar não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void FormularioDeEdicao_Load(object sender, EventArgs e)
        {
            using (var context = new VideoGamesContext())
            {
                ListadeGeneros = context.Genres.ToList();

                foreach (Genre genre in ListadeGeneros)
                {
                    string itemText = $"{genre.Id} - {genre.GenreName}";
                    comboBox1.Items.Add(itemText);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
        }
    }
}
