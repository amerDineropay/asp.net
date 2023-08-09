namespace dineropay
{
	public struct Authorization
	{
        public static readonly string url = "https://checkout.dineropay.com/api/v1/sessions";
        private string password;
        private string merchantKey;
        public string description;
        public double amt;
        public string orderId;
        public string? address;
        public string? reqToken;
        public string[]? cardToken;
        public string? sucess_url;
        public string? cancel_url;
        public bool? recurring_init;
        public string? scheduled_id;
        public Customer? customr;
    }
}

