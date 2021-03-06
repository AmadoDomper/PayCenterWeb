﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayCenter.EntidadesNegocio;
using PayCenter.AccesoDatos;


namespace PayCenter.LogicaNegocio
{
    public class UsuarioLN
    {
        UsuarioAD oUsuarioAD;

        public UsuarioLN()
        {
            oUsuarioAD = new UsuarioAD();
        }

        public ListaPaginada ListarUsuariosPag(int nPage = 1, int nSize = 10, int nUsuId = -1, string cUsuDni = "", string cUsuName = "")
        {
            return oUsuarioAD.ListarUsuariosPag(nPage, nSize, nUsuId, cUsuDni, cUsuName);
        }

        //public Usuario CargarDatosUsuario(int nUsuId)
        //{
        //    return oUsuarioAD.CargarDatosUsuario(nUsuId);
        //}

        //public int RegistrarModificarUsuario(Usuario oUsuario)
        //{
        //    return oUsuarioAD.RegistrarModificarUsuario(oUsuario);
        //}
    }
}
