using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class EnderecoController
    {
        static List<Endereco> MeusEnderecos = new List<Endereco>();
        static int ultimoID = 0;

        public void SalvarEnderco(Endereco endereco)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            endereco.EnderecoID = id;
            MeusEnderecos.Add(endereco);
        }

        public Endereco PesquisarPorRua(string nome)
        {
            var c = from x in MeusEnderecos
                    where x.Rua.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public List<Endereco> ListarEnderecos()
        {
            return MeusEnderecos;
        }
    }
}

