using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIKSActipan.Functions
{
    public class Archive
    {
        private int id { get; set; }
        private int usuarioID { get; set; }
        private int pacienteID { get; set; }
        private string fecha { get; set; }

        public Archive(int id, int usuarioID, int pacienteID, string fecha)
        {
            this.id = id;
            this.usuarioID = usuarioID;
            this.pacienteID = pacienteID;
            this.fecha = fecha;
        }
    }
}
