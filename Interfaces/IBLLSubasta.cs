using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Interfaces
{
    internal interface IBLLSubasta
    {
        void Insert(Subasta pSubasta);
        Task<List<Subasta>> GetSubastaByDuennoAsync (string pIdDuenno);
        void InsertClienteSubasta(string pIdCliente, string pIdSubasta);
        Task<List<Subasta>> GetAllSubastasAsync();
        Task<List<Subasta>> GetSubastaByClienteAsync(string pIdCliente);
        Task<List<Subasta>> GetSubastaActivasByClienteAsync(string pIdCliente); 
        void Update(Subasta pSubasta);
        Task<Subasta> GetByIdSubastaAsync (string pIdSubasta);
        void DeleteSubastaCliente (string pIdCliente, string pIdSubasta);
        List<Subasta> GetAllSubastas();
        Subasta GetByIdSubasta(string pIdSubasta);
        List<Subasta> GetSubastaByCliente(string pIdCliente);
        List<Subasta> GetAllSubastasActivas();
        List<Subasta> GetSubastaByDuenno(string pIdDuenno);
        List<Subasta> GetSubastaActivasByCliente(string pIdCliente);
        Subasta GetSubastaByBien(int pIdBien);
    }
}
