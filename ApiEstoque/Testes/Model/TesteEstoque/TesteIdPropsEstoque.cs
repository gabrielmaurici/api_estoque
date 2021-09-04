using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Model.TesteEstoque
{
    public class TesteIdPropsEstoque : BaseTesteProps<Estoque>
    {
        public TesteIdPropsEstoque() : base("Id", typeof(int), 1)
        {
        }
    }
}
