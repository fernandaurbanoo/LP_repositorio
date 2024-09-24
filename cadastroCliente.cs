using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void FormCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAddFoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cliente;User=root;Password="))
            {
                conexao.Open(); 
                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, estadocivil, datanascimento, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES (@nome, @documento, @genero, @rg, @estadocivil, @datanascimento, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@genero", "genero");
                    cmd.Parameters.AddWithValue("@rg", txtRg.Text);
                    cmd.Parameters.AddWithValue("@estadocivil", CbEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("@datanascimento", txtNasc.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", cbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", cbCidade.Text);
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObs.Text);
                    cmd.Parameters.AddWithValue("@situacao", cbSituacao);
                    
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro Realizado com sucesso!");
            }
            
        }
        private void SalvarCliente() 
        {
            using (MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cliente;User=root;Password="))
            {
                conexao.Open();
                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, estadocivil, datanascimento, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES (@nome, @documento, @genero, @rg, @estadocivil, @datanascimento, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@genero", "genero");
                    cmd.Parameters.AddWithValue("@rg", txtRg.Text);
                    cmd.Parameters.AddWithValue("@estadocivil", CbEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("@datanascimento", txtNasc.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", cbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", cbCidade.Text);
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObs.Text);
                    cmd.Parameters.AddWithValue("@situacao", cbSituacao);


                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cadastro Realizado com sucesso!");

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

