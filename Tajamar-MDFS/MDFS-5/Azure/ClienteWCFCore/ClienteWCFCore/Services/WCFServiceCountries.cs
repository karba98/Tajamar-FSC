using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceCountries;

namespace ClienteWCFCore.Services
{
    public class WCFServiceCountries
    {
        CountryInfoServiceSoapTypeClient client;
        public WCFServiceCountries ()
        {
            this.client = new CountryInfoServiceSoapTypeClient(
                CountryInfoServiceSoapTypeClient
                .EndpointConfiguration.CountryInfoServiceSoap12);
        }
        public async Task<tCountryInfo> GetCountryInfo(String isoname)
        {
            FullCountryInfoResponse response = 
                await this.client.FullCountryInfoAsync(isoname);
            tCountryInfo country = response.Body.FullCountryInfoResult;
            return country;
        }
       
    }
}
