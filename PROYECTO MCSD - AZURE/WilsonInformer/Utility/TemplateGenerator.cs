using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WilsonInformer.Models;

namespace WSegInformer.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLParte(Parte p,String seguimiento, String resf)
        {

            Image image = Image.FromFile("wwwroot/assets/images/partelogo.png");

            MemoryStream m = new MemoryStream();
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();

            // Convert byte[] to Base64 String
            string base64img = Convert.ToBase64String(imageBytes);
            
            string sb = "<style type=\"text/css\">" +
            "    body, div, table, thead, tbody, tfoot, tr, th, td, p {" +
            "        font-family: \"Calibri\";" +
            "        font-size: large" +
            "    }" +
            "    a.comment-indicator:hover + comment {" +
            "        background: #ffd;" +
            "        position: absolute;" +
            "        display: block;" +
            "        border: 1px solid black;" +
            "        padding: 0.5em;" +
            "    }" +
            "    a.comment-indicator {" +
            "        background: red;" +
            "        display: inline-block;" +
            "        border: 1px solid black;" +
            "        width: 0.5em;" +
            "        height: 0.5em;" +
            "    }" +
            "    comment {" +
            "        display: none;" +
            "    }" +
            "</style>" +
            "<br/>" +
            "<br/>" +
            "<table align =\"center\" cellspacing=\"0\" border=\"0\">" +
            "            <colgroup width=\"136\"></colgroup>" +
            "            <colgroup span=\"2\" width=\"85\"></colgroup>" +
            "            <colgroup width=\"23\"></colgroup>" +
            "            <colgroup width=\"109\"></colgroup>" +
            "            <colgroup span=\"2\" width=\"85\"></colgroup>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000\" colspan=2 height=\"45\" align=\"center\" " +
            "                    valign=middle><b><font face=\"Arial\" size=3 color=\"#000000\">   PARTE DE CIERRE:</font></b></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-right: 2px solid #000000\" colspan=3 align=\"left\" valign=middle>" + p.N_parte + "</td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" colspan=2 align=\"center\" valign=middle>" +
            "                    <b>" +
            "                        <font face=\"Arial\" size=3 color=\"#000000\">" +
            "                            <br/><img src=\"data:image/png;base64, " + base64img+"\"  width=136 height=24 hspace=17 vspace=10 />" + 
            "                        </font>" +
            "                    </b>" +
            "                </td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"21\" align=\"left\" valign=middle><font face=\"Arial\" size=3 color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000\" height=\"40\" align=\"left\" " +
            "                    valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Fecha reclamacion</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\"" +
            "                    colspan=2 align=\"center\" valign=middle sdnum=\"1033;1033;M/D/YYYY\"><b><font face=\"Franklin Gothic Book\" color=\"#000000\">" + p.F_Albaran.ToString("dd/MM/yyyy") + "</font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#000000\"><br></font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Reclamado por</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\"" +
            "                    colspan=2 align=\"center\" valign=middle sdnum=\"1033;0;\"><b><font face=\"Franklin Gothic Book\" color=\"#000000\">" + p.Propi + "</font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"21\" align=\"left\" valign=middle><font face=\"Arial\" size=3 color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000\" height=\"40\" align=\"left\" " +
            "                    valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Env&iacute;o</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    colspan=2 align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\">" + p.Serv + "</font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Arial\" color=\"#000000\"><br></font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">N&ordm;  albar&aacute;n</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    colspan=2 align=\"center\" valign=middle sdnum=\"1033;0;\"><b><font face=\"Franklin Gothic Book\" color=\"#000000\">" + p.GetAlbaran(p.Envios) + "</font></b></td>" +
            "            </tr><tr><td></td></tr>" +
            "            <tr>" +
            "                <td style=\"border-bottom: 2px solid #000000;border-top: 2px solid #000000; border-left: 2px solid #000000\" height=\"40\" align=\"left\" valign=middle>" +
            "                <font face=\"Franklin Gothic Book\" color=\"#FF0000\">N&ordm; de bultos</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    colspan=2 align=\"center\" valign=middle sdval=\"4\" sdnum=\"1033;0;0\"><b><font face=\"Arial\" color=\"#000000\">" + p.Bult + "</font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#000000\"><br></font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\"" +
            "                    align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Fecha albar&aacute;n</font></td>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    colspan=2 align=\"center\" valign=middle sdnum=\"1033;1033;M/D/YYYY\"><b><font face=\"Franklin Gothic Book\" color=\"#000000\">" + p.F_Albaran.ToString("dd/MM/yyyy") + "</font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"20\" align=\"left\" valign=middle><font face=\"Arial\" size=3 color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"20\" align=\"left\" valign=middle><font face=\"Arial\" size=3 color=\"#000000\"> </font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"27\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">FR.ORIGEN</font></i></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">FR.DESTINO</font></i></b></td>" +
            "                <td align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\"><br></font></i></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"41\" align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Franquicia</font></td>" +
            "                <td colspan=3 align=\"center\" valign=middle sdnum=\"1033;0;\"><b><font face=\"Arial\" color=\"#000000\">" + p.Orig + "</font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\">Franquicia</font></td>" +
            "                <td colspan=2 align=\"center\" valign=middle sdnum=\"1033;0;\"><b><font face=\"Arial\" color=\"#000000\">" + p.Dest + "</font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"11\" align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"41\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">NOMBRE ABO</font></i></b></td>" +
            "                <td colspan=6 align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\">" + p.Abonado + "</font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"11\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\"><br></font></i></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"41\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">BULTOS</font></i></b></td>" +
            "                <td colspan=2 align=\"center\" valign=middle sdval=\"4\" sdnum=\"1033;\"><b><font face=\"Arial\" color=\"#000000\">" + p.Bult + "</font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"9\" align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"left\" valign=middle><font face=\"Franklin Gothic Book\" color=\"#FF0000\"><br></font></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "                <td align=\"center\" valign=middle><b><font face=\"Arial\" color=\"#000000\"><br></font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"31\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">SEGUIMIENTO: </font></i></b></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; " +
            "border-right: 2px solid #000000\" colspan=7 height=\"99\" align=\"left\" valign=top>" +
            "                    <font face=\"Arial\" color=\"#000000\">" +
            "Confirmada la reclamación de la pérdida con las Franquicias implicadas, se procede a efectuar el seguimiento correspondiente. " +
            "Quedando en este departamento a disposición de ustedes y del Comité de Ética, Arbitraje y Asesoramiento toda la documentación " +
            "referente a las  personas de las Franquicias y Plataformas consultadas" +
            "                    </font>" +
            "                </td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"1\" align=\"left\" valign=middle><font face=\"Arial\" color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td colspan=2 height=\"39\" align=\"left\" valign=middle><b><i><font face=\"Arial\" color=\"#FF0000\">RESULTADO FINAL</font></i></b></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; " +
            "border-right: 2px solid #000000\" colspan=7 height=\"100\" align=\"left\" valign=top>" +
            "                    <b>" +
            "                        <font face=\"Arial\" color=\"#000000\">" + resf +
            "                        </font>" +
            "                    </b>" +
            "                </td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"18\" align=\"left\" valign=middle><font face=\"Arial\" color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; " +
            "border-right: 2px solid #000000\" colspan=7 height=\"53\" align=\"left\" valign=middle><b>" +
            "                    <font face=\"Arial\" color=\"#000000\">ESTE INFORME ES EXCLUSIVAMENTE PARA USO INTERNO DE LA RED Y NO DEBE MOSTRARSE A LOS CLIENTES</font></b></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td height=\"25\" align=\"left\" valign=middle><font face=\"Arial\" color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "                <td align=\"left\" valign=bottom><font color=\"#000000\"><br></font></td>" +
            "            </tr>" +
            "            <tr>" +
            "                <td style=\"border-top: 2px solid #000000; border-bottom: 2px solid #000000; border-left: 2px solid #000000; border-right: 2px solid #000000\" " +
            "                    colspan=7 height=\"43\" align=\"right\" valign=middle><b><font face=\"Arial\" color=\"#000000\">DPTO SEGURIDAD ENVIOS</font></b></td>" +
            "            </tr>" +
            "        </table>" +
            "  <br/>";

            return sb;
        }
    }
}
