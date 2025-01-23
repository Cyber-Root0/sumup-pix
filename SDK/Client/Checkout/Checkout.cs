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
using SumUp.SDK.Fields;
 using VarDump;
namespace SumUp.SDK.Client.Checkout
{
    class Checkout : SumUpAbstract 
    {
        private string id { get; set; }
        /// <summary>
        /// Create a new checkout
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
         public CheckoutMap Create(CheckoutFields fields){
             CheckoutMap response = this.ExecutePost<CheckoutMap, object>("checkouts",fields.ToDTO());
             this.setCheckoutId(response.id);
             return response;
         }
         /// <summary>
         /// create and update to process pix payment
         /// </summary>
         /// <param name="fields"></param>
         /// <returns></returns>
         public PixArtefact CreateAndProcessPix(CheckoutFields fields){
            CheckoutMap response = this.Create(fields);
            string checkoutID = response.id;
            this.setCheckoutId(checkoutID);
            PixArtefact Pix = this.ExecutePut<PixArtefact, object>("checkouts/"+checkoutID, this.getObjectToPixProcess());
            return Pix;
         }
         /// <summary>
         /// set the checkoutID
         /// </summary>
         /// <param name="id"></param>
        public void setCheckoutId(string id){
            this.id = id;
        }
        /// <summary>
        /// get id of checkout
        /// </summary>
        /// <returns></returns>
        public string getCheckoutId(){
            return this.id;
        }
        /// <summary>
        /// get complete object to process the pix payment
        /// </summary>
        /// <returns></returns>
        private object getObjectToPixProcess(){
            return new
            {
                payment_type = this.getCheckoutId()
            };
        }
        /// <summary>
        /// get all available payments on checkout
        /// </summary>
        /// <returns></returns>
        public AvailablePayments getAvailablePayments(){
            return this.ExecuteGet<AvailablePayments>("checkouts/"+this.getCheckoutId()+"/payment-methods");
        }
    }
}