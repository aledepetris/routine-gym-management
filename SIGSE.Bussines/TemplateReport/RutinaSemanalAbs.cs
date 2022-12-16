using SIGSE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGSE.Bussines.TemplateReport
{
    public abstract class RutinaSemanalAbs
    {
        public RutinaSemanalAbs()
        {

        }

        public string crearRutinaAndReturnPath(Semana sem)
        {
            inicializarDocumento();
            generarDocumento(sem);
            ajustarTextos();
            return guardarAndObtenerRuta();
        }

        protected abstract void inicializarDocumento();
        protected abstract void ajustarTextos();
        protected abstract void generarDocumento(Semana sem);
        protected abstract string guardarAndObtenerRuta();

    }
}

