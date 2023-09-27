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
    public partial class Cadastro : Form
    {
        private List<Genre> listaDeGeneros;
        private List<Platform> listaPlatform;
        private List<Region> listaRegion;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                        // Verifica se um item foi selecionado no ComboBox
                        if (comboBox1.SelectedItem != null)
                        {
                            // Obtém o texto do item selecionado
                            string selectedItemText = comboBox1.SelectedItem.ToString();

                            // Divide o texto em partes usando o caractere '-' como delimitador
                            string[] parts = selectedItemText.Split('-');

                            // Verifica se o texto foi dividido em duas partes (ID e nome)
                            if (parts.Length == 2)
                            {
                                // Extrai o ID do gênero e remove espaços em branco
                                int genreId = int.Parse(parts[0].Trim());
                                string genreName = parts[1].Trim();

                                // Crie o novo jogo com o GenreId correto
                                Game novoJogo = new Game
                                {
                                    GameName = textBox1.Text,
                                    GenreId = genreId, // Define o GenreId do novo jogo
                                };

                                // Adiciona o novo jogo ao contexto e salva as alterações no banco de dados
                                context.Games.Add(novoJogo);
                                context.SaveChanges();

                                // Exibe uma mensagem de sucesso
                                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
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



        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void Cadastro_Load(object sender, EventArgs e)
        {
            using (var context = new VideoGamesContext())
            {
                listaDeGeneros = context.Genres.ToList();

                foreach (Genre genre in listaDeGeneros)
                {
                    string itemText = $"{genre.Id} - {genre.GenreName}";
                    comboBox1.Items.Add(itemText);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

        }

        
    }
}
