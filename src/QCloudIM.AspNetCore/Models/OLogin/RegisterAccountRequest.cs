 

using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.OLogin
{

    public class RegisterAccountRequest : QCloudIMRequest
    {

        private string _identifier;
        private int _identifierType;
        private string _password;

        public RegisterAccountRequest()
        {
        }

        [JsonProperty("Identifier")]
        public virtual string Identifier
        {
            get
            {
                return _identifier;
            }
            set
            {
                this._identifier = value;
            }
        }

        [JsonProperty("IdentifierType")]
        public virtual int IdentifierType
        {
            get
            {
                return _identifierType;
            }
            set
            {
                this._identifierType = value;
            }
        }

        [JsonProperty("Password")]
        public virtual string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
            }
        }

    }

}