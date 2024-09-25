﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mush___Room.telaProducao;
using System.Linq.Expressions;


namespace Mush___Room.telaFornecedores
{
    public partial class fornecedores : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public fornecedores()
        {
            InitializeComponent();
        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            Listar();
            DesabilitarCampos();
        }

        private void Listar() //metodo para listar registros do bd na grid
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

            FormatarGD();
        }

        private void FormatarGD() //metodo para formatar a grid
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

      

        private void btnCadForn_Click_1(object sender, EventArgs e)
        {

            
            ValidarCampos();
            //if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            //{
            //    MessageBox.Show("Preencha o campo 'Nome do Fornecedor'", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNomeFornecedor.Text = "";
            //    txtNomeFornecedor.Focus();
            //    return;
            //}

            //if (txtNomeProduto.Text.ToString().Trim() == "")
            //{
            //    MessageBox.Show("Preencha o campo 'Nome do Produto'", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNomeProduto.Text = "";
            //    txtNomeProduto.Focus();
            //    return;
            //}

            //if (mskCNPJ.Text == "   .   .   .  -  " || mskCNPJ.Text.Length < 14)
            //{
            //    MessageBox.Show("Preencha o campo 'CNPJ'", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskCNPJ.Text = "";
            //    mskCNPJ.Focus();
            //    return;
            //}

            //if (mskTelefone.Text == "(  )    -    " || mskTelefone.Text.Length < 14)
            //{
            //    MessageBox.Show("Preencha o campo 'Telefone'", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskTelefone.Text = "";
            //    mskTelefone.Focus();
            //    return;
            //}



            con.AbrirConexao();

            sql = "INSERT INTO TBfornecedores(nome_fornecedor, nome_produto, cnpj, telefone) VALUES(@nome_fornecedor, @nome_produto, @cnpj, @telefone)";
            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome_fornecedor", txtNomeFornecedor.Text);
            cmd.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text);
            cmd.Parameters.AddWithValue("@cnpj", mskCNPJ.Text);
            cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            LimparCampos();
        }


       
            private void btnAltForn_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
                {
                    MessageBox.Show("Preencha o campo 'Nome do Fornecedor'", "Alterar dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeFornecedor.Text = "";
                    txtNomeFornecedor.Focus();
                    return;
                }


                if (txtNomeProduto.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Nome do Produto'", "Alterar dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeProduto.Text = "";
                    txtNomeProduto.Focus();
                    return;
                }

                if (mskCNPJ.Text == "   .   .  -  " || mskCNPJ.Text.Length < 15)
                {
                    MessageBox.Show("Preencha o campo 'CNPJ'", "Alterar dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskCNPJ.Text = "";
                    mskCNPJ.Focus();
                    return;
                }

                if (mskTelefone.Text == "(  )    -    " || mskTelefone.Text.Length < 14)
                {
                    MessageBox.Show("Preencha o campo 'Telefone'", "Alterar dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTelefone.Text = "";
                    mskTelefone.Focus();
                    return;
                }



                con.AbrirConexao();

                sql = "UPDATE TBfornecedores SET nome_fornecedor = @nome_fornecedor, nome_produto = @nome_produto, cnpj = @cnpj, telefone = @telefone WHERE id_forn = @id_forn";
                
                cmd = new SqlCommand(sql, con.con);

                cmd.Parameters.AddWithValue("@id_forn", id); //WHERE
                cmd.Parameters.AddWithValue("@nome_fornecedor", txtNomeFornecedor.Text);
                cmd.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@cnpj", mskCNPJ.Text);
                cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);


                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();
                LimparCampos();

            MessageBox.Show("Registro alterado com sucesso!", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnExcForn_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "DELETE FROM TBfornecedores WHERE id_forn = @id_forn";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_forn", id);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Fornecedor deletado com sucesso!", "Excluir fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //    {
                
            //    id = gridFornecedores.SelectedRows[0].Cells[0].Value.ToString();

            //    txtNomeFornecedor.Text = gridFornecedores.SelectedRows[0].Cells[1].Value.ToString();
            //    txtNomeProduto.Text = gridFornecedores.SelectedRows[0].Cells[2].Value.ToString();
            //    mskCNPJ.Text = gridFornecedores.SelectedRows[0].Cells[3].Value.ToString();
            //    mskTelefone.Text = gridFornecedores.SelectedRows[0].Cells[4].Value.ToString();

            //}
        }

        private void gridFornecedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            habilitarCampos();
            btnCadForn.Enabled = false;

            try
            {
                if (gridFornecedores.SelectedRows.Count >= 0)
                {

                    id = gridFornecedores.SelectedRows[0].Cells[0].Value.ToString();

                    txtNomeFornecedor.Text = gridFornecedores.SelectedRows[0].Cells[1].Value.ToString();
                    txtNomeProduto.Text = gridFornecedores.SelectedRows[0].Cells[2].Value.ToString();
                    mskCNPJ.Text = gridFornecedores.SelectedRows[0].Cells[3].Value.ToString();
                    mskTelefone.Text = gridFornecedores.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Seleção inválida! Por favor, selecione a linha desejada com duplo clique.");  
            }

        }


        private void habilitarCampos()
        {
            btnCadForn.Enabled = true;
            btnExcForn.Enabled = true;
            btnAltForn.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomeFornecedor.Enabled = true;
            txtNomeProduto.Enabled = true;
            mskCNPJ.Enabled = true;
            mskTelefone.Enabled = true;
            
            
        }

        private void LimparCampos()
        {
            txtNomeFornecedor.Text = "";
            txtNomeProduto.Text = "";
            mskCNPJ.Text = "";
            mskTelefone.Text = "";
        }


        private void ValidarCampos()
        {
            if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome do Fornecedor'", "Dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
                return;
            }


            if (txtNomeProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Nome do Produto'", "Dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
                return;
            }

            if (mskCNPJ.Text == "   .   .  -  " || mskCNPJ.Text.Length < 15)
            {
                MessageBox.Show("Preencha o campo 'CNPJ'", "Dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCNPJ.Text = "";
                mskCNPJ.Focus();
                return;
            }

            if (mskTelefone.Text == "(  )    -    " || mskTelefone.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo 'Telefone'", "Dados do fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefone.Text = "";
                mskTelefone.Focus();
                return;
            }
        }

        private void DesabilitarCampos()
        {
            
            btnAltForn.Enabled = false;
            btnExcForn.Enabled = false;
            btnCancelar.Enabled = false;
            btnCadForn.Enabled = true;
            //txtNomeFornecedor.Enabled = false;
            //txtNomeProduto.Enabled = false;
            //mskCNPJ.Enabled = false;
            //mskTelefone.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomeFornecedor.Text = "";
            txtNomeProduto.Text = "";
            mskCNPJ.Text = "";
            mskTelefone.Text = "";

            DesabilitarCampos();
        }

        
    }

    
            
        }
   
