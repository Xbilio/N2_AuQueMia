using BibliotecaN2;
using BibliotecaN2.DAO;
using BibliotecaN2.Enum;
using N2_AuQueMia.ClassesDAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using N2_AuQueMia.Forms;

namespace N2_AuQueMia.Forms
{
    public partial class FormCadResp : FormPrincipal
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
            txtRg.Enabled =
            txtTelefone.Enabled =
            txtEmail.Enabled =
            txtEndereco.Enabled = (modo != EnumModoOperacao.Navegacao);
        }

        private void PreencheTela(PadraoVO t)
        {
            try
            {
                if (t != null)
                {
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
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }
    }
}
