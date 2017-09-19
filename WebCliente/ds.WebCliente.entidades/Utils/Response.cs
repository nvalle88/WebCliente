using System.Collections.Generic;

namespace ds.WebClient.entities.Utils
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
        public object Result { get; set; }
        public List<object> Results { get; set; } 

    }
}
