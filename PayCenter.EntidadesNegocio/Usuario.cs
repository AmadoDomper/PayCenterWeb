using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PayCenter.EntidadesNegocio
{
    public class Usuario
    {
        private int _nUsuarioId;
        private string _cUsuario;
        private string _cContrasena;
        private string _cNombres;
        private string _cApellidoPa;
        private string _cApellidoMa;
        private string _cSexo;
        private string _cTipoUsuario;
        private string _cEmail;
        private int _nRolId;
        private string _cRolDesc;
        private int _nEstado;

        [JsonProperty(PropertyName = "nUsuId")]
        public int nUsuarioId
        {
            get { return _nUsuarioId; }
            set { _nUsuarioId = value; }
        }

        [JsonProperty(PropertyName = "cUsuario")]
        public string cUsuario
        {
            get { return _cUsuario; }
            set { _cUsuario = value; }
        }

        [JsonProperty(PropertyName = "cCnt")]
        public string cContrasena
        {
            get { return _cContrasena; }
            set { _cContrasena = value; }
        }

        [JsonProperty(PropertyName = "cNom")]
        public string cNombres
        {
            get { return _cNombres; }
            set { _cNombres = value; }
        }

        [JsonProperty(PropertyName = "cApePa")]
        public string cApellidoPa
        {
            get { return _cApellidoPa; }
            set { _cApellidoPa = value; }
        }

        [JsonProperty(PropertyName = "cApeMa")]
        public string cApellidoMa
        {
            get { return _cApellidoMa; }
            set { _cApellidoMa = value; }
        }

        [JsonProperty(PropertyName = "cSexo")]
        public string cSexo
        {
            get { return _cSexo; }
            set { _cSexo = value; }
        }

        [JsonProperty(PropertyName = "cTipUsu")]
        public string cTipoUsuario
        {
            get { return _cTipoUsuario; }
            set { _cTipoUsuario = value; }
        }

        [JsonProperty(PropertyName = "cEmail")]
        public string cEmail
        {
            get { return _cEmail; }
            set { _cEmail = value; }
        }

        [JsonProperty(PropertyName = "nRolId")]
        public int nRolId
        {
            get { return _nRolId; }
            set { _nRolId = value; }
        }

        [JsonProperty(PropertyName = "cRolDes")]
        public string cRolDesc
        {
            get { return _cRolDesc; }
            set { _cRolDesc = value; }
        }

        [JsonProperty(PropertyName = "nEstado")]
        public int nEstado
        {
            get { return _nEstado; }
            set { _nEstado = value; }
        }

    }
}
