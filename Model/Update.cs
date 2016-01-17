using Newtonsoft.Json;

namespace TelegramBot.Model
{
    public class Update : ObjectBase
    {
        private int _intId;
        private ChosenInlineResult _objChosenInlineResult;
        private InlineQuery _objInlineQuery;
        private Message _objMessage;

        [JsonProperty("update_id")]
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

        [JsonProperty("chosen_inline_result")]
        public ChosenInlineResult objChosenInlineResult
        {
            get
            {
                return _objChosenInlineResult;
            }

            set
            {
                _objChosenInlineResult = value;
            }
        }

        [JsonProperty("inline_query")]
        public InlineQuery objInlineQuery
        {
            get
            {
                return _objInlineQuery;
            }

            set
            {
                _objInlineQuery = value;
            }
        }

        [JsonProperty("message")]
        public Message objMessage
        {
            get
            {
                return _objMessage;
            }

            set
            {
                _objMessage = value;
            }
        }
    }
}