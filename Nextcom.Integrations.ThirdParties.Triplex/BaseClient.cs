using Nextcom.Integrations.TestConsole;
using RestSharp;
using System;

namespace Nextcom.Integrations.ThirdParties.Tripletex
{
    public abstract class BaseClient
    {
        protected AuthResponse AuthResponse { get; private set; }

        protected readonly string _baseUrl = @"https://api.tripletex.io/v2/";
        protected readonly string _apiAuthEndpoint = @"https://api.tripletex.io/v2/token/session:create?";

        private readonly Credentials _credentials;

        public BaseClient(Credentials credentials)
        {
            _credentials = credentials;
        }

        protected bool Authenticated
        {
            get
            {
                if (!string.IsNullOrEmpty(AuthResponse?.Token))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        protected bool AuthenticateCredetials()
        {
            if (!Authenticated)
            {
                try
                {
                    var authResponse = GetAuthResponse(_credentials);
                    AuthResponse = authResponse;
                    return Authenticated;
                }
                catch
                {
                    return Authenticated;
                }
            }
            else return Authenticated;
        }
        private AuthResponse GetAuthResponse(Credentials credentials)
        {
            var client = new RestClient(_apiAuthEndpoint);
            var request = new RestRequest();

            request.AddHeader("accept", "application/json");
            request.AddHeader("Cookie", "JSESSIONID=DA71F395C0C2EF00451FFF8B9516B953");
            request.AddParameter("consumerToken", credentials.ConsumerToken);
            request.AddParameter("employeeToken", credentials.EmployeeToken);
            request.AddParameter("expirationDate", credentials.ExpirationDate);

            var response = client.Put<AuthResponse>(request);

            return response.Data;
        }
    }
}
