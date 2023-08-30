using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    internal class Reporte1 {
        //articulo = art.sDesc, estatus = ocmst.sEstatus, prov = prov.sNombre, CanS = ocdet.sngCan_sol, idOC = ocmst.lId_ordc, fSol = ocmst.dtFecha, fEnt ocmst.dtFEnt

        private int idOC;
        private string articulo, estatus, prov, CanS, CanR;
        DateTime fSol, fEnt;

        public int IdOC { get => idOC; set => idOC = value; }
        public string Articulo { get => articulo; set => articulo = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string Prov { get => prov; set => prov = value; }
        public DateTime FSol { get => fSol; set => fSol = value; }
        public DateTime FEnt { get => fEnt; set => fEnt = value; }
        public string CanS1 { get => CanS; set => CanS = value; }
        public string CanR1 { get => CanR; set => CanR = value; }
    }
}