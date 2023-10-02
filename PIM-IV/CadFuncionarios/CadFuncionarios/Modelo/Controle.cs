using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadFuncionarios.Modelo
{
    public class Controle
    {
        public string mensagem;

        public void CadastrarFuncionarios(List<String> ListaDadosFuncionarios, List<CheckBox> CHVariavel, List<CheckBox>OptanteFGTS, List<CheckBox>Beneficios)
        {
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaDadosFuncionarios, CHVariavel, OptanteFGTS, Beneficios);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                
                funcionario.situacao = ListaDadosFuncionarios[0];
                funcionario.nome = ListaDadosFuncionarios[1];
                funcionario.cargaHV = Convert.ToString(CHVariavel[0]);
                funcionario.numCartPonto = ListaDadosFuncionarios[2];
                funcionario.horaMes = ListaDadosFuncionarios[3];
                funcionario.horaSemana = ListaDadosFuncionarios[4];
                funcionario.horaDia = ListaDadosFuncionarios[5];
                funcionario.optante = Convert.ToString(OptanteFGTS[0]);
                funcionario.dtOpcao = Convert.ToDateTime(ListaDadosFuncionarios[6]);
                funcionario.conta = ListaDadosFuncionarios[7];

            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
