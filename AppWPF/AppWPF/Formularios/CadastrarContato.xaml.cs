using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace AppWPF.Formularios
{
    /// <summary>
    /// Lógica interna para CadastrarContato.xaml
    /// </summary>
    public partial class CadastrarContato : Window
    {
        private MySqlConnection _conexao;
        public CadastrarContato()
        {
            InitializeComponent();

            Conexao();
        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" +
                "user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void FormCadastrarContato_Load(object sender, EventArgs e)
        {

        }


        private void btSalvar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {


                var nome = edNome.Text;
                var email = edEmail.Text;
                var sexo = edSexo.Text;
                var dataNasc = Convert.ToDateTime(dtDataNasc).ToString("yyyy/MM/dd");
                var telefone = edTelefone.Text;



                var sql = "INSERT INTO contato (con_nome, con_email, con_sexo,con_dataNasc, con_telefone) VALUES (@_nome, @_email,@_sexo,@_dataNasc,@_telefone)";
                var comando = new MySqlCommand(sql, _conexao);

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_sexo", sexo);
                comando.Parameters.AddWithValue("@_dataNasc", dataNasc);
                comando.Parameters.AddWithValue("@_telefone", telefone);





                comando.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso");

                _conexao.Close();




            }
            catch (Exception ex) { MessageBox.Show("Ocorreram erros ao salvar as informações! Contate a equipe de suporte do sistema (CAD 10)"); }
        }
    }
}
