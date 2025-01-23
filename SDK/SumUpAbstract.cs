/*
 * Copyright (c) 2025 Bruno Venancio Alves
 *
 * Author: Bruno Venancio Alves
 * Email: boteistem@gmail.com
 *
 * Permission is granted to use, modify, and distribute this software with
 * acknowledgment of the original author. This notice must not be removed
 * or altered from any source distribution.
 */
using RestSharp;
using CheckoutField = SumUp.SDK.Fields.CheckoutFields;
using SumUp.SDK.Helper;
namespace SumUp.SDK
{
    public abstract class SumUpAbstract
    {
        private RestClient httpClient { get; set; }
        protected SumUpAbstract(){
            this.httpClient = new RestClient(
                new RestClientOptions(Config.getBaseUrl()){

                }
            );
        }
        /// <summary>
        /// get request instance
        /// </summary>
        /// <param name="path"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private RestRequest getRequest(string path, Method method){
            return new RestRequest(path, method).AddHeader("Authorization", "Bearer " + Config.getAccessToken());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected T ExecuteGet<T>(string uri) where T : new (){
            RestRequest request = this.getRequest(uri, Method.Get);
            var response =  this.httpClient.Execute<T>(request);
            if (response.IsSuccessful){
                return response.Data;
            }
            throw new Exception("Erro na execução do GET request: " + response.Content);
        }
       protected T ExecutePost<T, F>(string uri, F fields) where T : new() where F : class{
            RestRequest request = this.getRequest(uri, Method.Post).AddJsonBody(fields);
            var response =  this.httpClient.Execute<T>(request);
            if (response.IsSuccessful){
                return response.Data;
            }
            throw new Exception("Erro na execução do POST request: " + response.Content);
        }
        protected T ExecutePut<T, F>(string uri, F fields) where T : new() where F : class{
            RestRequest request = this.getRequest(uri, Method.Put).AddJsonBody(fields);
            var response =  this.httpClient.Execute<T>(request);
            if (response.IsSuccessful){
                return response.Data;
            }
            throw new Exception("Erro na execução do PUT request: " + response.Content);
        }
    }
}