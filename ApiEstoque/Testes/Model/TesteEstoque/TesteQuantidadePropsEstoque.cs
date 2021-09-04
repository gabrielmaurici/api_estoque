using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Model.TesteEstoque
{
    public class TesteQuantidadePropsEstoque : BaseTesteProps<Estoque>
    {
        public TesteQuantidadePropsEstoque() : base("Quantidade", typeof(int), 1)
        {

        }
    }
}
