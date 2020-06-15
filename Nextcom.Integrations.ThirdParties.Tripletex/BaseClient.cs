using Nextcom.Integrations.TestConsole;
using System;

namespace Nextcom.Integrations.ThirdParties.Tripletex
{
    public abstract class BaseClient
    {
        protected AuthResponse AuthResponse { get; private set; }

        protected readonly string _baseUrl = @"https://api.tripletex.io/v2/";
        //protected readonly string _baseUrl = @"https://api.tripletex.io/v2/";

        private readonly Credentials _credentials;

        public BaseClient(Credentials credentials)
        {
            _credentials = credentials;
        }
    }
}
