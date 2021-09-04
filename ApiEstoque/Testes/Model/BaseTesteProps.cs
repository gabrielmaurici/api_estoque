using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.Model
{
    public abstract class BaseTesteProps<T> where T : Base
    {
        public string PropNome { get; set; }
        public Type TipoProp { get; set; }
        public object ValorTeste { get; set; }
        public BaseTesteProps(string propNome, Type tipo, object valorTeste)
        {
            this.PropNome = propNome;
            this.TipoProp = tipo;
            this.ValorTeste = valorTeste;
        }
        [Fact]
        public void TestaSeClasseTemProp()
        {
            Type tipoClasse = typeof(T);

            PropertyInfo pI = tipoClasse.GetProperties().FirstOrDefault(t => t.Name == this.PropNome);

            Assert.NotNull(pI);
        }
        [Fact]
        public void TestaTipoPropDaClasse()
        {
            Type tipoClasse = typeof(T);

            PropertyInfo pI = tipoClasse.GetProperties().FirstOrDefault(t => t.Name == this.PropNome);
            Type tipoProp = pI != null ? pI.PropertyType : null;

            Assert.Equal(this.TipoProp, tipoProp);
        }
        [Fact]
        public void TestaGetSetPropDaClasse()
        {
            T classe = Activator.CreateInstance<T>();
            Type tipoClasse = typeof(T);
            object valorProp = null;

            PropertyInfo pI = tipoClasse.GetProperties().FirstOrDefault(t => t.Name == this.PropNome);
            if (this.ValorTeste != null){

                if (pI != null && pI.PropertyType == this.TipoProp && this.ValorTeste.GetType() == this.TipoProp )
                {
                    pI.SetValue(classe, this.ValorTeste);
                    valorProp = pI.GetValue(classe);
                }
            }

            Assert.NotNull(valorProp);
        }
    }
}
