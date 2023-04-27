using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Todos os campos são de preenchimento obrigatorio
 * Ano de edição deverá ser numérico e positivo
*/

namespace ParaCasa1
{
    class PessoaBLL
    {
        public static void conecta()
        {
            PessoaDAL.conecta();
        }

        public static void desconecta()
        {
            PessoaDAL.desconecta();
        }
        


        public static void validaCodigo(Pessoa umapessoa, char op)
        {
            Erro.setErro(false);
            if (umapessoa.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (op == 'e')
                PessoaDAL.excluiUmLivro(umapessoa);
            else
                PessoaDAL.consultaUmLivro(umapessoa);
        }

        public static void validaDados(Pessoa umapessoa, char op)
        {
            Erro.setErro(false);
            if (umapessoa.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (umapessoa.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }
            if (umapessoa.getIdade().Equals(""))
            {
                Erro.setMsg("A idade é de preenchimento obrigatório!");
                return;
            }
            if (int.Parse(umapessoa.getIdade())<=0)
            {
                Erro.setMsg("A idade deve ser maior que 0 !");
                return;
            }
            if (umapessoa.getSexo().Equals(""))
            {
                Erro.setMsg("O sexo é de preenchimento obrigatório!");
                return;
            }


            try
            {
                int.Parse(umapessoa.getIdade());
            }
            catch (Exception)
            {
                Erro.setMsg("Idade deve ser numérico!");
                return;
            }

            

            if (int.Parse(umapessoa.getIdade()) <= 0)
            {
                Erro.setMsg("O valor do Ano deve ser numérico e positivo!");
                return;
            }
            if (op == 'i')
                PessoaDAL.inseriUmaPessoa(umapessoa);
            else
                PessoaDAL.atualizaUmLivro(umapessoa);

        }

    }
}

