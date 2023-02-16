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

namespace locadoraCarro
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblveiculos;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            string marca;
            marca = txtmarca.Text;

            strconex = "data source=(local);initial catalog=locadora;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblveiculos = new DataTable();

            strsql = $"select * from veiculos where marca='{ marca }'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblveiculos);

            grade.DataSource = tblveiculos;
        }
    }
}
