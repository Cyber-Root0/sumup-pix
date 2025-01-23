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
namespace SumUp.SDK.Client.Checkout
{
    public class CheckoutMap
    {
        public string checkout_reference { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string pay_to_email { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }
        public string transaction_code { get; set; }
        public string transaction_id { get; set; }
        public List<Transaction> transactions { get; set; }
    }
    public class Transaction
    {
        public string id { get; set; }
        public string transaction_code { get; set; }
        public string merchant_code { get; set; }
        public double amount { get; set; }
        public double vat_amount { get; set; }
        public double tip_amount { get; set; }
        public string currency { get; set; }
        public DateTime timestamp { get; set; }
        public string status { get; set; }
        public string payment_type { get; set; }
        public string entry_mode { get; set; }
        public int installments_count { get; set; }
        public string auth_code { get; set; }
        public int internal_id { get; set; }
    }


}