using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
//using System.Net.Http;
//using System.Threading.Tasks;

namespace SpotifyAplication
{
    public class HttpInstance
    {
        //Aqui você definiu que ela não será enxergado por todos com private
        //O tipo vai ser static dizendo que ela só será visto neste contexto do app
        //Seu tipo é HttpClient 
        //seu nome é HttpClienteInstance
        private static HttpClient HttpClienteInstance;

        HttpInstance()
        {
        }      
        public static HttpClient GetHttpClientInstance()
        {
            if(HttpClienteInstance == null)
            {
                HttpClient HttpClienteInstance = new HttpClient();
                HttpClienteInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return HttpClienteInstance;
        }      
    }  
}