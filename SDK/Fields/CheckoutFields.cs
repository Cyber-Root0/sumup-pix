namespace SumUp.SDK.Fields
{
    public class CheckoutFields
    {
        private string checkout_reference { get; set; }
        private float amount { get; set; }
        private string currency { get; set; }
        private string pay_to_email { get; set; }
        private string description { get; set; }
        public CheckoutFields setReference(string id)
        {
            this.checkout_reference = id;
            return this;
        }
        public CheckoutFields setAmount(float valor)
        {
            if (valor <= 0)
            {
                throw new Exception("The value don't can be negative");
            }
            this.amount = valor;
            return this;
        }
        public CheckoutFields setCurrency(string currency)
        {
            this.currency = currency;
            return this;
        }
        public CheckoutFields setPayerEmail(string email)
        {
            this.pay_to_email = email;
            return this;
        }
        public CheckoutFields setDescription(string description)
        {
            this.description = description;
            return this;
        }
        public object ToDTO()
        {
            return new
            {
                checkout_reference = this.checkout_reference,
                amount =this.amount,
                currency = this.currency,
                pay_to_email = this.pay_to_email,
                description = this.description
            };
        }
    }
    public class PaymentDTO
    {
        public string checkout_reference { get; set; }
        public float amount { get; set; }
        public string currency { get; set; }
        public string pay_to_email { get; set; }
        public string description { get; set; }
    }
}


