using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fernando
{
    public partial class Fernando : Form
    {
        public Fernando()
        {
            InitializeComponent();
        }

        private void Fernando_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = null;
            try
            {
                if (System.IO.File.Exists("C:\\teste\\teste\\acme.sqlite"))
                {
                    conn = new SQLiteConnection(Utils.StringConexao.conexao());
                    conn.Open();
                    conn.Close();
                }
                else {
                    DAO.VooDAO.criarBancoSQLite();
                    DAO.VooDAO.criarTabelaSQlite();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro interno");
            }
            loadEnable();
            exibirLista();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            btnIncluirEnable();
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            DAO.VooDAO vooDAO = null;
            try {

                vooDAO = new DAO.VooDAO();

                int id = int.Parse(txtId.Text);
                vooDAO.deletar(id);

                MessageBox.Show("Excluido com sucesso");
                exibirLista();
            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro interno");
            }
            txtId.Text = String.Empty;
            btnExcluirEnable();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja salvar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Entidade.Voo voo = null;
            DAO.VooDAO vooDAO = null;
            try
            {
                voo = new Entidade.Voo();
                voo.Data = Convert.ToDateTime(dtpData.Text);
                voo.Custo = txtCusto.Text.Equals(String.Empty) ? 0 : double.Parse(txtCusto.Text.Replace(",", "."));
                voo.Distancia = txtDistancia.Text.Equals(String.Empty) ? 0 : int.Parse(txtDistancia.Text);
                voo.Captura = radSim.Checked ? "S" : "N";
                voo.NivelDor = txtNivelDor.Text.Equals(String.Empty) ? 0 : int.Parse(txtNivelDor.Text);

                vooDAO = new DAO.VooDAO();
                string msg;

                if (txtId.Text.Equals(String.Empty))
                {
                    vooDAO.inserir(voo);
                    msg = "Inserido com sucesso";
                }
                else {
                    voo.Id = int.Parse(txtId.Text);
                    vooDAO.editar(voo);
                    msg = "Alterado com sucesso";
                }

                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro interno");
            }

            exibirLista();
            btnSalvarEnable();
            limpar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelarEnable();
            exibirLista();
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                
                if (txtCusto.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            alteraValorCampo();
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            alteraValorCampo();
        }

        private void txtNivelDor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            alteraValorCampo();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.Text = listView2.SelectedItems[0].SubItems[0].Text;
            DAO.VooDAO vooDAO = null;
            Entidade.Voo voo = null;
            try
            {
                vooDAO = new DAO.VooDAO();
                voo = vooDAO.vooPorId(int.Parse(txtId.Text));

                dtpData.Text = Convert.ToDateTime(voo.Data.ToString()).ToString();
                txtCusto.Text = voo.Custo.ToString().Replace(".", ",");
                txtDistancia.Text = voo.Distancia.ToString();
                radNao.Checked = voo.Captura == "N" ? true : false;
                radSim.Checked = voo.Captura == "S" ? true : false;
                txtNivelDor.Text = voo.NivelDor.ToString();
                btnClikListEnable();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro interno");
            }
            clikListView();
        }

        public void exibirLista()
        {
            DAO.VooDAO vooDAO = null;
            ListViewItem item = null;
            try
            {
                listView2.Items.Clear();
                vooDAO = new DAO.VooDAO();

                foreach (Entidade.Voo voo in vooDAO.listaVoo())
                {
                    item = new ListViewItem(voo.Id.ToString());
                    item.SubItems.Add(voo.Data.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(voo.Captura.ToString());
                    item.SubItems.Add(voo.NivelDor.ToString());
                    listView2.Items.Add(item);
                }
                limpar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro interno");
            }
        }

        public void limpar()
        {
            dtpData.Text = txtCusto.Text = txtDistancia.Text = txtNivelDor.Text = txtId.Text = String.Empty;

            radNao.Checked = radSim.Checked = false;

            btnExcluir.Enabled = false;
        }

        public void loadEnable()
        {
            btnIncluir.Enabled = true;

            btnSalvar.Enabled = btnExcluir.Enabled = btnCancelar.Enabled = false;

            dtpData.Enabled = txtCusto.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = false;

            radSim.Enabled = radNao.Enabled = false;
        }

        public void btnIncluirEnable()
        {
            btnSalvar.Enabled = btnIncluir.Enabled = btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = true;

            radSim.Enabled = radNao.Enabled = true;
        }

        public void btnExcluirEnable()
        {
            btnIncluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = true;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = radSim.Enabled = radNao.Enabled = false;
        }

        public void btnSalvarEnable()
        {
            btnSalvar.Enabled = btnCancelar.Enabled = false;
            btnIncluir.Enabled = btnExcluir.Enabled = true;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = false;

            radSim.Enabled = radNao.Enabled = true;
        }

        public void btnCancelarEnable()
        {
            btnSalvar.Enabled = btnCancelar.Enabled = false;
            btnIncluir.Enabled = btnExcluir.Enabled = true;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = false;

            radSim.Enabled = radNao.Enabled = false;
        }

        public void btnClikListEnable()
        {
            btnSalvar.Enabled = btnIncluir.Enabled = btnExcluir.Enabled = btnCancelar.Enabled = true;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = true;

            radSim.Enabled = radNao.Enabled = true;
        }

        public void clikListView()
        {
            btnIncluir.Enabled = btnExcluir.Enabled = true;
            btnSalvar.Enabled = btnCancelar.Enabled = false;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = true;

            radSim.Enabled = radNao.Enabled = true;
        }

        public void alteraValorCampo()
        {
            btnIncluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = true;

            dtpData.Enabled = txtCusto.Enabled = txtDistancia.Enabled = txtNivelDor.Enabled = true;

            radSim.Enabled = radNao.Enabled = true;
        }

        private void radNao_MouseClick(object sender, MouseEventArgs e)
        {
            alteraValorCampo();
        }

        private void radSim_MouseClick(object sender, MouseEventArgs e)
        {
            alteraValorCampo();
        }

        private void dtpData_Leave(object sender, EventArgs e)
        {
            alteraValorCampo();
        }
    }
}
