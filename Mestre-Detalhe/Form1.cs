using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mestre_Detalhe
{
    public partial class Form1 : Form
    {
        BindingList<CaixaDetalheVO> detalhes = new BindingList<CaixaDetalheVO>();

        private void ConfiguraColunasGridView()
        {
            #region criação dinâmica das colunas do DataGridView

            DataGridViewTextBoxColumn colDia = new DataGridViewTextBoxColumn();
            colDia.Name = "colDia";
            colDia.ReadOnly = false;                        
            colDia.DataPropertyName = "Dia"; 
            colDia.HeaderText = "Dia";
            dataGridView1.Columns.Add(colDia);


            DataGridViewTextBoxColumn colEvento = new DataGridViewTextBoxColumn();
            colEvento.Name = "colEvento";
            colEvento.ReadOnly = false;
            colEvento.MinimumWidth = 280;
            colEvento.DataPropertyName = "Evento"; // o nome do campo da classe CaixaDetalheVO            
            colEvento.HeaderText = "Evento";
            dataGridView1.Columns.Add(colEvento);

            DataGridViewTextBoxColumn colEntrada = new DataGridViewTextBoxColumn();
            colEntrada.Name = "colEntrada";
            colEntrada.ReadOnly = false; 
            colEntrada.DataPropertyName = "Entrada"; // o nome do campo da classe CaixaDetalheVO
            colEntrada.HeaderText = "Entrada - R$";
            colEntrada.DefaultCellStyle.Format = "c2";
            dataGridView1.Columns.Add(colEntrada);


            DataGridViewTextBoxColumn colSaida = new DataGridViewTextBoxColumn();
            colSaida.Name = "colSaida";
            colSaida.ReadOnly = false; 
            colSaida.DataPropertyName = "Saida"; // o nome do campo da classe CaixaDetalheVO
            colSaida.HeaderText = "Saída - R$";
            colSaida.DefaultCellStyle.Format = "F2";
            dataGridView1.Columns.Add(colSaida);


            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.DataSource = detalhes;

            #endregion
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfiguraColunasGridView();

            try
            {
                cbEmpresa.DisplayMember = "Nome";
                cbEmpresa.ValueMember = "Id";
                cbEmpresa.DataSource = EmpresaDAO.ConsultaEmpresas();
                cbEmpresa.SelectedIndex = 0;

                cbMes.SelectedIndex = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Estatisticas();
        }

        private void Estatisticas()
        {
            lblTotalEntradas.Text = detalhes.Sum(d => d.Entrada).ToString("0.00");
            lblTotalSaidas.Text = detalhes.Sum(d => d.Saida).ToString("0.00");
        }


        private void dataGridView1_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
            {
                //Validação para a coluna quantidade 
                if (e.ColumnIndex == dataGridView1.Columns["colEntrada"].Index ||
                    e.ColumnIndex == dataGridView1.Columns["colSaida"].Index)
                {
                    try
                    {
                        Convert.ToDouble(e.FormattedValue);
                        e.Cancel = false;
                    }
                    catch
                    {
                        e.Cancel = true;
                        MessageBox.Show("Valor inválido! Pressione ESC para cancelar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Validação para a coluna quantidade 
                    if (e.ColumnIndex == dataGridView1.Columns["colDia"].Index)
                    {
                        try
                        {
                            DateTime data = new DateTime((int)edAno.Value, cbMes.SelectedIndex + 1, Convert.ToInt32(e.FormattedValue));
                            (dataGridView1.Rows[e.RowIndex].DataBoundItem as CaixaDetalheVO).Data = data;
                            e.Cancel = false;
                        }
                        catch
                        {
                            e.Cancel = true;
                            MessageBox.Show("Valor inválido! Pressione ESC para cancelar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void btnGravaPedido_Click(object sender, EventArgs e)
        {            
            try
            {
                CaixaVO c = new CaixaVO();

                if (txtId.Text.Length > 0)
                    c.Id = Convert.ToInt32(txtId.Text);

                c.Mes = cbMes.SelectedIndex + 1;
                c.Ano = (int)edAno.Value;
                c.EmpresaId = Convert.ToInt32(cbEmpresa.SelectedValue);
                c.DetalhesCaixa = detalhes.ToList();

                txtId.Text =  CaixaDAO.Insere(c).ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Estatisticas();
        }
    }
}
