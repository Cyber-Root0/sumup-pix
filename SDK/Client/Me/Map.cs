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
namespace SumUp.SDK.Client.Me
{
    public class Account
    {
        public string username { get; set; }
        public string type { get; set; }
    }
    public class Address
    {
        public int id { get; set; }
        public string address_line1 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string post_code { get; set; }
        public string landline { get; set; }
    }

    public class DoingBusinessAs
    {
        public string business_name { get; set; }
        public string email { get; set; }
        public string dynamic_descriptor { get; set; }
        public Address address { get; set; }
    }

    public class LegalType
    {
        public int id { get; set; }
        public string full_description { get; set; }
        public string description { get; set; }
        public bool sole_trader { get; set; }
    }

    public class MerchantProfile
    {
        public int id { get; set; }
        public string merchant_code { get; set; }
        public string company_name { get; set; }
        public LegalType legal_type { get; set; }
        public string merchant_category_code { get; set; }
        public string mobile_phone { get; set; }
        public Address address { get; set; }
        public List<object> business_owners { get; set; }
        public DoingBusinessAs doing_business_as { get; set; }
        public string locale { get; set; }
        public bool complete { get; set; }
        public bool extdev { get; set; }
        public string country { get; set; }
        public string default_currency { get; set; }
        public bool third_party_business_details_confirmed { get; set; }
    }
    public class PersonalProfile
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string date_of_birth { get; set; }
        public string national_id { get; set; }
        public Address address { get; set; }
        public bool complete { get; set; }
        public bool address_declaration { get; set; }
    }
    public class InfoMap
    {
        public int id { get; set; }
        public Account account { get; set; }
        public PersonalProfile personal_profile { get; set; }
        public MerchantProfile merchant_profile { get; set; }
        public List<object> requirements { get; set; }
        public List<object> verifications { get; set; }
        public bool is_migrated_payleven_br { get; set; }
        public DateTime signup_time { get; set; }
        public bool details_submitted { get; set; }
    }
}