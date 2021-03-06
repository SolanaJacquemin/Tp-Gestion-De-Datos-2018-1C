﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace readConfig
{
    class Config
    {
        static public string fechaSystem()
        {
            // obtiene la fecha del sistema (para creación de registros como default)
            StreamReader config = new StreamReader("../../../config.txt");
            string linea = "";
            string buffer = config.ReadLine();
            while (buffer != null)
            {
                if (buffer.Substring(0, 5) == "Fecha")
                {
                    linea = buffer;
                }
                buffer = config.ReadLine();
            }
            config.Close();

            return (linea.Substring(13, 4) + "-" + linea.Substring(7, 2)) + "-" + linea.Substring(10, 2);

        }

        static public string strConection()
        {
            string user = "";
            string pass = "";
            string dtSrc = "";
            string iniCtlg = "";
            StreamReader config = new StreamReader("../../../config.txt");
            string buffer = "";
            buffer = config.ReadLine();
            while (buffer != null)
            {
                if (buffer.Substring(0, 4) == "Data")
                {
                    dtSrc = buffer.Substring(13);
                }

                if (buffer.Substring(0, 4) == "Init")
                {
                    iniCtlg = buffer.Substring(17);
                }

                if (buffer.Substring(0, 4) == "User")
                {
                    user = buffer.Substring(9);
                }


                if (buffer.Substring(0, 4) == "Pass")
                {
                    pass = buffer.Substring(10);
                }
                buffer = config.ReadLine();
            }
            config.Close();
            // devuelve la cadena de conexión
            return "Data Source=" + dtSrc + ";Initial Catalog=" + iniCtlg + ";User ID=" + user + ";Password=" + pass;
        }
    }
}
