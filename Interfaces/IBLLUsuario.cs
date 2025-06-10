using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLUsuario
    {
        List<Usuario> GetAll();
        void Insert(Usuario pUsuario);
        Usuario GetById(string id);
        void Update(Usuario pUsuario);
        void DeleteById(string id);
        bool LogIn(string pIdUsuario, string pContrasenna);
    }
}
