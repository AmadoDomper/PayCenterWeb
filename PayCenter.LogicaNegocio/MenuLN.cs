using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayCenter.EntidadesNegocio;
using PayCenter.AccesoDatos;

namespace PayCenter.LogicaNegocio
{
    public class MenuLN
    {
        MenuAD oMenuAD;

        public MenuLN()
        {
            oMenuAD = new MenuAD();
        }

        public List<Menu> ObtenerMenusFull(int nRolId)
        {
            try
            {
                return oMenuAD.ObtenerMenuFull(nRolId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }    }
}
