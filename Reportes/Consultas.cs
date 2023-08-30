using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Reportes {
    class Consultas {
        private String CadenaCon = String.Format(Reportes.Properties.Settings.Default.ConBD);
        public List<object> LlenarDG(TextBox txtArt) {
            DateTime f = DateTime.Now;
            string fecha = "01/01/" + f.ToString("yyyy");
            SqlDataReader leer;
            List<Object> lista = new List<object>();
            string Query;
            Query = "Select ocmst.lId_ordc, art.sDesc, ocmst.sEstatus, prov.sNombre, ocmst.dtFecha, ocmst.dtFEnt, ocdet.sngCan_sol, ocdet.sngCan_rec from dbo.tblArticulosCompra art join dbo.tblOrd_comp_det ocdet on art.lId_artv = ocdet.lId_artv join dbo.tblOrd_comp_mst ocmst on ocmst.lId_ordc = ocdet.lId_ordc join dbo.tblProveedores prov on ocmst.lId_prov = prov.lId_prov where art.sDesc LIKE ('" + txtArt.Text + "%' ) AND ocmst.sEstatus = 'Autorizado' and dtFecha >= '" +fecha +"' order by sDesc";
            SqlConnection connStr = new SqlConnection(CadenaCon);
            try {
                connStr.Open();
                SqlCommand cmd = new SqlCommand(Query, connStr);
                leer = cmd.ExecuteReader();
                while (leer.Read()){
                    Reporte1 rep1 = new Reporte1();
                    rep1.IdOC = leer.GetInt32(0);
                    rep1.Articulo = leer[1].ToString();
                    rep1.Estatus = leer[2].ToString();
                    rep1.Prov = leer[3].ToString();
                    rep1.FSol = leer.GetDateTime(4);
                    rep1.FEnt = leer.GetDateTime(5);
                    rep1.CanS1 = leer[6].ToString();
                    rep1.CanR1 = leer[7].ToString();
                    lista.Add(rep1);
                }
                connStr.Close();
            } catch (SqlException e) {
                MessageBox.Show("Error: " + e);
                connStr.Close();
            }
            return lista;
        }
    }
}