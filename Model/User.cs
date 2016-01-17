using Newtonsoft.Json;

namespace TelegramBot.Model
{
    public class User : ObjectBase
    {
        private int _intId;
        private string _strFirstName;
        private string _strLatName;
        private string _strUserName;

        [JsonProperty("id")]
        public int intId
        {
            get
            {
                return _intId;
            }

            set
            {
                _intId = value;
            }
        }

        [JsonProperty("first_name")]
        public string strFirstName
        {
            get
            {
                return _strFirstName;
            }

            set
            {
                _strFirstName = value;
            }
        }

        [JsonProperty("last_name")]
        public string strLatName
        {
            get
            {
                return _strLatName;
            }

            set
            {
                _strLatName = value;
            }
        }

        [JsonProperty("username")]
        public string strUserName
        {
            get
            {
                return _strUserName;
            }

            set
            {
                _strUserName = value;
            }
        }
    }
}