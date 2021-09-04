using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.Model
{
    public abstract class BaseTesteInstanciasEHerancas<T> where T : Base
    {
        [Fact]
        public void TesteInstanciaClasse()
        {
            //Arrange
            T model;

            //Action
            model = Activator.CreateInstance<T>();

            //Assert
            Assert.IsAssignableFrom<T>(model);
        }
        [Fact]
        public void TesteHerancaClasse()
        {
            //Arrange
            T model;

            //Action
            model = Activator.CreateInstance<T>();

            //Assert
            Assert.IsAssignableFrom<Base>(model);
        }
    }
}
