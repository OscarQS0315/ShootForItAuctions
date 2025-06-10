using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace winShootForItAuctions.Layers.ENTITIES.DESIGN_PATTERNS
{
    internal static class UsuarioLogeado
    {
        private static Usuario oUsuario;
        public static Usuario GetInstance()
        {
            return oUsuario;
        }
        public static void LogearUsuario (Usuario pUsuario)
        {
            oUsuario = pUsuario;
        }
    }
}
