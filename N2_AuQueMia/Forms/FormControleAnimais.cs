using N2_AuQueMia.ClassesDAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_AuQueMia.Forms
{
    public partial class FormControleAnimais : Form
    {
        public FormControleAnimais()
        {
            InitializeComponent();
        }

        BindingList<AnimalVO> detalhes = new BindingList<AnimalVO>();

        private void ConfiguraColunasGridView()
        {

            #region criação dinâmica das colunas do DataGridView

            DataGridViewTextBoxColumn colIdAnimal = new DataGridViewTextBoxColumn();
            colIdAnimal.Name = "colIdAnimal";
            colIdAnimal.ReadOnly = true;
            colIdAnimal.Width = 30;
            colIdAnimal.DataPropertyName = "idAnimal";
            colIdAnimal.HeaderText = "ID";            
            dtGrdAnimais.Columns.Add(colIdAnimal);

            DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            colNome.Name = "colNome";
            colNome.ReadOnly = false;
            colNome.Width = 80;
            colNome.DataPropertyName = "nome"; // o nome do campo da classe AnimalVO
            colNome.HeaderText = "Nome";
            dtGrdAnimais.Columns.Add(colNome);

            DataGridViewComboBoxColumn colEspecie = new DataGridViewComboBoxColumn();
            colEspecie.Name = "colEspecie";
            colEspecie.ReadOnly = false;
            colEspecie.DataPropertyName = "idEspecie";
            colEspecie.DisplayMember = "Descricao";
            colEspecie.ValueMember = "id";
            colEspecie.DataSource = EspecieDAO.RetornaEspecies();
            colEspecie.HeaderText = "Espécie";
            
            //dtGrdAnimais.Columns.Add(colEspecie);            

            DataGridViewComboBoxColumn colIdRaca = new DataGridViewComboBoxColumn();
            colIdRaca.Name = "colIdRaca";
            colIdRaca.ReadOnly = false;            
            colIdRaca.DataPropertyName = "idRaca"; 
            colIdRaca.DisplayMember = "Raca";
            colIdRaca.ValueMember = "id";
            colIdRaca.DataSource = RacaDAO.RetornaRacas(colEspecie.Index-1);//verificar o index selecionado na coluna especie            
            colIdRaca.HeaderText = "Raça";            
            dtGrdAnimais.Columns.Add(colIdRaca);

            DataGridViewTextBoxColumn colIdPorte = new DataGridViewTextBoxColumn();
            colIdPorte.Name = "colIdPorte";
            colIdPorte.ReadOnly = false;
            colIdPorte.DataPropertyName = "idPorte";
            colIdPorte.HeaderText = "Porte";            
            dtGrdAnimais.Columns.Add(colIdPorte);
          
            DataGridViewTextBoxColumn colPreferencia = new DataGridViewTextBoxColumn();
            colPreferencia.Name = "colPreferencia";
            colPreferencia.ReadOnly = false;
            colPreferencia.MinimumWidth = 280;
            colPreferencia.DataPropertyName = "preferencia";
            colPreferencia.HeaderText = "Preferência";
            dtGrdAnimais.Columns.Add(colPreferencia);
            

            dtGrdAnimais.AllowUserToAddRows = true;
            dtGrdAnimais.AllowUserToDeleteRows = true;
            dtGrdAnimais.AllowUserToResizeRows = true;
            dtGrdAnimais.MultiSelect = false;
            dtGrdAnimais.AutoGenerateColumns = false;
            dtGrdAnimais.RowHeadersVisible = true;
            dtGrdAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrdAnimais.RowTemplate.Height = 44;

            dtGrdAnimais.DataSource = detalhes;

            #endregion
        }        
        private void FormControleAnimais_Load(object sender, EventArgs e)
        {            
            try
            {
                cbxResp.DisplayMember = "Nome";
                cbxResp.ValueMember = "Id";
                cbxResp.DataSource = ResponsavelDAO.RetornaResponsaveis();
                cbxResp.SelectedIndex = 0;                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            ConfiguraColunasGridView();
        }

        private void btnResp_Click(object sender, EventArgs e)
        {

        }

        private void cbxResp_SelectedIndexChanged(object sender, EventArgs e)
        {
            detalhes.Clear();
            List<AnimalVO> lista = AnimalDAO.RetornaAnimaisPorResp(Convert.ToInt32(cbxResp.SelectedValue));
            foreach(AnimalVO animal in lista)
                detalhes.Add(animal);
        }
    }
}
