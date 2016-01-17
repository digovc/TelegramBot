using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TelegramBot.Model;

namespace TelegramBot
{
    internal class Response
    {
        private bool _booOk;
        private string _strDescription;
        private string _strJson;
        private string _strResult;

        public bool booOk
        {
            get
            {
                return _booOk;
            }

            set
            {
                _booOk = value;
            }
        }

        public string strDescription
        {
            get
            {
                return _strDescription;
            }

            set
            {
                _strDescription = value;
            }
        }

        public string strResult
        {
            get
            {
                return _strResult;
            }

            set
            {
                _strResult = value;
            }
        }

        private string strJson
        {
            get
            {
                return _strJson;
            }

            set
            {
                _strJson = value;

                this.refreshStrJson();
            }
        }

        internal Response(string strJson)
        {
            this.strJson = strJson;
        }

        public T[] getArrObjResult<T>() where T : ObjectBase
        {
            if (!this.booOk)
            {
                return null;
            }

            if (string.IsNullOrEmpty(this.strResult))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<T[]>(this.strResult);
        }

        public T getObjResult<T>() where T : ObjectBase
        {
            if (!this.booOk)
            {
                return null;
            }

            if (string.IsNullOrEmpty(this.strResult))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<T>(this.strResult);
        }

        internal bool validate()
        {
            return true; // TODO: Make sure that request have OK response.
        }

        private void clearValues()
        {
            this.booOk = false;
            this.strResult = null;
            this.strDescription = null;
        }

        private void refreshStrJson()
        {
            this.clearValues();

            if (string.IsNullOrEmpty(this.strJson))
            {
                return;
            }

            JObject objJObject = JObject.Parse(this.strJson);

            this.booOk = (objJObject["ok"] != null) ? objJObject["ok"].Value<bool>() : false;
            this.strDescription = (objJObject["description"] != null) ? objJObject["description"].Value<string>() : null;
            this.strResult = (objJObject["result"] != null) ? objJObject["result"].ToString() : null;
        }
    }
}