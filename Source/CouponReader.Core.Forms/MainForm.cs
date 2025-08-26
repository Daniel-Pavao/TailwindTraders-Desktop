using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroClienteApp
{ 
    public partial class MainForm : Form
    {
        public MainForm
        {
            InitializeComponent();
        }

    private void btnSalvar_Click(object sander, EventArgs e)
    {
    SalvarDadosClientes(txtNome.Text,txtEndereco.Text,txtTelefone.Text);
