using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTBASP.NET.Modelo
{
    public class Personas
    {
        #region "Attributes"
        private long id;
        private string nombres;
        private string apellidos;
        private string emailP;
        private string emailW;
        private string telefonoP;
        private string telefonoW;
        #endregion

        #region "Properties"

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }

        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }

        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }

        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }

        #endregion

        #region "Builders"

        public Personas()
        {
            this.id = 0;
            this.nombres = "Nombres ";
            this.apellidos = "Apellidos";
            this.emailP = "email_personal@email.com";
            this.emailW = "email_corporativi@email.com";
            this.telefonoP = "000000";
            this.telefonoW = "000000";

        }

        public Personas(long id, string nombres, string apellidos, string emailP, string emailW, string telefonoP, string telefonoW)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.emailP = emailP;
            this.emailW = emailW;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonoW;
        }

        #endregion

        #region "Methods"

        public override string ToString()
        {
            return "\n________________________________________________ \n" +
                "\n ID = " + id + "\n" +
                "\n Nombres = " + nombres + "\n" +
                "\n Apellidos = " + apellidos + "\n"+
                "\n Email Personal = " + emailP + "\n"+
                "\n Telefono Personal = " + telefonoP + "\n" +
                "\n Email Corporativo = " + emailW + "\n" +
                "\n Telefono Corporativo = " + telefonoW + "\n";
        }

        public override bool Equals(object obj)
        {
            Personas c = (Personas)obj;
            bool result = false;

            if ((this.id == c.id) && (this.nombres == c.nombres)
                && (this.apellidos == c.apellidos) && (this.emailP == c.emailP)
                && (this.emailW == c.emailW) && (this.telefonoP == c.telefonoP) && (this.telefonoW == telefonoW))
            {
                result = true;
            }

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion
    }
}