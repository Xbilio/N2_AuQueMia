using N2_AuQueMia.ClassesDAO;
using N2_AuQueMia.Forms;
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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }
        private void VerificaObjetos()
        {
            ResponsavelDAO responsavel = new ResponsavelDAO();
            if (responsavel.Quantidade() == 0)
                animaisToolStripMenuItem.Enabled = false;
            else
                animaisToolStripMenuItem.Enabled = true;

            AnimalDAO animal = new AnimalDAO();
            if (animal.Quantidade() == 0)
                atendimentosToolStripMenuItem.Enabled = false;
            else
                atendimentosToolStripMenuItem.Enabled = true;
        }
        private void FormIndex_Load(object sender, EventArgs e)
        {
            VerificaObjetos();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            VerificaObjetos();
        }

        private void responsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadResp formCadResp = new FormCadResp();
            formCadResp.ShowDialog();
            VerificaObjetos();
        }
        
        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadAnimal formAnimais = new FormCadAnimal();
            formAnimais.ShowDialog();
            VerificaObjetos();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoBanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaBanhosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
