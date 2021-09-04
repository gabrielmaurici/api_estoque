using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.Model
{
    public class TesteBase
    {
        [Fact]
        public void TesteInstanciaClasseBase()
        {
            //Arrange
            Action b;

            //Action
            b = () => Activator.CreateInstance<Base>();

            //Assert
            Assert.Throws<MissingMethodException>(b);
        }
    }
}
