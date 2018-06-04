using BibliotecaN2;
using BibliotecaN2.DAO;
using BibliotecaN2.Enum;
using N2_AuQueMia.ClassesDAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace N2_AuQueMia.Forms
{
    public partial class FormCadAnimal : Form
    {
        AnimalDAO AniDAO = new AnimalDAO();
        AnimalVO auxiliar = new AnimalVO();
        bool insercao = false;
        public FormCadAnimal()
        {
            InitializeComponent();
        }
        #region metodos auxiliares
        private AnimalVO RetornaObjetoAnimal()
        {
            AnimalVO animal = new AnimalVO();
            animal.Id = Convert.ToInt16(txtId.Text);
            animal.IdResp = Convert.ToInt16((cbxResp.SelectedItem as ResponsavelVO).Id);
            animal.IdRaca = Convert.ToInt16((cbxRaca.SelectedItem as RacaVO).Id);
            animal.IdPorte = Convert.ToInt16((cbxPorte.SelectedItem as PorteVO).Id);
            animal.Nome = txtNome.Text;
            animal.Preferencia = txtPreferencia.Text;
            return animal;
        }
        private void AlteraParaModo(EnumModoOperacao modo)
        {
            cbxResp.Enabled =
            btnResp.Enabled =
            cbxEspecie.Enabled =
            cbxRaca.Enabled =
            cbxPorte.Enabled =
            txtNome.Enabled =
            txtPreferencia.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnMais.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAlterar.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnExcluir.Enabled = (modo == EnumModoOperacao.Navegacao);

            btnPrimeiro.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAnterior.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnProximo.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao);

            btnGravar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                LimpaCampos(this);
            }
            if (modo == EnumModoOperacao.Alteracao)
            {
                insercao = false;
            }
            if (modo == EnumModoOperacao.Navegacao)
            {
                insercao = false;
            }

            if (txtId.Text == string.Empty)
            {
                btnAlterar.Enabled =
                btnPrimeiro.Enabled =
                btnAnterior.Enabled =
                btnProximo.Enabled =
                btnUltimo.Enabled =
                btnExcluir.Enabled = false;
            }
        }
        private void TrataErro(Exception erro)
        {
            if (erro is FormatException)
            {
                Metodos.Mensagem("Campo numérico inválido!", TipoMensagemEnum.erro);
            }
            else if (erro is SqlException)
            {
                Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMensagemEnum.erro);
            }
            else if (erro is Exception)
            {
                Metodos.Mensagem(erro.Message, TipoMensagemEnum.erro);
            }
        }
        private void PreencheTela(PadraoVO t)
        {
            try
            {
                if (t != null)
                {
                    ResponsavelDAO respDAO = new ResponsavelDAO();
                    ResponsavelVO responsavel = respDAO.RetornaPorID((t as AnimalVO).IdResp) as ResponsavelVO;
                    cbxResp.SelectedIndex = responsavel.Id;
                    cbxEspecie.SelectedItem = (t as AnimalVO).IdEspecie;                    
                    cbxRaca.SelectedItem = (t as AnimalVO).IdRaca;                    
                    cbxPorte.SelectedItem = (t as AnimalVO).IdPorte;
                    txtId.Text = (t as AnimalVO).Id.ToString();
                    txtNome.Text = (t as AnimalVO).Nome;
                    txtPreferencia.Text = (t as AnimalVO).Preferencia;
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox ||
                objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }
        #endregion
        private void FormCadAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                List<EspecieVO> lista = new List<EspecieVO>(); //desnecessário, mas estava dando erro no datasource
                lista = EspecieDAO.RetornaEspecies();

                cbxResp.DisplayMember = "nome";
                cbxResp.ValueMember = "idResp";
                cbxResp.DataSource = ResponsavelDAO.RetornaResponsaveis();
                cbxResp.SelectedIndex = 0;
                cbxEspecie.DisplayMember = "descricao";
                cbxEspecie.ValueMember = "idEspecie";                
                cbxEspecie.DataSource = lista;
                cbxEspecie.SelectedIndex = 0;
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }
        #region Botões
        private void btnMais_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
            txtId.Text = AniDAO.RetornaProximoId().ToString();
            insercao = true;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Alteracao);
            insercao = false;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!Metodos.Mensagem("Confirma?", TipoMensagemEnum.pergunta))
                return;
            try
            {
                AnimalVO animal = RetornaObjetoAnimal();                
                AniDAO.Manipulacao(animal, "d");
                btnPrimeiro.PerformClick();
                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalVO t = RetornaObjetoAnimal();
                if (insercao)
                    AniDAO.Manipulacao(t, "i");
                else
                    AniDAO.Manipulacao(t, "u");

                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (insercao)                    
                    PreencheTela(AniDAO.RetornaPorID((AniDAO.Primeiro() as AnimalVO).Id));
                else
                    PreencheTela(AniDAO.RetornaPorID(Convert.ToInt32(txtId.Text)));
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }
        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {                
                PreencheTela(AniDAO.RetornaAnimaisPorId((AniDAO.Primeiro() as AnimalVO).Id));
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                auxiliar = AniDAO.Anterior(Convert.ToInt32(txtId.Text)) as AnimalVO;
                if (auxiliar != null)
                    PreencheTela(AniDAO.RetornaPorID(auxiliar.Id));

            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                auxiliar = AniDAO.Proximo(Convert.ToInt32(txtId.Text)) as AnimalVO;
                if (auxiliar != null)
                    PreencheTela(AniDAO.RetornaPorID(auxiliar.Id));
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {                
                PreencheTela(AniDAO.RetornaPorID((AniDAO.Ultimo()).Id));
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        #endregion
        #region Comboboxes
        private void cbxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RacaDAO raca = new RacaDAO();
                cbxRaca.DisplayMember = "descricao";
                cbxRaca.ValueMember = "Id";
                cbxRaca.DataSource = raca.RetornaDados((cbxEspecie.SelectedItem as EspecieVO).Id);
                cbxRaca.SelectedIndex = 0;
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void cbxRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PorteDAO porte = new PorteDAO();
                cbxPorte.DisplayMember = "Porte";
                cbxPorte.ValueMember = "Id";
                cbxPorte.DataSource = porte.RetornaDados((cbxRaca.SelectedItem as RacaVO).Id);
                cbxPorte.SelectedIndex = 0;
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        #endregion
    }
}
