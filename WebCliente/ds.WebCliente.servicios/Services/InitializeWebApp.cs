﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using ds.WebClient.entities.Utils;
using Newtonsoft.Json;

namespace ds.WebClient.service.Services
{
    public class InitializeWebApp
    {
       
        #region Methods

        public static async Task Inicializar(string id,Uri baseAddress)
        {
            try
            {
                //using (HttpClient client = new HttpClient())
                //{
                //    client.BaseAddress =baseAddress;
                //    var url = string.Format("{0}/{1}", "/api/Adscsists", id);
                //    var respuesta = await client.GetAsync(url);
                    
                //    var resultado = await respuesta.Content.ReadAsStringAsync();
                //    var response = JsonConvert.DeserializeObject<Response>(resultado);
                //    var sistema = JsonConvert.DeserializeObject<DiGitalStrategy>(response.Resultado.ToString());
                //    WebApp.BaseAddress = sistema.AdstHost;
                //    AppGuardarLog.BaseAddress= sistema.AdstHost;
                //}
               
            }
            catch (Exception ex)
            {

            }

        }

        #endregion
    }
}
