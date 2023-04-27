using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Nosso objeto de transposição

namespace ParaCasa1
{
    class Pessoa
    {
        private String codigo;
        private String nome;
        private String idade;
        private String sexo;

        public void setCodigo(String _codigo) { codigo = _codigo; }
        public void setNome(String _nome) { nome = _nome; }
        public void setIdade(String _idade) { idade = _idade; }
        public void setSexo(String _sexo) { sexo = _sexo; }

        public String getCodigo() { return codigo; }
        public String getNome() { return nome; }
        public String getIdade() { return idade; }
        public String getSexo() { return sexo; }
    }
}
