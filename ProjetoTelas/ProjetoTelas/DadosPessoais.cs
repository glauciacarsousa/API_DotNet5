using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTelas
{
    public partial class DadosPessoais : Form
    {
        public DadosPessoais()
        {
            InitializeComponent();

            
            txtCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtIdade.Enabled = true;
            txtNome.Enabled = true;
            txtSobren.Enabled = true;
            txtEnd.Enabled = true;
           // txt_pesquisa.Enabled = true;
            maskedTextBoxFONE.Enabled = true;
            comboBoxCidade.Enabled = true;
            btnPesquisar.Enabled = true;

        }

     

        //Vinculaçao com o Banco de Dados:

        MySqlConnection mysqlCon = null;
        private string  stringCon = "Server=localhost;Port=3306;Database=api_cliente;Uid=root;Pwd=110585;charset=utf8";
        private string  strgMysql = string.Empty;
        private object  mysqDdType;
       private object   txt_pesquisa;
        private object  VarcharType;
        private object  Varchar; 
      

        private string GetStrgMysql()
        {
            return strgMysql;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            strgMysql = "Insert into Clientes (Nome, Sobrenome, Cpf, Endereco, Email, Telefone, , Cidade, Idade) " +
            "values (@Nome, @Sobrenome, @Cpf, @Endereco, @Email, @Telefone, , @Cidade, @Idade)";


            mysqlCon = new MySqlConnection(stringCon);

            MySqlCommand comando = new MySqlCommand(strgMysql, mysqlCon);

            comando.Parameters.Add("@Nome", mysqDdType.Varchar.Value = txtNome;
            comando.Parameters.Add("@Sobrenome", mysqDdType.Varchar).Value = txtSobren;
            comando.Parameters.Add("@Cpf", mysqDdType.Varchar).Value = txtCpf;
            comando.Parameters.Add("@Endereco", mysqDdType.Varchar).Value = txtEnd;
            comando.Parameters.Add("@Email", mysqDdType.Varchar).Value = txtEmail;
            comando.Parameters.Add("@Telefone", mysqDdType.Varchar).Value = maskedTextBoxFONE;
            comando.Parameters.Add("@Cidade", mysqDdType.Varchar).Value = comboBoxCidade;
            comando.Parameters.Add("@Idade", mysqDdType.Varchar).Value = txtIdade;



            try
            {
                mysqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro registrado com sucesso!");
            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                mysqlCon.Close();
            }

           

            txtNome.Clear();
            txtSobren.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            txtIdade.Clear();
            maskedTextBoxFONE.Clear();
          



        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            strgMysql = "Select*from Cliente where Nome=@pesquisa";

            mysqlCon = new MySqlConnection(stringCon);

            MySqlCommand comando = new MySqlCommand(strgMysql, mysqlCon);

            comando.Parameters.Add("@pesquisa", mysqDdType.Varchar).Value = txt_pesquisa.Text; 
            
            
            try
            {
                if(txt_pesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome! ");
                }

                mysqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if(reader.HasRows == false)
                {
                    throw new Exception("Este dado não existe no cadastro! ");
                }

                reader.Read();  

                txtNome.Text = Convert.ToString(reader["Nome"]);
                txtSobren.Text = Convert.ToString(reader["Sobrenome"]);
                txtCpf.Text = Convert.ToString(reader["Cpf"]);
                txtEnd.Text = Convert.ToString(reader["Endereco"]);
                txtEmail.Text = Convert.ToString(reader["Email"]);
                maskedTextBoxFONE.Text = Convert.ToString(reader["Telefone"]);
                txtIdade.Text = Convert.ToString(reader["Idade"]);
                comboBoxCidade.Text = Convert.ToString(reader["Cidade"]);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

            finally
            {
                mysqlCon.Close();
            }

            txt_pesquisa.Clear();
               
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strgMysql = "update Clientes  set Nome=@Nome, Sobrenome=@Sobrenome, Cpf=@Cpf, Endereco=@Endereco, Email=@Email, Telefone=@Telefone, Idade=@Idade, Cidade=@Cidade";

            mysqlCon = new MySqlConnection(stringCon);

            MySqlCommand comando = new MySqlCommand(strgMysql, mysqlCon);


            comando.Parameters.Add("@Nome", mysqDdType.Varchar.Value = txtNome;
            comando.Parameters.Add("@Sobrenome", mysqDdType.Varchar).Value = txtSobren;
            comando.Parameters.Add("@Cpf", mysqDdType.Varchar).Value = txtCpf;
            comando.Parameters.Add("@Endereco", mysqDdType.Varchar).Value = txtEnd;
            comando.Parameters.Add("@Email", mysqDdType.Varchar).Value = txtEmail;
            comando.Parameters.Add("@Telefone", mysqDdType.Varchar).Value = maskedTextBoxFONE;
            comando.Parameters.Add("@Cidade", mysqDdType.Varchar).Value = comboBoxCidade;
            comando.Parameters.Add("@Idade", mysqDdType.Varchar).Value = txtIdade;


            try
            {
                mysqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                mysqlCon.Close();
            }


            txtNome.Clear();
            txtSobren.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            txtIdade.Clear();
            maskedTextBoxFONE.Clear();




        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            strgMysql = "delete from Cliente where Nome=@Nome";

            mysqlCon = new MySqlConnection(stringCon);

            MySqlCommand comando = new MySqlCommand(strgMysql, mysqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text; 
            
            
            
            try
            {
                mysqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão de cadastro realizada com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {
                mysqlCon.Close();
            }


            txtNome.Clear();
            txtSobren.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            txtIdade.Clear();
            maskedTextBoxFONE.Clear();


           

        }
    }
}
