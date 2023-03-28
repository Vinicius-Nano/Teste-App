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

namespace ProjetoForm.Formularios
{
    public partial class FormCadastrarContato : Form
    {
        private MySqlConnection _conexao;

        public FormCadastrarContato()
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            try {
                if (edNome.Text == "" | edEmail.Text == "" | edSexo.Text == "" | dtDataNasc.Text == "" | edTelefone.Text == "")
                {
                    MessageBox.Show("Pelo menos um campo está vazio");
                    FormCadastrarContato form = this;
                    form.Close();
                
                }
                else {
                    var nome = edNome.Text;
                    var email = edEmail.Text;
                    var sexo = edSexo.Text;
                    dtDataNasc.Format = DateTimePickerFormat.Custom;
                    dtDataNasc.CustomFormat = "yyyy-MM-dd";
                    var dataNasc = dtDataNasc.Text;
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
                
            } catch (Exception ex) { MessageBox.Show("Ocorreram erros ao salvar as informações! Contate a equipe de suporte do sistema (CAD 10)"); }
            
        }


    }
}
