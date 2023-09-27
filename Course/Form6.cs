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
    public partial class Busca : Form
    {
        private BindingList<Platform> platformBindingList;
        public Busca()
        {
            InitializeComponent();
            var context = new VideoGamesContext();
            platformBindingList = new BindingList<Platform>(context.Platforms.ToList());

            // Associe o DataGridView à BindingList
            dataGridView1.DataSource = platformBindingList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Busca_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            using (var context = new VideoGamesContext())
            {
                // Realize a consulta
                var query = context.Platforms.Where(x => x.PlatformName == filtro).ToList();

                // Atualize a DataGridView com os resultados da consulta
                dataGridView1.DataSource = query;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    Platform registroSelecionado = new Platform
                    {
                        PlatformName = selectedRow.Cells["PlatformName"].Value.ToString(),


                    };
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int platformId))
                    {
                        registroSelecionado.Id = platformId;
                    }
                    else
                    {
                        // Lidar com o caso em que o valor da célula "Id" não é um número inteiro válido.
                        MessageBox.Show("O valor da célula 'Id' não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Editar edicao = new Editar(registroSelecionado);
                    edicao.ShowDialog();
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
                        var Existente= context.Platforms.Find(gameId);

                        if (Existente != null)
                        {

                            // Remove o jogo do contexto
                            context.Remove(Existente);

                            // Realiza a operação de exclusão no banco de dados
                            context.SaveChanges();

                            // Atualiza a DataGridView para refletir a exclusão


                            MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A plataforma que você está tentando excluir não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
