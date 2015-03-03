using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppAgendaUTBASP.NET.Datos;
using AppAgendaUTBASP.NET.Modelo;

namespace AppAgendaUTBASP.NET.Web
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonasRepositorios list = new PersonasRepositorios;

            string result="";

            foreach(Personas element in list.getPersonas())
                result += "\n" + element;

            Label1.Text = result.ToString().Replace("\n", "</br>");

        }
    }
}