using Newtonsoft.Json;

namespace TelegramBot.Model
{
    public class Chat : ObjectBase
    {
        public enum EnmType
        {
            CHANNEL,
            GROUP,
            NONE,
            PRIVATE,
            SUPERGROUP,
        }

        private EnmType _enmType = EnmType.NONE;
        private int _intId;
        private string _strFirstName;
        private string _strLastName;
        private string _strTitle;
        private string _strType;
        private string _strUserName;

        public EnmType enmType
        {
            get
            {
                if (_enmType != EnmType.NONE)
                {
                    return _enmType;
                }

                _enmType = this.getEnmType();

                return _enmType;
            }
        }

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
        public string strLastName
        {
            get
            {
                return _strLastName;
            }

            set
            {
                _strLastName = value;
            }
        }

        [JsonProperty("title")]
        public string strTitle
        {
            get
            {
                return _strTitle;
            }

            set
            {
                _strTitle = value;
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

        [JsonProperty("type")]
        private string strType
        {
            get
            {
                return _strType;
            }

            set
            {
                _strType = value;
            }
        }

        private EnmType getEnmType()
        {
            switch (this.strType)
            {
                case "channel":
                    return EnmType.CHANNEL;

                case "group":
                    return EnmType.GROUP;

                case "supergroup":
                    return EnmType.SUPERGROUP;

                default:
                    return EnmType.PRIVATE;
            }
        }
    }
}