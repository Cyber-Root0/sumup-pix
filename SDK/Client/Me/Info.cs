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
using SumUp.SDK;
using RestSharp;
namespace SumUp.SDK.Client.Me
{
    class Info : SumUpAbstract 
    {
        /// <summary>
        /// return all information from account
        /// </summary>
        /// <returns></returns>
         public InfoMap getAccountInformation(){
             return this.ExecuteGet<InfoMap>("me");
         }
    }
}