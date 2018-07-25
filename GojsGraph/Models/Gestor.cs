using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GojsGraph.Models
{
    public class Gestor
    {
        public List<PersonaNodo> Consultar()
        {
            var listado = Broker.ConsultarNodo<PersonaNodo>();
            return listado;
        }


        public List<Vertice> ConsultarVertices()
        {
            var listado = Broker.ConsultarVertices<Vertice>();
            return listado;
        }
    }
}