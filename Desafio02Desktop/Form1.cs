using Desafio02Desktop.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Desafio02Desktop
{
    public partial class Form1 : Form
    {
        private List<Produto> produtos = new List<Produto>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            produtos = await BuscarAsync();
            dataGridView1.DataSource = produtos;
        }

        private async Task<List<Produto>> BuscarAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://fakestoreapi.com/products";

                try
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var resultado = JsonSerializer.Deserialize<List<Produto>>(json);
                        return resultado ?? new List<Produto>();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar produtos da API.");
                        return new List<Produto>();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    return new List<Produto>();
                }
            }
        }

        private List<Produto> FiltroPreco(float valor1, float valor2)
        {
            decimal v1 = (decimal)valor1;
            decimal v2 = (decimal)valor2;

            var filtrado = produtos.Where(c => c.price >= v1 && c.price <= v2).ToList();
            return filtrado;
        }


        private List<Produto> FiltroCategoria(string filtro)
        {
            var filtrado = produtos.Where(c => c.category.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();
            return filtrado;
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var produto = (Produto)dataGridView1.CurrentRow.DataBoundItem;

                using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=db_Produto; Integrated Security=True;"))
                {
                    conn.Open();

                   
                    var checkCmd = new SqlCommand("SELECT COUNT(*) FROM ListarFavoritos WHERE IdProdutoApi = @Id", conn);
                    checkCmd.Parameters.AddWithValue("@Id", produto.id);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0) 
                    {
                        var cmd = new SqlCommand("INSERT INTO ListarFavoritos (IdProdutoApi, Title, Price, Category) VALUES (@Id, @Titulo, @Preco, @Categoria)", conn);
                        cmd.Parameters.AddWithValue("@Id", produto.id);
                        cmd.Parameters.AddWithValue("@Titulo", produto.title);
                        cmd.Parameters.AddWithValue("@Preco", produto.price);
                        cmd.Parameters.AddWithValue("@Categoria", produto.category);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto adicionado aos favoritos!");
                    }
                    else
                    {
                        MessageBox.Show("Este produto já está nos favoritos.");
                    }
                }
            }

        }

        private List<Produto> BuscarFavoritos()
        {
            var favoritos = new List<Produto>();

            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=db_Produto; Integrated Security=True;"))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT IdProdutoApi, Title, Price, Category FROM ListarFavoritos", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var produto = new Produto
                        {
                            id = Convert.ToInt32(reader["IdProdutoApi"]),
                            title = reader["Title"].ToString(),
                            price = Convert.ToDecimal(reader["Price"]),
                            category = reader["Category"].ToString()
                        };

                        favoritos.Add(produto);
                    }
                }
            }

            return favoritos;
        }


        private void btnFiltrarPreco_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoMin.Text, out decimal valorMin) &&
       decimal.TryParse(txtPrecoMax.Text, out decimal valorMax))
            {
                var resultado = FiltroPreco((float)valorMin, (float)valorMax); 
                dataGridView1.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para o preço mínimo e máximo.");
            }
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text.Trim();

            if (!string.IsNullOrEmpty(categoria))
            {
                var resultado = FiltroCategoria(categoria);
                dataGridView1.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Digite uma categoria válida.");
            }
        }

        private void btnBuscarFavorito_Click(object sender, EventArgs e)
        {
            var favoritos = BuscarFavoritos();
            dataGridView1.DataSource = favoritos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
