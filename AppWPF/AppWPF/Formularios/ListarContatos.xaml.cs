using AppWPF.RegraDeNegocios;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace AppWPF.Formularios
{
    /// <summary>
    /// Lógica interna para ListarContatos.xaml
    /// </summary>
    public partial class ListarContatos : Window
    {
        private MySqlConnection _conexao;
        public ListarContatos()
        {
            InitializeComponent();           
            Conexao();
            CarregarLista();
        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" +
                "user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        public void CarregarLista()
        {
            string sql = "Select * From contato";
            var comando = new MySqlCommand(sql, _conexao);
            var reader = comando.ExecuteReader();
            var Lista = new List<object>();
            while (reader.Read())
            {
                Contato contato = new Contato();
                contato.Id = reader.GetString(0);
                contato.Nome = reader.GetString(1);
                contato.Email = reader.GetString(2);
                contato.Sexo = reader.GetString(3);
                contato.DataNasc = reader.GetDateTime(4);
                contato.Telefone = reader.GetString(5);

                Lista.Add(contato);
            };

            dgContato.ItemsSource = Lista;


        }
    }
}

