﻿using System.Collections.Generic;

namespace bd.log.entidades.Utils
{
    public  class Response
    {
        public  bool IsSuccess { get; set; }
        public  string Message { get; set; }
        public object Resultado { get; set; }
        public List<object> Resultados { get; set; } 

    }
}
