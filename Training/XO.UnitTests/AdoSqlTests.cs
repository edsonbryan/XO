using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.DB.SQL;

namespace XO.UnitTests
{
    [TestFixture]
    public class AdoSqlTests
    {
        [Test]
        public void TestConnection()
        {
            var database = new Database();

            database.TestConnection();
        }

        [Test]
        public void PrintDataTest()
        {
            var database = new Database();

            database.PrintData();
        }

        [Test]
        public void GetListData()
        {
            var database = new Database();

            var productos = database.GetProductos();
            var tipos = database.GetTipos();
        }
    }
}
