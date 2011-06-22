using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;
using System.Data;


namespace serverFINT
{



    public class Sistema
    {
        private static Sistema instancia = null;
        private List<Usuario> colusuarios = new List<Usuario>();
        private List<Proveedor> colProveedor =new List<Proveedor>();
        private List<Gasto> colGasto = new List<Gasto>();

       


        private Sistema() { }


        public static Sistema getInstancia()
        {

            if (instancia==null)
            {
                instancia= new Sistema();
            }
            return instancia;
        }

        public List<Proveedor> ColProveedor
        {
            get { return colProveedor; }
            set { colProveedor = value; }
        }

        public List<Usuario> Colusuarios
        {
            get { return colusuarios; }
            set { colusuarios = value; }
        }
        public List<Gasto> ColGasto
        {
            get { return colGasto; }
            set { colGasto = value; }
        }


        //Crea un usuario y chequea si exite, Si no existe lo agrega a la coleccion de usuarios
        public int agregarUsuario(String nombre,String login, String passwd, rol tipo)
        {
            usuarioPersistente userPersistent = new usuarioPersistente();
            Usuario usuario = new Usuario(nombre, login, passwd, tipo);
            //if (!chequearUsuario(usuario,userPersistent))
            //{
                
                 return userPersistent.altaUsuario(nombre, login, passwd, (int) tipo);
                

           //}

           //// return false;
        }

        //Chequea si el login del usuario ya existe. Si exite devuelve true, sino false
        public Boolean chequearUsuario(String login, String pwd)
        {
            usuarioPersistente userPersistent = new usuarioPersistente();
            //foreach (Usuario tmpUsuario in Colusuarios)
            //{
            //    if (user.obtenerLogin()==tmpUsuario.obtenerLogin())
            //    {
            //        return true;
                    
            //    }
                
            //}
            //return false;
            DataSet ds = userPersistent.consultaUsuario(login, pwd);

            if (ds.Tables[0].Rows.Count>0)
            {
                return true;
            }
            return false;

        }

        public void agregarCuentaProveedor(String numero, String descripcion, DateTime vencimiento, Proveedor prov, Usuario user)
        {
            Cuenta cuentaProveedor = new cuentaProveedor(numero, descripcion, vencimiento, prov);
            user.agregarCuenta(cuentaProveedor);
            
        }

        public void agregarCuenta(String numero, Double saldo, String Descripcion, Usuario user)
        {
            Cuenta cuenta = new Cuenta(numero, saldo, Descripcion);
            user.agregarCuenta(cuenta);
            
        }


        public Proveedor obtenerProveedor(int id)
        {
            foreach (Proveedor prov in ColProveedor)
            {
                if (prov.CodProveedor==id)
                {
                    return prov;   
                }
            }
            return null;
        }


        //public Usuario obtenerUsuario(int id)
        //{
        //    foreach (Usuario user in Colusuarios)
        //    {
        //        if (user.Id==id)
        //        {
        //            return user;
        //        }
        //    }
        //    return null;
        //}


        public List<Cuenta> obtenerCuentasXusuario(int idUsuario)
        {
            foreach (Usuario user in Colusuarios)
            {
                if (user.Id==idUsuario)
                {
                    return user.ColCuentas;
                    
                }
            }
            return null;
        
        }





        public String realizarMovimiento(Cuenta pCuenta, Transaccion pTransaccion)
        {
            return pCuenta.realizarMovimiento(pTransaccion);
        
                
        }

        public Boolean realizarTransferencia(Cuenta pCuentaOrig, Cuenta pCuentaDestino, Transaccion pTransaccion)
        {

            return true;
        }

        public estadoCuenta verEstadoCuenta(DateTime fecha, Cuenta pCuenta)
        {
            return pCuenta.estadoCuentaProyectado(fecha);
        }
    }

}