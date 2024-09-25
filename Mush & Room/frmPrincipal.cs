using Mush___Room.telaProducao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mush___Room
{
    public partial class frmPrincipal : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuProducao_Click(object sender, EventArgs e)
        {
            telaProducao.producao frm = new telaProducao.producao();
            frm.Show();
        }

        private void menuFornecedores_Click(object sender, EventArgs e)
        {
            telaFornecedores.fornecedores frm = new telaFornecedores.fornecedores();
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ListarFornecedores();
            ListarProducao();
        }

        private void ListarFornecedores() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBfornecedores ORDER BY id_forn asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridFornecedores.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGDforn();
        }

        private void FormatarGDforn() //metodo para formatar a gridFornecedores
        {
            gridFornecedores.Columns[0].HeaderText = "ID";
            gridFornecedores.Columns[1].HeaderText = "Nome do fornecedor";
            gridFornecedores.Columns[2].HeaderText = "Nome do produto";
            gridFornecedores.Columns[3].HeaderText = "CNPJ";
            gridFornecedores.Columns[4].HeaderText = "Telefone";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridFornecedores.Columns[0].Visible = false;

            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar


        }


        private void ListarProducao() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBproducao ORDER BY id_prod asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridProducao.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGDprod();
        }

        private void FormatarGDprod() //metodo para formatar a grid
        {
            gridProducao.Columns[0].HeaderText = "ID";
            gridProducao.Columns[1].HeaderText = "Nome da produção";
            gridProducao.Columns[2].HeaderText = "Informação da produção";
            gridProducao.Columns[3].HeaderText = "Início da produção";
            gridProducao.Columns[4].HeaderText = "Troca de substrato";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridProducao.Columns[0].Visible = false;

            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar


        }


    }
}
