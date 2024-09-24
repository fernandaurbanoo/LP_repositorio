using System;
using System.Windows.Forms;
using Cadastro;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;


namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            

        }

        string connectionString = "datasource=127.0.0.1;Port=3306;database=cliente;user=root;password=;";
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuario WHERE usuario='" + txtusername.Text + "'AND senha='" + txtpassword.Text + "'";
            MySqlConnection databaseconnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseconnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseconnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        new FormCadCliente().Show();
                        this.Hide();
                        
                    }
                }
                else 
                {
                    MessageBox.Show("Usuário ou Senha Inválidos!", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                databaseconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            
           
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
          
               


        private void CBmostrarsenha_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CBmostrarsenha.Checked)
            {
                txtpassword.PasswordChar = '\0';
               
            }
            else
            {
                txtpassword.PasswordChar = '•';
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
