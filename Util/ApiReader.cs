using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Xsl;
using winShootForItAuctions.Extensions;
using TextBox = System.Windows.Forms.TextBox;

namespace winShootForItAuctions.Util
{
    internal class ApiReader
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Retorna las lista de las provincias.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public static async Task LoadProvincia(ComboBox cbo)
        {
            string msg = "";
            try
            {
                string endPoint = "https://raw.githubusercontent.com/lateraluz/Datos/master/provincias.json";
                HttpResponseMessage response = await client.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Provincia>>(responseBody);
                cbo.Items.Clear();
                foreach (Provincia oProvincia in result)
                {
                    cbo.Items.Add(oProvincia);
                }
            }
            catch (HttpRequestException er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }
        /// <summary>
        /// Reotorna la lista de cantones segun la provincia.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="pIdProvincia"></param>
        /// <returns></returns>
        public static async Task LoadCantones(ComboBox cbo, int pIdProvincia)
        {
            string msg = "";
            try
            {
                string endPoint = "https://raw.githubusercontent.com/lateraluz/Datos/master/cantones.json";
                HttpResponseMessage response = await client.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Canton>>(responseBody);

                foreach (Canton oCanton in result)
                {
                    if (oCanton.IdProvincia == pIdProvincia)
                    {
                        cbo.Items.Add(oCanton);
                    }
                }


            }
            catch (HttpRequestException er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }
        /// <summary>
        /// Retorna los distritos segun el canton.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="pIdCanton"></param>
        /// <returns></returns>
        public static async Task LoadDistritos(ComboBox cbo, int pIdCanton)
        {
            string msg = "";
            try
            {
                string endPoint = "https://raw.githubusercontent.com/lateraluz/Datos/master/distritos.json";
                HttpResponseMessage response = await client.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Distrito>>(responseBody);

                foreach (Distrito oDistrito in result)
                {
                    if (oDistrito.IdCanton == pIdCanton)
                    {
                        cbo.Items.Add(oDistrito);
                    }
                }


            }
            catch (HttpRequestException er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }
        /// <summary>
        /// Carga y retorna segun la identificacion nacional.
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <param name="pTxtNombre"></param>
        /// <param name="pTxtApellido_1"></param>
        /// <param name="pTxtApellido_2"></param>
        /// <returns></returns>
        public static async Task LoadIdentificacionNacional(int pIdUsuario, TextBox pTxtNombre, TextBox pTxtApellido_1, TextBox pTxtApellido_2)
        {
            string msg = "";
            try
            {
                string endPoint = "https://api.hacienda.go.cr/fe/ae?identificacion=" + pIdUsuario.ToString();
                HttpResponseMessage response = await client.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<UsuarioApi>(responseBody);

                if (result != null)
                {
                    pTxtNombre.Text = result.GetNombre();
                    pTxtApellido_1.Text = result.GetPrimerApellido();
                    pTxtApellido_2.Text = result.GetSegundoApellido();

                    pTxtNombre.ForeColor = Color.White;
                    pTxtApellido_1.ForeColor = Color.White;
                    pTxtApellido_2.ForeColor = Color.White;
                }
            }
            catch (HttpRequestException er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show("La indentificación suministrada no pertenece a ninguna persona nacional.", "Identificación Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
        }


        /// <summary>
        /// Carga la lista de nacionalidades.
        /// </summary>
        /// <returns></returns>
        public static async Task LoadNacionalidades()
        {
            string msg = "";
            try
            {
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://restcountries.com/v3.1/all");
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; RV:23.0) Gecko/20100101 Firefox/23/0";

                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = await Task.Run(() => (HttpWebResponse)myWebRequest.GetResponse());
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                
                string datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
                dynamic data = JsonConvert.DeserializeObject(datos);
                var listaNacionalidades = new List<dynamic>();
                foreach (var oNacionalidad in data)
                {
                   listaNacionalidades.Add(oNacionalidad.name.common);
                }
                listaNacionalidades.Sort();
                Nacionalidad.Nacionalidades = listaNacionalidades;
            }
            catch (HttpRequestException er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return ;
            }
        }
        /// <summary>
        /// Retorna el tipo de cambio del dolar.
        /// </summary>
        /// <returns></returns>
        public static async Task<decimal> GetTipoCambio()
        {
            decimal monto = 0;
            string fecha = DateTime.Today.ToString("dd/MM/yyyy");
            string resultado = "";
            cr.fi.bccr.gee.cambiodolar.wsindicadoreseconomicos cliente = new cr.fi.bccr.gee.cambiodolar.wsindicadoreseconomicos();
            DataSet ds = await Task.Run(() => cliente.ObtenerIndicadoresEconomicos("317", fecha, fecha, "Oscar Quirós", "N", "shootforitauctions@gmail.com", "SN41I0OI3R"));
            resultado = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            monto = Convert.ToDecimal(resultado);

            return monto;
        }
    }
}
