using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using XO.DB.SqlEf;
using XO.Entities;

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

        [Test]
        public void GetTodaysTasks()
        {
            using (var contexto = new ContextoAgenda())
            {
                var actividades = contexto.Actividades.Where(TasksForToday).ToList();

                var actividades2 = contexto.Actividades.Where(TasksForToday2).ToList();

                var actividades3 = contexto.Actividades.Where(TasksForToday3).ToList();
            }
        }

        public Func<Actividad, bool> TasksForToday = a => a.FechaInicio.Date.Equals(DateTime.Now.Date);

        public bool TasksForToday2(Actividad actividad)
            => actividad.FechaInicio.Date.Equals(DateTime.Now.Date);

        public bool TasksForToday3(Actividad actividad)
        {
            return actividad.FechaInicio.Date.Equals(DateTime.Now.Date);
        }
    }
}
