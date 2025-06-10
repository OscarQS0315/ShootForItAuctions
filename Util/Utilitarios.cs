using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net.Mail;
using log4net;
using System.Reflection;
using System.Windows.Forms;
using winShootForItAuctions.Extensions;
using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Threading.Tasks;
using winShootForItAuctions.Layers.ENTITIES;
using winShootForItAuctions.Properties;
using System.Net.Mime;
using System.IO;
using winShootForItAuctions.Enums;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;
using QuestPDF.Fluent;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec.Data;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using MessagingToolkit.QRCode.Codec.Reader;
using MessagingToolkit.QRCode.Codec;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace winShootForItAuctions.Util
{
    internal class Utilitarios
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Retorna la contraseña encriptada con formato MD5.
        /// </summary>
        /// <param name="pContrasenna"></param>
        /// <returns></returns>
        public static string EncriptarContrasenna(string pContrasenna)
        {
            string contraEncriptada = "";
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(pContrasenna);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                contraEncriptada = sb.ToString();
            }
            return contraEncriptada;
        }
        /// <summary>
        /// Valida el formato del correo.
        /// </summary>
        /// <param name="pCorreo"></param>
        /// <returns></returns>
        public static bool ValidarCorreo(string pCorreo)
        {
            try
            {
                MailAddress email = new MailAddress(pCorreo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Convierte una imagen a un array de Bytes.
        /// </summary>
        /// <param name="pImagen"></param>
        /// <returns></returns>
        public static byte[] ConvertirImagenAByte(System.Drawing.Image pImagen)
        {
            ImageConverter convertidor = new ImageConverter();
            byte[] arreglo = (byte[])convertidor.ConvertTo(pImagen, typeof(byte[]));
            return arreglo;
        }
        /// <summary>
        /// Envia un correo con la información dada.
        /// </summary>
        /// <param name="pCorreoDestino"></param>
        /// <param name="pMensaje"></param>
        public static async void EnviarCorreo(string pCorreoDestino, MensajeCorreo pMensaje)
        {
            string msg = "";
            try
            {
                MailAddress miCorreo = new MailAddress("shootforitauctions@gmail.com", "Shoot For It");
                MailAddress correoDestino = new MailAddress(pCorreoDestino);
                MailMessage message = new MailMessage(miCorreo, correoDestino);
                message.Subject = pMensaje.Asunto;
                message.Body = pMensaje.Cuerpo;
                message.IsBodyHtml = false;
                byte[] imagen = ConvertirImagenAByte(Resources.SHOOT_FOR_IT_AUCTIONS_HD);
                using (MemoryStream ms = new MemoryStream(imagen))
                {
                    Attachment oAttachImagen = new Attachment(ms, "SHOOT FOR IT AUCTIONS HD.png");

                    message.Attachments.Add(oAttachImagen);
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("shootforitauctions@gmail.com", "loow ajcy hmch mumq");

                    await Task.Run(() => client.Send(message));
                }

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }
        /// <summary>
        /// Envia el correo de la factura cancelada.
        /// </summary>
        /// <param name="pCorreoDestino"></param>
        /// <param name="pMensaje"></param>
        /// <param name="pPDF"></param>
        /// <param name="pXML"></param>
        public static async void EnviarCorreoFactura(string pCorreoDestino, MensajeCorreo pMensaje, Byte[] pPDF, Byte[]pXML)
        {
            string msg = "";
            try
            {
                MailAddress miCorreo = new MailAddress("shootforitauctions@gmail.com", "Shoot For It");
                MailAddress correoDestino = new MailAddress(pCorreoDestino);
                MailMessage message = new MailMessage(miCorreo, correoDestino);
                message.Subject = pMensaje.Asunto;
                message.Body = pMensaje.Cuerpo;
                message.IsBodyHtml = false;
                byte[] imagen = ConvertirImagenAByte(Resources.SHOOT_FOR_IT_AUCTIONS_HD);
                using (MemoryStream msImagen = new MemoryStream(imagen))
                {
                    Attachment oAttachImagen = new Attachment(msImagen, "SHOOT FOR IT AUCTIONS HD.png");

                    message.Attachments.Add(oAttachImagen);
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("shootforitauctions@gmail.com", "loow ajcy hmch mumq");
                    using (MemoryStream msPDF = new MemoryStream(pPDF))
                    {
                        Attachment oAttachPDF = new Attachment(msPDF, "Factura.pdf");
                        message.Attachments.Add(oAttachPDF);
                        using (MemoryStream msXML = new MemoryStream(pXML))
                        {
                            Attachment oAttachXML = new Attachment(msXML, "FacturaElectronica.xml");
                            message.Attachments.Add(oAttachXML);
                            await Task.Run(() => client.Send(message));
                        }
                    }

                    
                }

            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
            }
        }
        /// <summary>
        /// Hace y retorna el mensaje que será enviado en el correo de la facturación.
        /// </summary>
        /// <param name="pFactura"></param>
        /// <returns></returns>
        public static MensajeCorreo MensajeFacturacion(Factura pFactura)
        {
            MensajeCorreo oMensaje = new MensajeCorreo();
            oMensaje.Asunto = "Factura No: " + pFactura.IdFactura;
            oMensaje.Cuerpo = "Estimado(a): " + pFactura.Cliente.Apellido_1 + " " + pFactura.Cliente.Apellido_2 + " " + pFactura.Cliente.Nombre + " [" + pFactura.Cliente.IdUsuario + "]." + "\n" +
                              "Reciba un cordial saludo de parte de SHOOT FOR IT AUCTIONS" + "\n" +
                              "Adjuntamos su Factura: " + pFactura.IdFactura + " " + "correspondiente a la subasta: " + pFactura.Subasta.IdSubasta + "\n";

            return oMensaje;
        }
        /// <summary>
        /// Hace y retorna el mensaje de un nuevo inicio de sesión.
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns></returns>
        public static MensajeCorreo MensajeInicioSesion(Usuario pUsuario)
        {
            MensajeCorreo oMensaje = new MensajeCorreo();
            oMensaje.Asunto = "Nuevo Inicio de Sesión";
            oMensaje.Cuerpo = "Estimado(a): " + pUsuario.Apellido_1 + " " + pUsuario.Apellido_2 + " " + pUsuario.Nombre + " [" + pUsuario.IdUsuario + "]." + "\n" +
                              "Se ha registrado un nuevo inicio de sesión en nuestra app.";

            return oMensaje;
        }
        /// <summary>
        /// Hace y retorna el mensaje que se enviará por correo cuando se hace una puja.
        /// </summary>
        /// <param name="pSubasta"></param>
        /// <param name="pUsuarioPuja"></param>
        /// <param name="pUsuarioDestino"></param>
        /// <returns></returns>
        public static MensajeCorreo MensajeNuevaPuja(Subasta pSubasta, Usuario pUsuarioPuja, Usuario pUsuarioDestino)
        {
            MensajeCorreo oMensaje = new MensajeCorreo();
            oMensaje.Asunto = "Registro de Nueva Puja. Subasta: " + pSubasta.IdSubasta;
            oMensaje.Cuerpo = "Estimado(a): " + pUsuarioDestino.Apellido_1 + " " + pUsuarioDestino.Apellido_2 + " " + pUsuarioDestino.Nombre + " [" + pUsuarioDestino.IdUsuario + "]. " + "\n" +
                              "Se ha realizado una nueva puja en la subasta que está participando. " + "\n" +
                              "A nombre de: " + pUsuarioPuja.Apellido_1 + " " + pUsuarioPuja.Apellido_2 + " " + pUsuarioPuja.Nombre + " [" + pUsuarioPuja.IdUsuario + "]. " + "\n" +
                              "Con un monto de: $" + pSubasta.TotalOfertado.ToString("n2");
            return oMensaje;
        }
        /// <summary>
        /// Hace y retorna el mensaje que se enviará cuando la subasta finaliza.
        /// </summary>
        /// <param name="pSubasta"></param>
        /// <param name="pUsuarioDestino"></param>
        /// <returns></returns>
        public static MensajeCorreo MensajeSubastaFinalizada(Subasta pSubasta, Usuario pUsuarioDestino)
        {
            MensajeCorreo oMensaje = new MensajeCorreo();
            oMensaje.Asunto = "Subasta Finalizada [" + pSubasta.IdSubasta + "]";
            oMensaje.Cuerpo = "Estimado(a): " + pUsuarioDestino.Apellido_1 + " " + pUsuarioDestino.Apellido_2 + " " + pUsuarioDestino.Nombre + " [" + pUsuarioDestino.IdUsuario + "]. " + "\n" +
                              "La subasta [" + pSubasta.IdSubasta + "] ha finalizado." + "\n" +
                              "Ganador: " + pSubasta.Ganador.Apellido_1 + " " + pSubasta.Ganador.Apellido_2 + " " + pSubasta.Ganador.Nombre + "\n" +
                              "Con un monto de: $" + pSubasta.TotalOfertado.ToString("n2") + "\n\n";
            if (pUsuarioDestino.IdUsuario == pSubasta.Ganador.IdUsuario)
            {
                oMensaje.Cuerpo += "Felicidades. " + "\n" +
                                   "Recuerde proceder al apartado de facturación para retirar su producto.";
            }
            return oMensaje;
        }
        /// <summary>
        /// Convierte un xmlDocument a un tipo de dato sqlXML.
        /// </summary>
        /// <param name="pXML"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static SqlXml ConvertirXML(XmlDocument pXML)
        {
            if (pXML == null)
            {
                throw new ArgumentNullException(nameof(pXML), "El documento XML no puede ser nulo.");
            }
            using (var stringReader = new StringReader(pXML.OuterXml))
            {
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    return new SqlXml(xmlReader);
                }
            }
        }
        /// <summary>
        /// Crea y retorna el pdf que se enviará a la hora de la facturación.
        /// </summary>
        /// <param name="pFactura"></param>
        /// <param name="pCambio"></param>
        /// <returns></returns>
        public static Byte[] CrearReportePDF(Factura pFactura, decimal pCambio)
        {
            pFactura.CalcularTotal();
            decimal subTotal = 0;
            decimal impuestoTotal = 0;
            decimal montoComision = 0;
            byte[] pdf = null;

           
            System.Drawing.Image qrImage = QuickResponse.QuickResponseGenerador(pFactura.IdFactura.ToString(), 53);
            MemoryStream msQR = new MemoryStream();
            qrImage.Save(msQR, System.Drawing.Imaging.ImageFormat.Png);

            System.Drawing.Image logo = Resources.SHOOT_FOR_IT_AUCTIONS_HD;
            MemoryStream msLogo = new MemoryStream();
            logo.Save(msLogo, System.Drawing.Imaging.ImageFormat.Png);

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            pdf = Document.Create(document =>
            {
                document.Page(page =>
                {

                    page.Size(QuestPDF.Helpers.PageSizes.Letter);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.Margin(30);


                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Row(row1 =>
                        {
                            row1.ConstantItem(180).Image(msLogo.ToArray());
                        });
                        row.RelativeItem().Column(col =>
                        {
                            
                            col.Item().AlignRight().Text("Shot For It Auctions").Bold().FontSize(14).Bold();
                            col.Item().AlignRight().Text($"Fecha: {DateTime.Now} ").FontSize(9);
                            col.Item().AlignRight().Text($"Telefono: (506) 84762042").FontSize(9);
                            col.Item().AlignRight().Text($"Correo Electrónico: shootforitauctions@gmail.com").FontSize(9);
                            col.Item().AlignRight().Text($"Ubicación: 20107 - Alajuela, Alajuela, Sabanilla").FontSize(9);
                            col.Item().AlignRight().Text($"Otras Señas: 75 metros suroeste del Mini Super Doña Dora, San Luis Calle Víquez, tercera casa a mano derecha, portón rojo.").FontSize(9);

                            col.Item().AlignRight().Text($" ").FontSize(9);
                            
                            
                           
                        });
                    });
                    
                    page.Content().PaddingVertical(10).Column(col1 =>
                    {
                        
                        col1.Item().Background("#135cc1").AlignLeft().Text($"Factura").FontSize(14).Bold().FontColor("#ffffff");
                        col1.Item().AlignLeft().Text($"No {pFactura.IdFactura}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Tiquete Electrónico: {pFactura.IdFactura}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Tipo de Cambio Oficial: {pCambio.ToString("n5")}").FontSize(10);
                        col1.Item().AlignCenter().Text($" ").FontSize(9);

                        col1.Item().Background("#135cc1").AlignLeft().Text($"Cliente").FontSize(14).Bold().FontColor("#ffffff");
                        col1.Item().AlignLeft().Text($"Nombre: {pFactura.Cliente.Apellido_1.Trim()} {pFactura.Cliente.Apellido_2.Trim()} {pFactura.Cliente.Nombre.Trim()}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Identificación: {pFactura.Cliente.IdUsuario.Trim()}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Código Postal: {pFactura.Cliente.CodigoPostal.ToString()}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Correo Electrónico: {pFactura.Cliente.Correo}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Teléfono: (506) {pFactura.Cliente.Telefono}").FontSize(10);
                        col1.Item().AlignCenter().Text($" ").FontSize(9);

                        col1.Item().Background("#135cc1").AlignLeft().Text($"Información del pago").FontSize(14).Bold().FontColor("#ffffff");
                        col1.Item().AlignLeft().Text($"Modo de Pago: Contado").FontSize(10);
                        col1.Item().AlignLeft().Text($"Banco: {pFactura.Banco}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Método de Pago: {pFactura.MetodoPago}").FontSize(10);
                        col1.Item().AlignLeft().Text($"Fecha: {DateTime.Now} ").FontSize(10);
                        col1.Item().AlignCenter().Text($" ").FontSize(9);
                        


                        col1.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {

                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                            });


                            tabla.Header(header =>
                            {
                                header.Cell().Background("#135cc1")
                                .Padding(2).AlignLeft().Text("Código").FontColor("#fff");

                                header.Cell().Background("#135cc1")
                                .Padding(2).AlignLeft().Text("Descripción").FontColor("#fff");

                                header.Cell().Background("#135cc1")
                               .Padding(2).AlignLeft().Text("Cantidad").FontColor("#fff");

                                header.Cell().Background("#135cc1")
                               .Padding(2).AlignLeft().Text("Precio").FontColor("#fff");

                                header.Cell().Background("#135cc1")
                               .Padding(2).AlignLeft().Text("IVA").FontColor("#fff");

                                header.Cell().Background("#135cc1")
                               .Padding(2).AlignLeft().Text("Comisión").FontColor("#fff");
                            });


                            // Column 1 
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text(pFactura.Subasta.Bien.IdBien.ToString()).FontSize(10);

                            // Column 2
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text(pFactura.Subasta.Bien.Tipo.Nombre + "-" + pFactura.Subasta.Bien.Descripcion.ToString());

                            // Column 3                                        
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text("1.0").FontSize(10);

                            // Column 4                                        
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text("$" + pFactura.MontoDolares.ToString("##,###,###.00")).FontSize(10);

                            // Column 5                                        
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text(pFactura.IVA.ToString("##,###,###.00") + "%").FontSize(10);

                            // Column 6
                            tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                            .Padding(2).AlignLeft().Text(pFactura.Subasta.Comision.ToString("##,###,###.00") + "%").FontSize(10);

                            subTotal = pFactura.Subasta.TotalOfertado;
                            impuestoTotal = pFactura.CalcularImpuesto();
                            montoComision = pFactura.CalcularComision();

                        });
                        
                        col1.Item().AlignCenter().Text("ÚLTIMA LÍNEA").FontSize(10).Bold();
                       
                        col1.Item().AlignCenter().Text(" ").FontSize(10).Bold();
                        col1.Item().AlignCenter().Text(" ").FontSize(10).Bold();
                        col1.Item().AlignCenter().Text(" ").FontSize(10).Bold();
                        col1.Item().AlignCenter().Text(" ").FontSize(10).Bold();
                        
                        col1.Item().Row(row1 =>
                        {
                            row1.ConstantItem(90).Image(msQR.ToArray());
                        });

                    col1.Item().AlignRight().Table(tabla2 =>
                    {
                        
                        tabla2.ColumnsDefinition(columns =>
                        {

                            columns.RelativeColumn(5);
                            columns.RelativeColumn(5);
                            columns.RelativeColumn(5);
                            columns.RelativeColumn(5);
                            columns.RelativeColumn(5);
                            columns.RelativeColumn(5);
                        });
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("SubTotal").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("$" + subTotal.ToString("###,###.00")).FontSize(10).Bold();


                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("Impuesto").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("$"+ impuestoTotal.ToString("###,###.00")).FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("Comisión").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("$" + montoComision.ToString("###,###.00")).FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("Total Dólares").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("$" + pFactura.Total.ToString("###,###.00")).FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();
                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text(" ").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("Total Colones").FontSize(10).Bold();

                        tabla2.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                        .Padding(2).AlignRight().Text("₡" + (pCambio * pFactura.Total).ToString("###,###.00")).FontSize(10).Bold();

                    });

                    });
                    page.Footer()
                    .AlignRight()
                    .Text(txt =>
                    {
                        txt.Span("Página ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();
            return pdf;
        }
        /// <summary>
        /// Crea el XML de la factura.
        /// </summary>
        /// <param name="pFactura"></param>
        /// <param name="pMontoColones"></param>
        /// <returns></returns>
        public static XmlDocument CrearXML(Factura pFactura, decimal pMontoColones)
        {
            string msg = "";
            try
            {
                pFactura.CalcularTotal();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml("<FacturaEletronica />");

                var nNoFactura = xmlDocument.CreateElement("FacturaNo");
                nNoFactura.InnerText = pFactura.IdFactura.ToString();
                xmlDocument.DocumentElement.AppendChild(nNoFactura);

                //Remitente
                var nRemitente = xmlDocument.CreateElement("Remitente");
                nNoFactura.AppendChild(nRemitente);

                var nNombreRemitente = xmlDocument.CreateElement("Nombre");
                nNombreRemitente.InnerText = "SHOOT FOR IT AUCTIONS SA";
                nRemitente.AppendChild(nNombreRemitente);

                var nUbicacion = xmlDocument.CreateElement("Ubicación");
                nRemitente.AppendChild(nUbicacion);

                var nProvincia = xmlDocument.CreateElement("Provincia");
                nProvincia.InnerText = "ALAJUELA";
                nUbicacion.AppendChild(nProvincia);

                var nCanton = xmlDocument.CreateElement("Canton");
                nCanton.InnerText = "ALAJUELA";
                nUbicacion.AppendChild(nCanton);

                var nDistrito = xmlDocument.CreateElement("Distrito");
                nDistrito.InnerText = "SABANILLA";
                nUbicacion.AppendChild(nDistrito);

                var nDireccion = xmlDocument.CreateElement("Direccion");
                nDireccion.InnerText = "San Luis, Calle Viquez";
                nUbicacion.AppendChild(nDireccion);

                var nContacto = xmlDocument.CreateElement("Contacto");
                nRemitente.AppendChild(nContacto);

                var nCorreo = xmlDocument.CreateElement("CorreoElectronico");
                nCorreo.InnerText = "shootforitauctions@gmail.com";
                nContacto.AppendChild(nCorreo);

                var nTelefono = xmlDocument.CreateElement("Telefono");
                nTelefono.InnerText = "84762042";
                nContacto.AppendChild(nTelefono);
                //-----

                //Destinatario
                var nDestinatario = xmlDocument.CreateElement("Destinatario");
                nNoFactura.AppendChild(nDestinatario);

                var nIdentificacionDestinatario = xmlDocument.CreateElement("Identificacion");
                nIdentificacionDestinatario.InnerText = pFactura.Cliente.IdUsuario.ToString();
                nDestinatario.AppendChild(nIdentificacionDestinatario);

                var nNombreDestinatario = xmlDocument.CreateElement("Nombre");
                nNombreDestinatario.InnerText = pFactura.Cliente.ToString();
                nDestinatario.AppendChild(nNombreDestinatario);

                var nContactoDestinatario = xmlDocument.CreateElement("Contacto");
                nDestinatario.AppendChild(nContactoDestinatario);

                var nCorreoDestinatario = xmlDocument.CreateElement("CorreoElectronico");
                nCorreoDestinatario.InnerText = pFactura.Cliente.Correo.ToString();
                nContactoDestinatario.AppendChild(nCorreoDestinatario);

                var nTelefonoDestinatario = xmlDocument.CreateElement("Telefono");
                nTelefonoDestinatario.InnerText = pFactura.Cliente.Telefono.ToString();
                nContactoDestinatario.AppendChild(nTelefonoDestinatario);

                var nCodigoPostal = xmlDocument.CreateElement("CodigoPostal");
                nCodigoPostal.InnerText = pFactura.Cliente.CodigoPostal.ToString();
                nDestinatario.AppendChild(nCodigoPostal);
                //-----

                //Detalle
                var nDetalleFactura = xmlDocument.CreateElement("Detalle");
                nNoFactura.AppendChild(nDetalleFactura);

                var nSubasta = xmlDocument.CreateElement("Subasta");
                nSubasta.SetAttribute("Codigo", pFactura.Subasta.IdSubasta.ToString());
                nDetalleFactura.AppendChild(nSubasta);

                //
                var nBien = xmlDocument.CreateElement("Bien");
                nDetalleFactura.AppendChild(nBien);

                var nCodigoBien = xmlDocument.CreateElement("Codigo");
                nCodigoBien.InnerText = pFactura.Subasta.Bien.IdBien.ToString();
                nBien.AppendChild(nCodigoBien);

                var nTipoBien = xmlDocument.CreateElement("Categoria");
                nTipoBien.InnerText = pFactura.Subasta.Bien.Tipo.Descripcion;
                nBien.AppendChild(nTipoBien);

                var nDescripcionBien = xmlDocument.CreateElement("Descripcion");
                nDescripcionBien.InnerText = pFactura.Subasta.Bien.Descripcion.ToString();
                nBien.AppendChild(nDescripcionBien);

                var nCantidad = xmlDocument.CreateElement("Cantidad");
                nCantidad.InnerText = "1";
                nBien.AppendChild(nCantidad);
                //
                var nMonto = xmlDocument.CreateElement("Monto");
                nMonto.InnerText = pFactura.Subasta.TotalOfertado.ToString("n2");
                nDetalleFactura.AppendChild(nMonto);

                var nIVA = xmlDocument.CreateElement("IVA");
                nDetalleFactura.AppendChild(nIVA);

                var nPorcentajeIVA = xmlDocument.CreateElement("Porcentaje");
                nPorcentajeIVA.InnerText = pFactura.IVA.ToString("n2") + "%";
                nIVA.AppendChild(nPorcentajeIVA);

                var nMontoIVA = xmlDocument.CreateElement("Monto");
                nMontoIVA.InnerText = pFactura.CalcularImpuesto().ToString("n2");
                nIVA.AppendChild(nMontoIVA);

                var nComision = xmlDocument.CreateElement("Comision");
                nDetalleFactura.AppendChild(nComision);

                var nPorcentajeComision = xmlDocument.CreateElement("Porcentaje");
                nPorcentajeComision.InnerText = pFactura.Comision.ToString("n2") + "%";
                nComision.AppendChild(nPorcentajeComision);

                var nMontoComision = xmlDocument.CreateElement("Monto");
                nMontoComision.InnerText = pFactura.CalcularComision().ToString("n2");
                nComision.AppendChild(nMontoComision);

                var nTotal = xmlDocument.CreateElement("Total");
                nDetalleFactura.AppendChild(nTotal);

                var nTotalDolares = xmlDocument.CreateElement("Dolares");
                nTotalDolares.InnerText = pFactura.Total.ToString("n2");
                nTotal.AppendChild(nTotalDolares);

                var nTotalColones = xmlDocument.CreateElement("Colones");
                nTotalColones.InnerText = (pFactura.Total * pMontoColones).ToString("n2");
                nTotal.AppendChild(nTotalColones);

                return xmlDocument;
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg);
                return null;
            }

        }
        /// <summary>
        /// Convierte un xmlDocumment a un array de Bytes.
        /// </summary>
        /// <param name="pXML"></param>
        /// <returns></returns>
        public static byte[] ConvertXmlDocumentToByteArray(XmlDocument pXML)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(ms, new XmlWriterSettings { Encoding = Encoding.UTF8 }))
                {
                    pXML.WriteTo(xmlWriter);
                }
                return ms.ToArray();
            }
        }
    }
}
