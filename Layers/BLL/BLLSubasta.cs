using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winShootForItAuctions.Interfaces;
using winShootForItAuctions.Layers.DAL;
using winShootForItAuctions.Layers.ENTITIES;

namespace winShootForItAuctions.Layers.BLL
{
    internal class BLLSubasta : IBLLSubasta
    {
        private IDALSubasta oDALSubasta = new DALSubasta();

        public void DeleteSubastaCliente(string pIdCliente, string pIdSubasta)
        {
            this.oDALSubasta.DeleteSubastaCliente(pIdCliente, pIdSubasta);
        }

        public List<Subasta> GetAllSubastas()
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = this.oDALSubasta.GetAllSubastas();
            return subastas;
        }

        public List<Subasta> GetAllSubastasActivas()
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = this.oDALSubasta.GetAllSubastasActivas();
            return subastas;
        }

        public async Task<List<Subasta>> GetAllSubastasAsync()
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = await this.oDALSubasta.GetAllSubastasAsync();
            return subastas;
        }

        public Subasta GetByIdSubasta(string pIdSubasta)
        {
            Subasta oSubasta = new Subasta();
            oSubasta = this.oDALSubasta.GetByIdSubasta(pIdSubasta);
            return oSubasta;    
        }

        public async Task<Subasta> GetByIdSubastaAsync(string pIdSubasta)
        {
            Subasta oSubasta = new Subasta();
            oSubasta = await this.oDALSubasta.GetByIdSubastaAsync(pIdSubasta);
            return oSubasta;
        }

        public List<Subasta> GetSubastaActivasByCliente(string pIdCliente)
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = this.oDALSubasta.GetSubastaActivasByCliente(pIdCliente);
            return subastas;
        }

        public async Task<List<Subasta>> GetSubastaActivasByClienteAsync(string pIdCliente)
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas =  await this.oDALSubasta.GetSubastaActivasByClienteAsync(pIdCliente);
            return subastas;
        }

        public Subasta GetSubastaByBien(int pIdBien)
        {
            Subasta oSubasta = new Subasta();
            oSubasta = this.oDALSubasta.GetSubastaByBien(pIdBien);
            return oSubasta;
        }

        public List<Subasta> GetSubastaByCliente(string pIdCliente)
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = this.oDALSubasta.GetSubastaByCliente(pIdCliente);
            return subastas;
        }

        public async Task<List<Subasta>> GetSubastaByClienteAsync(string pIdCliente)
        {
            List<Subasta> subastas = new List<Subasta>();
            subastas = await this.oDALSubasta.GetSubastaByClienteAsync(pIdCliente);
            return subastas;
        }

        public List<Subasta> GetSubastaByDuenno(string pIdDuenno)
        {
            List <Subasta> subastas= new List<Subasta>();
            subastas = this.oDALSubasta.GetSubastaByDuenno(pIdDuenno);
            return subastas;    
        }

        public async Task<List<Subasta>> GetSubastaByDuennoAsync(string pIdDuenno)
        {
            List <Subasta> subastas = new List <Subasta>();  
            subastas = await this.oDALSubasta.GetSubastaByDuennoAsync(pIdDuenno);
            return subastas;
        }

        public void Insert(Subasta pSubasta)
        {
            this.oDALSubasta.Insert(pSubasta);
        }

        public void InsertClienteSubasta(string pIdCliente, string pIdSubasta)
        {
            this.oDALSubasta.InsertClienteSubasta(pIdCliente, pIdSubasta);
        }

        public void Update(Subasta pSubasta)
        {
            this.oDALSubasta.Update(pSubasta);
        }
    }
}
