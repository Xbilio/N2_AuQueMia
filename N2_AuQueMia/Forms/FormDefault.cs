using BibliotecaN2;
using BibliotecaN2.DAO;
using BibliotecaN2.Enum;
using N2_AuQueMia.ClassesDAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace N2_AuQueMia.Forms
{
    public partial class FormCadResp : Form
    {
        ResponsavelDAO RespDAO = new ResponsavelDAO();
        bool insercao = false;
        public FormCadResp()
        {
            InitializeComponent();
        }
        private ResponsavelVO RetornaObjetoResp()
        {
            ResponsavelVO objeto = new ResponsavelVO();
            objeto.Id = Convert.ToInt16(txtId.Text);
            objeto.Nome = txtNome.Text;
            objeto.Rg = txtRg.Text;
            objeto.Telefone = txtTelefone.Text;
            objeto.Email = txtEmail.Text;
            objeto.Endereco = txtEndereco.Text;
            objeto.DataNasc = dtPickerDtNasc.SelectionStart;
            return objeto;
        }
        private void AlteraParaModo(EnumModoOperacao modo)
        {
            dtPickerDtNasc.Enabled =
            txtNome.Enabled =
            txtRg.Enabled =
            txtTelefone.Enabled =
            txtEmail.Enabled =
            txtEndereco.Enabled = (modo != EnumModoOperacao.Navegacao);            
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
        private void btnMais_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
            txtId.Text = RespDAO.RetornaProximoId().ToString();
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
                ResponsavelVO t = RetornaObjetoResp();                
                RespDAO.Manipulacao(t, "d");
                btnPrimeiro.PerformClick();
                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                    throw new Exception("Insira um nome!");
                ResponsavelVO t = RetornaObjetoResp();                              
                if (insercao)
                    RespDAO.Manipulacao(t, "i");
                else
                    RespDAO.Manipulacao(t, "u");

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
                    PreencheTela(RespDAO.Primeiro());
                else
                    PreencheTela(RespDAO.RetornaPorID(Convert.ToInt32(txtId.Text)));                
            }
            catch(Exception erro)
            {
                TrataErro(erro);
            }
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }
        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheTela(RespDAO.Primeiro());
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
                PadraoVO obj = RespDAO.Anterior(Convert.ToInt32(txtId.Text));
                if (obj != null)
                    PreencheTela(obj);
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
                PadraoVO obj = RespDAO.Proximo(Convert.ToInt32(txtId.Text));
                if (obj != null)
                    PreencheTela(obj);
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
                PreencheTela(RespDAO.Ultimo());
            }            
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        private void PreencheTela(PadraoVO t)
        {
            try
            {
                if (t != null)
                {
                    txtId.Text = (t as ResponsavelVO).Id.ToString();
                    txtNome.Text = (t as ResponsavelVO).Nome;
                    txtRg.Text = (t as ResponsavelVO).Rg;
                    txtTelefone.Text = (t as ResponsavelVO).Telefone;
                    txtEmail.Text = (t as ResponsavelVO).Email;
                    txtEndereco.Text = (t as ResponsavelVO).Endereco;
                    dtPickerDtNasc.SelectionStart = (t as ResponsavelVO).DataNasc;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            #region manipulando Dt picker 
            dtPickerDtNasc.MinDate = Convert.ToDateTime("01/01/1900");
            dtPickerDtNasc.MaxDate = Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + (DateTime.Now.Year - 10));
            dtPickerDtNasc.SelectionStart = Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + (DateTime.Now.Year - 20));
            dtPickerDtNasc.SelectionEnd = dtPickerDtNasc.SelectionStart;
            dtPickerDtNasc.TodayDate = dtPickerDtNasc.SelectionStart;
            #endregion
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }
    }
}
