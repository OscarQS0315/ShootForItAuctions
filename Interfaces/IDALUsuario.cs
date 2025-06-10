using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Enums;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IDALUsuario
    {
        void Insert(Usuario pUsuario);
        List<Usuario> GetAll();
        Usuario GetById(string pIdUsuario);
        void Update(Usuario pUsuario);
        void DeleteById (string id);
        void InsertAdmin(string pIdUsuario);
        void InsertDuenno(string pIdUsuario);
        void InsertCliente(string pIdUsuario);
        ETipoUsuario ClienteGetById(string pIdUsuario);
        ETipoUsuario AdminGetById(string pIdUsuario);
        ETipoUsuario DuennoGetById(string pIdUsuario);
        bool LogIn(string pIdUsuario, string pContrasenna);
        List<Usuario> GetAllUsuariosSubastas(string pIdSubasta);
    }
}
