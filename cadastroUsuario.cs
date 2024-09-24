using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace login
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "" && txtconfirmarsenha.Text == "")
            {
                MessageBox.Show("Usuário ou Senha Vazios", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtconfirmarsenha.Text)
            {

                using (MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cliente;User=root;Password="))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = conexao.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO usuario (usuario,senha) VALUES (@usuario,@senha)";
                        cmd.Parameters.AddWithValue("@usuario", txtusername.Text);
                        cmd.Parameters.AddWithValue("@senha", txtpassword.Text);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        txtconfirmarsenha.Text = "";
                    }
                    MessageBox.Show("Sua conta foi criada com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("As senhas precisam ser iguais!", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtconfirmarsenha.Text = "";
                txtpassword.Focus();
            }
        }

        private void CBmostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmostrarsenha.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtconfirmarsenha.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtconfirmarsenha.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LIMPA A TELA
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconfirmarsenha.Text = "";
            txtusername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmarsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

