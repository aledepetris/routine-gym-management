using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Entities.Auditoria
{
    public class AuditoriaLogin
    {
        public int idLogin { get; set; }
        public string username { get; set; }
        public DateTime? fechaHoraConexion { get; set; }
        public DateTime? fechaHoraDesconexion { get; set; }
        public bool sesionActiva { get; set; }

        public AuditoriaLogin()
        {

        }

        public AuditoriaLogin(string username)
        {
            this.username = username;
            fechaHoraConexion = DateTime.Now;
            sesionActiva = true;
        }

    }
}
