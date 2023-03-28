using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjetoForm.RegrasDeNegocio;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoForm.Formularios
{
    public partial class FormListarContatos : Form
    {
        private MySqlConnection _conexao;

        public FormListarContatos()
        {
            InitializeComponent();
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
            Conexao();
            var sql = "Select * from contato";
            var comando = new MySqlCommand(sql, _conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);

            tabela.Columns["con_id"].ColumnName = "ID";
            

            dgvContato.DataSource = tabela;
        }


    }
}
