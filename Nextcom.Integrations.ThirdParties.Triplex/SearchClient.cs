using Nextcom.Integrations.ThirdParties.Tripletex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nextcom.Integrations.ThirdParties.Tripletex
{
    public class SearchClient : BaseClient
    {
        public SearchClient(Credentials credentials) : base(credentials)
        {

        }

        public bool CheckAuthStatus()
        {
            return AuthenticateCredetials();
        }
    }
}
