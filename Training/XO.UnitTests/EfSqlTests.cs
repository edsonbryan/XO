using NUnit.Framework;
using System.Linq;
using XO.DB.SqlEf;

namespace XO.UnitTests
{
    [TestFixture]
    public class EfSqlTests
    {
        [Test]
        public void GetDataByEfTest()
        {
            using (var contexto = new Contexto())
            {
                var productos = contexto.Productos.ToList();
            }
        }

        [Test]
        public void GetAgendaDataTest()
        {
            using (var contexto = new ContextoAgenda())
            {
                var actividades = contexto.Actividades.ToList();
            }
        }
    }
}
