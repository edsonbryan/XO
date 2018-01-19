using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XO.DB.SqlEf;

namespace XO.UI
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var contexto = new Contexto())
            {
                var productos = contexto.Productos.ToList();

                gvProductos.DataSource = productos;
                gvProductos.DataBind();
            }
        }
    }
}