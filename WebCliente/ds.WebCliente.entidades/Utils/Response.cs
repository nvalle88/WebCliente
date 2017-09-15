using System.Collections.Generic;

namespace bd.log.entidades.Utils
{
    /*
    Creado por DigitalStrategy
    Las Clases Utils son clases con metodos para ser reutilizados como mensajes, Codificar, o response 
    según sean necesarias para el proyecto
    */

    public class Response
    {
        public  bool IsSuccess { get; set; }
        public  string Message { get; set; }
        public object Resultado { get; set; }
        public List<object> Resultados { get; set; } 

    }
}
