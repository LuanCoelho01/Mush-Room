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


namespace Mush___Room.telaProducao
{
    public partial class producao : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public producao()
        {
            InitializeComponent();
        }

                private void btn_cadProd(object sender, EventArgs e) //abrir a tela de cadastro de produção
                {
                    telaProducao.cad_producao frm = new telaProducao.cad_producao();
                    frm.Show();
                }
        


        private void producao_Load(object sender, EventArgs e)
            {
                Listar();
            
            }


        private void Listar() //metodo para listar registros do bd na grid
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

            FormatarGD();
        }

        public static DataGridViewRow selectedrow; //selecionar a linha da grid


        private void gridProducao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = gridProducao.CurrentRow.Cells[0].Value.ToString();

        }



        private void gridProducao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //para alterar os dados
        {

            if (e.RowIndex >= 0)
            {
                selectedrow = gridProducao.Rows[e.RowIndex]; // seleciona as informações da linha da grid 
                alt_producao.getalt_producao.ShowDialog(); // transfere as informações da linha selecionada para a tela de alterar produção
            }
        }

        

        private void btnAltProd_Click(object sender, EventArgs e)
        {
            telaProducao.alt_producao frm = new telaProducao.alt_producao();
            frm.ShowDialog();
        }

        private void btnExProd_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "DELETE FROM TBproducao WHERE id_prod = @id_prod";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_prod", id);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro deletado com sucesso!", "Excluir produção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void FormatarGD() //metodo para formatar a grid
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
