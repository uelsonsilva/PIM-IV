using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadFuncionarios.Modelo
{
   
    public class Validacao
    { 
         public String mensagem;
    
        public void ValidarDadosFuncionario(List<String> ListaDadosFuncionarios, List<CheckBox> CHVariavel, List<CheckBox> OptanteFGTS, List<CheckBox> Beneficios)
        {
            //VALIDÃÇÃO CAMPO SITUAÇÃO
            this.mensagem = "";
            if (ListaDadosFuncionarios[0].Length == 0)
             this.mensagem += "Escolha uma opção no campo situação\n";  
            
            //VALIDAÇÃO CAMPO NOME
            if (ListaDadosFuncionarios[1].Length < 3)
                this.mensagem += "O nome deve ter mais que 3 caracteres\n";
            if (ListaDadosFuncionarios[1].Length > 50)
                this.mensagem += "O nome deve ter menos que 50 caracteres\n";
            
            //VALIDAÇÃO CHECKBOH GROUPBOX HORARIO
            if (CHVariavel[0].Checked == false && CHVariavel[1].Checked == false )
                this.mensagem += "Escolha sim ou não, para carga horária váriavel\n";
            else
                this.mensagem += "";

            // BLOQUEIO DE CHECKBOX, APENAS UM OPÇÃO PODE SER SELECIONADA
            if (CHVariavel[0].Checked)
                CHVariavel[1].Checked = false;
            if (CHVariavel[1].Checked)
                CHVariavel[0].Checked = false;

            ////VALIDAÇÃO CAMPO HORA
            if (ListaDadosFuncionarios[2].Length < 1) 
                this.mensagem += "O número do cartão de ponto deve ser maior que 1\n";
            if (ListaDadosFuncionarios[2].Length > 6)
                this.mensagem += "O número do cartão de ponto deve ser menor que 6\n";

            //VALIDAÇÃO CAMPO HORA
            if (ListaDadosFuncionarios[3].Length == 0)
                this.mensagem += "Preencha o campo hora mensal\n";
            if (ListaDadosFuncionarios[4].Length == 0)
                this.mensagem += "Preencha o campo hora semanal\n";
            if (ListaDadosFuncionarios[5].Length == 0)
                this.mensagem += "Preencha o campo hora diária\n";

            //VALIDAÇÃO OPTANTE FGTS 
            if (OptanteFGTS[0].Checked == false && OptanteFGTS[1].Checked == false)
                this.mensagem += "Escolha sim ou não para optante FGTS\n";
            else
                this.mensagem += "";

            // BLOQUEIO DE CHECKBOX, APENAS UM OPÇÃO PODE SER SELECIONADA
            if (OptanteFGTS[0].Checked)
                OptanteFGTS[1].Checked = false;
            if (OptanteFGTS[1].Checked)
                OptanteFGTS[0].Checked = false;


            /*VALIDAÇÃO CAMPO DATA
            if (ListaDadosFuncionarios[6])*/

            //VALIDAÇÃO CAMPO CONTA
            if (ListaDadosFuncionarios[7].Length < 1)
                this.mensagem += "A número da conta deve ser maior que 1\n";
            if (ListaDadosFuncionarios[7].Length > 10)
                this.mensagem += "A número da conta deve ser menor que 10\n";

            
            /*VALIDAÇÃO CHECKBOX BENEFICIOS
            if (Beneficios[0].Checked == false && Beneficios[1].Checked == false && Beneficios[2].Checked == false)
               this.mensagem = "Escolha algum benefício para o funcionário";*/
                

        }
    }
}

