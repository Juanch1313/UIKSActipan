using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKSActipan.Functions;
using UIKSActipan.mySQL;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UIKSActipan.mySQL
{
    public class commands
    {
        private static int _lastFileID = 0;
        private static int _lastPatientID = 0;
        private static int _LastUserID = 0;

        //Metodos para guarar y obtener usuario loggeado
        private static User user = new User();

        //Metodo para guardar el ultimo usuario loggeado
        public static User getUser()
        {
            return user;
        }

        public static int get_lastPatientID()
        {
            return _lastPatientID;
        }

        //INICIA OBTENER ULTIMOS ID DE TABLAS

        private static void getLastFileId()
        {
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT MAX(archivo_id) FROM archivo"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    _lastFileID = dataReader.GetInt32(0);
                }
                else { _lastFileID = 0; }

            }
            catch (Exception e) { MessageBox.Show("Error al obtener ultimo archivo " + e.ToString()); }
        }

        public static void getLastPatientId()
        {
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT MAXT(paciente_id) FROM paciente"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    _lastPatientID = dataReader.GetInt32(0);
                }
                else { _lastPatientID = 0; }
                
            }
            catch (Exception e) { MessageBox.Show("Error al obtener ultimo paciente"); }
        }

        public static void getLastUserID()
        {
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT COUNT(usuario_id) FROM usuario"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    _LastUserID = dataReader.GetInt32(0);
                }
                else { _LastUserID = 0; }

            }
            catch (Exception e) { MessageBox.Show("Error al obtener ultimo UsuarioID"); }
        }


        //TERMINA OBTENER ULTIMOS ID DE TABLAS


        //INICIA INSERCCIONES EN LA BASE DE DATOS

        public static int InsertNewDataBaseUser(string user, string password)
        {
            int retorno = 0;
            MySqlCommand command = new MySqlCommand(String.Format("CREATE USER '{0}'@'remotemysql.com' IDENTIFIED BY '{1}';", user, password), connection.getConnection());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }

        public static int Privileges(string user)
        {
            int retorno = 0;
            MySqlCommand command = new MySqlCommand(String.Format("GRANT ALL PRIVILEGES ON * . * TO '{0}'@'remotemysql.com';", user), connection.getConnection());
            command.ExecuteNonQuery();
            return retorno;
        }

        public static int InsertPatient(Patient patient)
        {
            int retorno = 0;

            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO paciente(paciente_id, nombre, apellidos, sexo, telefono, domicilio, fecha_nacimiento, estado_civil, escolaridad, ocupacion, estado)" +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10});", 
                    patient.id, patient.nombre, patient.apellidos, patient.genero, patient.telefono, patient.domicilio, patient.nacimiento,
                    patient.estadoCivil, patient.escolaridad, patient.ocupacion, patient.estado), connection.getConnection());
                retorno = command.ExecuteNonQuery();
            }
            catch(Exception e) { MessageBox.Show("Algo malo sucedio al añadir un paciente nuevo"); }

            return retorno;
        }

        public static int InsertEmploy(User user)
        {
            int retorno = 0;

            try
            {
                getLastUserID();
                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO usuario(usuario_id, nombre, apellidos, ocupacion, usuario, contrasenia)" +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', MD5('{5}'));",_LastUserID + 1, user.firstName, user.lastNames, user.position,
                    user.user, user.password), connection.getConnection());
                retorno = command.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show("Algo malo sucedio al añadir un empleado nuevo"); }
            return retorno;
        }

        public static int InsertRegister(string date, int patientId)
        {
            int retorno = 0;
            getLastFileId();
            try
            {
                _lastFileID++;
                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO archivo(archivo_id, paciente_id, usuario_id, fecha) " +
                    "VALUES ({0}, {1}, {2}, '{3}')", _lastFileID, patientId, user.id, date), connection.getConnection());
                retorno = command.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show("Algo malo sucedio al añadir un registro de archivo a la base de datos " + e.ToString()); }

            return retorno;
        }



        //TERMINA INSERCCIONES EN LA BASE DE DATOS

        //INICIA BUSQUEDAS Y OBTENCION DE DATOS

        public static User getLoggin(string loggin)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM usuario WHERE usuario = '{0}'", loggin), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.firstName = reader.GetString(1);
                    user.lastNames = reader.GetString(2);
                    user.user = reader.GetString(3);
                    user.password = reader.GetString(4);
                    user.position = reader.GetString(5);

                }
            }
            catch (Exception e) { MessageBox.Show("Error: Quizas el usuario no existe " + e.ToString()); }

            return user;
        }

        public static User getUser(int id)
        {
            User employ = new User();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM usuario WHERE usuario_id = {0};", id), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employ.id = Convert.ToInt32(reader.GetString(0));
                    employ.firstName = reader.GetString(1);
                    employ.lastNames = reader.GetString(2);
                    employ.user = reader.GetString(3);
                    employ.password = reader.GetString(4);
                    employ.position = reader.GetString(5);
                }
            }
            catch (Exception e) { MessageBox.Show("Error: Quizas el usuario no existe " + e.ToString()); }

            return employ;
        }

        public static List<User> getEmploy(string name)
        {
            List<User> users = new List<User>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM usuario WHERE nombre = '{0}' OR apellidos = '{0}'", name), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User employ = new User();
                    employ.id = reader.GetInt32(0);
                    employ.firstName = reader.GetString(1);
                    employ.lastNames = reader.GetString(2);
                    employ.user = reader.GetString(3);
                    employ.password = "";
                    employ.position = reader.GetString(5);
                    users.Add(employ);

                }
            }
            catch (Exception e) { MessageBox.Show("Error: Quizas el usuario no existe " + e.ToString()); }

            return users;
        }

        public static List<User> getEmploys()
        {
            List<User> users = new List<User>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM usuario"), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User employ = new User();
                    employ.id = reader.GetInt32(0);
                    employ.firstName = reader.GetString(1);
                    employ.lastNames = reader.GetString(2);
                    employ.user = reader.GetString(3);
                    employ.password = "";
                    employ.position = reader.GetString(5);
                    users.Add(employ);

                }
            }
            catch (Exception e) { MessageBox.Show("Error: Quizas el usuario no existe " + e.ToString()); }

            return users;
        }

        public static List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM paciente"), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.id = reader.GetInt32(0);
                    patient.nombre = reader.GetString(1);
                    patient.apellidos = reader.GetString(2);
                    patient.genero = reader.GetChar(3);
                    patient.telefono = reader.GetString(4);
                    patient.domicilio = reader.GetString(5);
                    patient.nacimiento = reader.GetString(6);
                    patient.estadoCivil = reader.GetString(7);
                    patient.escolaridad = reader.GetString(8);
                    patient.ocupacion = reader.GetString(9);
                    patient.estado = reader.GetBoolean(10);

                    patients.Add(patient);
                }
            }
            catch (Exception e) { MessageBox.Show("Ocurrio algun error al buscar los pacientes."); }
            return patients;
        }

        public static List<Patient> getPatient(string patientname)
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM paciente WHERE apellidos = '{0}' OR nombre = '{0}'", patientname, patientname), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.id = reader.GetInt32(0);
                    patient.nombre = reader.GetString(1);
                    patient.apellidos = reader.GetString(2);
                    patient.genero = reader.GetChar(3);
                    patient.telefono = reader.GetString(4);
                    patient.domicilio = reader.GetString(5);
                    patient.nacimiento = reader.GetString(6);
                    patient.estadoCivil = reader.GetString(7);
                    patient.escolaridad = reader.GetString(8);
                    patient.ocupacion = reader.GetString(9);
                    patient.estado = reader.GetBoolean(10);

                    patients.Add(patient);
                }
            }
            catch (Exception e) { MessageBox.Show("Ocurrio algun error al buscar los pacientes."); }

            return patients;
        }

        public static Patient getPatientById(int id)
        {
            Patient patient = new Patient();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM paciente WHERE paciente_id = {0}", id), connection.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patient.id = reader.GetInt32(0);
                    patient.nombre = reader.GetString(1);
                    patient.apellidos = reader.GetString(2);
                    patient.genero = reader.GetChar(3);
                    patient.telefono = reader.GetString(4);
                    patient.domicilio = reader.GetString(5);
                    patient.nacimiento = reader.GetString(6);
                    patient.estadoCivil = reader.GetString(7);
                    patient.escolaridad = reader.GetString(8);
                    patient.ocupacion = reader.GetString(9);
                    patient.estado = reader.GetBoolean(10);
                }
            }
            catch (Exception e) { MessageBox.Show("Ocurrio algun error al buscar un paciente por ID."); }

            return patient;
        }

        public static int getPetientID(string firstName, string lastname)
        {
            int id = 0;
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM paciente WHERE nombre = '{0}' AND apellidos = '{1}'",
                    firstName, lastname), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }
            }
            catch (Exception e) { MessageBox.Show("Error al obtener paciente por ID "); }
            return id;
        }


        public static List<string> getNameEmploys()
        {
            List<string> employNames = new List<string>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT nombre, apellidos FROM usuario;"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    employNames.Add(dataReader.GetString(0) + " " +  dataReader.GetString(1));
                }
            }
            catch (Exception e) { MessageBox.Show("Error al obtener registros de usuario"); }
            return employNames;
        }

        public static List<string> getPatientNames()
        {
            List<string> patientNames = new List<string>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT nombre, apellidos FROM paciente;"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    patientNames.Add(dataReader.GetString(0) + " " + dataReader.GetString(1));
                }
            }
            catch (Exception e) { MessageBox.Show("Error al obtener registros de pacientes "); }
            return patientNames;
        }

        public static List<littleUser> getDateRegisters()
        {
            List<littleUser> littles = new List<littleUser>();
            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("SELECT paciente_id, usuario_id, fecha FROM archivo"), connection.getConnection());
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    littleUser little = new littleUser();
                    little.id_Patient = dataReader.GetInt32(0);
                    little.id_User = dataReader.GetInt32(1);
                    little.date = dataReader.GetString(2);
                    littles.Add(little);
                }
            }
            catch (Exception e) { MessageBox.Show("Error al obtener registros de archivos"); }
            return littles;
        }


        //TERMINA BUSQUEDAS Y OBTENCION DE DATOS

        //INICIA MODIFICACIONES EN BASES DE DATOS

        public static int updateEmploy(User user, int id)
        {
            int retorno = 0;

            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE usuario SET nombre = '{0}', apellidos = '{1}' , usuario = '{2}', " +
                                                                      "contrasenia = '{3}', ocupacion = '{4}' " +
                    "WHERE usuario_id = {5} ", user.firstName, user.lastNames, user.user, user.password, user.position, id), connection.getConnection());
                retorno = command.ExecuteNonQuery();
            }
            catch(Exception e) { MessageBox.Show("Error al modificar un empleado"); }

            return retorno;
        }

        public static int updatePatient(Patient patient, int id)
        {
            int retorno = 0;

            try
            {
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE paciente SET nombre = '{0}', apellidos = '{1}', sexo = '{2}', telefono = '{3}'," +
                    " domicilio = '{4}', fecha_nacimiento = '{5}', estado_civil = '{6}', escolaridad = '{7}', ocupacion = '{8}', estado = {9} WHERE paciente_id = {10}",
                    patient.nombre, patient.apellidos, patient.genero, patient.telefono, patient.domicilio, patient.nacimiento, patient.estadoCivil,
                    patient.escolaridad, patient.ocupacion, patient.estado, id), connection.getConnection());
                retorno = command.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show("Error al modificar un paciente " + e.ToString()); }

            return retorno;
        }

        //TERMINA MODIFICACIONES EN BASES DE DATOS


        //FUNCION PARA ENCONTRAR EL MD5 DE UN TEXTO
        public static string GetMD5(string password)
        {
            var md5 = MD5.Create();
            var encoding = new ASCIIEncoding();
            byte[] stream = null;
            var sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        //Validar que la contraseña sea correcta verificando diferentes aspectos"
        public static bool CheckPassword(string password, string confirmPassword)
        {   
            string resultado = "";
            bool esCorrecta = true;
            if (password.Length < 8)
            {
                resultado += "	La contraseña debe tener mínimo 8 caractéres.\n";
                esCorrecta = false;
            }
            if (password != confirmPassword)
            {
                resultado += "	Las contraseñas no coinciden.\n";
                esCorrecta = false;
            }
            if (!(password.Contains("@") || password.Contains("#") || password.Contains("$") || password.Contains("&") || password.Contains("%")))
            {
                resultado += "	La contraseña necesita tener algún caractér especial: '@', '#', '$', '&' ó '%'.\n";
                esCorrecta = false;
            }
            if (!(password.Any(char.IsDigit)))
            {
                resultado += "	La contraseña necesita tener algún número contenido.\n";
                esCorrecta = false;
            }
            if (password.Any(char.IsPunctuation) && !((password.Contains("@") || password.Contains("#") || password.Contains("$") || password.Contains("&") || password.Contains("%"))) || password.Contains(" "))
            {
                resultado += "	La contraseña no puede tener signos de puntuación o espacios.\n";
                esCorrecta = false;
            }

            if (esCorrecta)
            {
                resultado = "\nCumple con todas las condiciones\n";
                return esCorrecta;
            }
            else
            {
                string temp = resultado;
                resultado = "\nError: \n" + temp;
                MessageBox.Show(resultado);
                return esCorrecta;
            }

        }
    }
}
