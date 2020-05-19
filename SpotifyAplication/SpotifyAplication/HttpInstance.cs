using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
//using System.Net.Http;
//using System.Threading.Tasks;
    

    //OBSERVAÇÃO
    //Não é performatico a utilização utilizar varias estancias do httpcliente
    //Então essa classe ela minimiza o uso deste 
    //Existe um parametro dentro do windows pra determinar o tempo do socket para que
    //ele continue ativo.
    //Por isso a estancia inicial no httpCliente é Static, para ser usado na aplicação toda
    
namespace SpotifyAplication
{
    public class HttpInstance
    {
        //Aqui você definiu que ela não será enxergado por todos com private
        //O tipo vai ser static dizendo que ela só será visto na aplicação inteira
        //Seu tipo é HttpClient 
        //seu nome é HttpClienteInstance
        private static HttpClient HttpClienteInstance;

        //Constructor da classe
        HttpInstance()
        {
        }      
        public static HttpClient GetHttpClientInstance()
        {
            //Se a instancia estiver nula, a validação estanciar e aponta false na CloseConnection
            if(HttpClienteInstance == null)
            {
                HttpClient HttpClienteInstance = new HttpClient();

                //Igual a false informa que a conexão que a conexão vai ficar sempre aberta

                HttpClienteInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return HttpClienteInstance;
        }      
    }  
}