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
 namespace SumUp.SDK.Helper{
    /// <summary>
    /// Configure class from config class
    /// </summary>
    class Config{
        private static string access_token {get;set;} = "";
        /// <summary>
        /// set the access token
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string setAccessToken(string key){
            return access_token = key;
        }
        /// <summary>
        /// get access token
        /// </summary>
        /// <returns></returns>
        public static string getAccessToken(){
            if (string.IsNullOrEmpty(access_token)){
                throw new ArgumentNullException("Access token is empty");
            }
            return access_token;
        }
        /// <summary>
        /// return the Base URL from API
        /// </summary>
        /// <returns></returns>
        public static string getBaseUrl(){
            return "https://api.sumup.com/v0.1/";
        }
    }
 }