using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebabridge
{
    class Expediente
    {
        private readonly IExpedienteVisualizador _visualizador;

    public Expediente(IExpedienteVisualizador visualizador)
    {
        _visualizador = visualizador;
    }

    public string Visualizar(List<string> datos)
    {
        return _visualizador.Visualizar(datos);
    }
    }
}
