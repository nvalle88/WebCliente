using ds.WebClient.entities.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ds.WebClient.service.Interfaces
{
    /*
     * Creado por DigitalStrategy
     * Aqui se deben crear todas las interfaces que estaran conectadas a los servicios 
         
             */
    public interface IApiService
    {
        Task<Response> InsertarAsync<T>(T model,Uri baseAddress, string url );
        Task<Response> EliminarAsync(string id, Uri baseAddress, string url);
        Task<Response> EditarAsync<T>(string id, T model, Uri baseAddress, string url);
        Task<T> SeleccionarAsync<T>(string id, Uri baseAddress, string url) where T : class;
        Task<List<T>> Listar<T>(Uri baseAddress, string url) where T :class;
        Task<List<T>> Listar<T>(object model, Uri baseAddress, string url) where T :class;
    }
}
