using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Threading;

namespace UIKSActipan.Functions
{
    public class Files
    {
        private static string[] months =
        {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"
        };
        /*Path = direccion donde se trabajara para guardar los archivos de los pacientes*/
        private static string user = Environment.UserName;
        private static string path = @"C:\Users\" + user + @"\Documents\Registros-De-Pacientes";
        private static string registersPath = @"C:\Users\" + user + @"\Documents\Registros-De-Pacientes\";
        private static string patientpath;
        /*Esta variable guardara las direcciones de los archivos a trabajar*/
        private static string[] files;
        /*Bandera para checar que los archivos existan ligada a la funcion "CheckRegisters" */
        private static bool existRegisters;

        public static string getPath()
        {
            return registersPath;
        }

        /*Funcion para añadir la carpeta principal*/
        public static void AddRootDirectory()
        {
            try
            {

                /*Si no existe la direccion (path) entonces se crea*/
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch( Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
          
        }

        /*Funcion para añadir una carpeta principal donde se guardaran futuros registros*/
        public static void AddSubRootDirectory(string patient)
        {
            try
            {
                /*Se crea un nuevo path este sera la ruta especifica de cada paciente*/
                patientpath = Path.Combine(path, patient);
                /*Si no existe la direccion (patientpath) entonces se crea*/
                if (!Directory.Exists(patientpath))
                {
                    Directory.CreateDirectory(patientpath);
                }
            }
            catch (Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
        }

        //Funcion que crea carpetas de los registros que se elaboran para un paciente en especifico
        public static bool AddSubRegistersDirectory(string date)
        {
            try
            {
                //Cambiamos el path del paciente a la que ahora sera donde copiamos los archivos
                patientpath = Path.Combine(patientpath, date);
                if (!Directory.Exists(patientpath))
                {
                    Directory.CreateDirectory(patientpath);
                    return false;
                }
            }
            catch (Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
            return true;
        }

        public static void CheckRegisters()
        {
            try
            {
                /*Comprobara si existen los archivos en la carpeta principal
                 en caso de no estarlos el usuario tendra que colocarlos de manera manual*/
                if (!Directory.Exists(registersPath + "RegistrosWord") && !Directory.Exists(registersPath + "RegistrosPdf"))
                {
                    MessageBox.Show("No estan los registros en la carpeta Principal!!!");
                    return;
                }
                /*Si existe cambiara el estado de existRegisters para comprobar en futuras funciones*/
                existRegisters = true;
            }
            catch (Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
        }

        public static void copyFiles(bool mode)
        {
            try
            {
                /*Computer es una gran ayuda para copiar archivos de un directorio a otro como en este caso se hara*/
                Computer computer = new Computer();
                if (existRegisters)
                {
                    string registerSub = registersPath;
                    files = Directory.GetFiles(registerSub += (mode ? "RegistrosWord" : "RegistrosPdf"));
                    foreach (string archive in files)
                    {
                        /*FileInfo para obtener los datos de cada archivo que se este leyendo
                         en este caso paa poder obtener el nombre*/
                        FileInfo fileInfo = new FileInfo(archive);
                        /*Valida que no se colocen mas de una vez en la carpeta*/
                        if (!File.Exists(Path.Combine(patientpath, fileInfo.Name)))
                        {
                            /*Copia los archivos de los registros y los coloca en la carpeta del paciente*/
                            computer.FileSystem.CopyFile(archive, Path.Combine(patientpath, fileInfo.Name));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los registros aun no estan en el disco duro \nPor favor agreguelos en: c:/users/user/documents/Registro-De-Pacientes");
                }
            }
            catch (Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
        }

        public static void OpenFiles()
        {
            try
            {
                //Variable proceso el cual dara apertura a un archivo en esta caso pdf's
                Process process = new Process();
                //Guardamos en files las direcciones de los archivos que previamente copiamos
                files = Directory.GetFiles(patientpath);
                foreach (string file in files)
                {
                    //Da apertura a cada uno de los pdf's dentro de la carpeta
                    process = Process.Start(file);
                    /*Espera a que el pdf previamente abierto cierre para poder asi abrir el siguiente
                     gracias al ciclo foreach*/
                    process.WaitForExit();
                }
            }
            catch (Exception e) { MessageBox.Show("Algo malo paso: " + e.ToString()); }
        }
    }
}
