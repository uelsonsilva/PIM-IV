using CadFuncionarios.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadFuncionarios
{
    public partial class frmCadFuncionarios : Form
    {
        public frmCadFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {

            
            List<string> ListaDadosFuncionarios = new List<string>();
            List<CheckBox> CHVariavel = new List<CheckBox>();
            List<CheckBox> OptanteFGTS = new List<CheckBox>();
            List<CheckBox> Beneficios = new List<CheckBox>();

            ListaDadosFuncionarios.Add(cmbSituacao.Text);
            ListaDadosFuncionarios.Add(txbNome.Text);
            CHVariavel.Add(ckbHSim);
            CHVariavel.Add(ckbHNao);            
            ListaDadosFuncionarios.Add(txbNumCartPonto.Text);
            ListaDadosFuncionarios.Add(txbHoraMes.Text);
            ListaDadosFuncionarios.Add(txbHoraSemana.Text);
            ListaDadosFuncionarios.Add(txbHoraDia.Text);
            OptanteFGTS.Add(ckbOptSim);
            OptanteFGTS.Add(ckbOptNao);
            ListaDadosFuncionarios.Add(dtpDataOpcao.Text);
            ListaDadosFuncionarios.Add(txbConta.Text);
            Beneficios.Add(ckbConvenioMedico);
            Beneficios.Add(ckbValeTransporte);
            Beneficios.Add(ckbValeAlimentacao);

            Controle controle = new Controle();
            controle.CadastrarFuncionarios(ListaDadosFuncionarios, CHVariavel, OptanteFGTS, Beneficios);
            MessageBox.Show(controle.mensagem);

        }
    }
}