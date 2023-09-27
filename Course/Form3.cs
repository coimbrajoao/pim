using Microsoft.EntityFrameworkCore;
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
    public partial class Buscadejogos : Form
    {
        private BindingList<Game> gameBindingList;
        private List<Game> ListadeJogos;
        public Buscadejogos()
        {
            InitializeComponent();
            var context = new VideoGamesContext();
            gameBindingList = new BindingList<Game>(context.Games.ToList());

            // Associe o DataGridView à BindingList
            dataGridView1.DataSource = gameBindingList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Buscadejogos_Load(object sender, EventArgs e)
        {
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            using (var context = new VideoGamesContext())
            {
                // Realize a consulta
                var query = from game in context.Games
                            join Genre in context.Genres on game.GenreId equals Genre.Id//inner por id
                            where game.GameName.Contains(filtro)  // Exemplo de filtro por nome do jogo
                            select new
                            {
                                game.GameName,
                                GenreName = Genre.GenreName,
                                game.Id // Busca o nome do gênero no banco
                            };
                // Atualize a DataGridView com os resultados da consulta
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    Game registroSelecionado = new Game
                    {
                        GameName = selectedRow.Cells["GameName"].Value.ToString(),


                    };
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int gameId))
                    {
                        registroSelecionado.Id = gameId;
                    }
                    else
                    {
                        // Lidar com o caso em que o valor da célula "Id" não é um número inteiro válido.
                        MessageBox.Show("O valor da célula 'Id' não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FormularioDeEdicao formularioEdicao = new FormularioDeEdicao(registroSelecionado);//instancia um novo formulario
                    formularioEdicao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione um registro para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não tem jogo selecionado");
            }

        }

        private void excluir_Click(object sender, EventArgs e)
        {
            using (var context = new VideoGamesContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Obtém o ID do jogo da célula "Id" da linha selecionada
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int gameId))
                    {
                        // Verifica se o jogo com o ID especificado existe no banco de dados
                        var jogoExistente = context.Games.Find(gameId);

                        if (jogoExistente != null)
                        {
                            
                            // Remove o jogo do contexto
                            context.Remove(jogoExistente);

                            // Realiza a operação de exclusão no banco de dados
                            context.SaveChanges();

                            // Atualiza a DataGridView para refletir a exclusão
                            

                            MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O jogo que você está tentando excluir não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O valor da célula 'Id' não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
