using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.Domain
{
    public class Sesion
    {
            static Sesion _sesion;
            Usuario _usuario;

            public static Sesion GetInstance
            {
                get
                {
                    if (_sesion == null) _sesion = new Sesion();
                    return _sesion;
                }
            }

            public bool IsLoggedIn()
            {
                return _usuario != null;
            }

            // Método para obtener el objeto Usuario actual
            public Usuario GetUsuario()
            {
                return _usuario;
            }

            bool isInRole(Componente c, TipoPermiso permiso, bool existe)
            {
                if (c.Permiso.Equals(permiso))
                    existe = true;
                else
                {
                    foreach (var item in c.Hijos)
                    {
                        existe = isInRole(item, permiso, existe);
                        if (existe) return true;
                    }
                }

                return existe;
            }

            public bool IsInRole(TipoPermiso permiso)
            {
                if (_usuario == null || _usuario.Permisos == null)
                {
                    return false;
                }

                bool existe = false;
                foreach (var item in _usuario.Permisos)
                {
                    if (item.Permiso.Equals(permiso))
                        return true;
                    else
                    {
                        existe = isInRole(item, permiso, existe);
                        if (existe) return true;
                    }
                }

                return existe;
            }

            public void Logout()
            {
                _sesion._usuario = null;
            }

            public void Login(Usuario u)
            {
                _sesion._usuario = u;
            }

            private Sesion()
            {

            }
        }
    }
