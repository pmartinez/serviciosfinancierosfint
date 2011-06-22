﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace serverFINTWs
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class serverFINTFachada : System.Web.Services.WebService
    {

        [WebMethod]
        public int agregarUsuario(String nombre, String login, String passwd, serverFINT.rol tipo)
        {
            serverFINT.Sistema sistema = serverFINT.Sistema.getInstancia();
            return sistema.agregarUsuario(nombre, login, passwd, tipo);
            

        }

        [WebMethod]
        public Boolean chequearUsuario(String login, String passwd)
        {
            serverFINT.Sistema sistema = serverFINT.Sistema.getInstancia();
            return sistema.chequearUsuario(login, passwd);


        }

    }
}
