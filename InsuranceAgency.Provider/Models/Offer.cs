namespace InsuranceAgency.Provider.Models
{

    // {"data":
    //{"companyName":"Acıbadem Sigorta","logo":"https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/acibadem-sigorta.png",
    //"description":"45ZN447 için verdiğimiz tekliftir.","amount":6398,"plate":"45ZN447"},
    //"errors":null}

    public class Offer
    {
        public Data data { get; set; }

        public string errors { get; set; }
    }

    public class Data
    {
        public string companyName { get; set; }

        public string logo { get; set; }

        public string description { get; set; }

        public decimal amount { get; set; }

        public string plate { get; set; }
    }
}
