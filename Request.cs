using System.IO;
using System.Net.Http;

namespace TelegramBot
{
    internal class Request
    {
        internal enum EnmFunction
        {
            GET_ME,
            GET_UPDATES,
            SEND_MESSAGE,
            SET_WEB_HOOK,
        }

        private EnmFunction _enmFuncao = EnmFunction.GET_ME;
        private MultipartFormDataContent _frm;
        private string _strFunctionName = "getMe";

        public EnmFunction enmFunction
        {
            get
            {
                return _enmFuncao;
            }

            set
            {
                _enmFuncao = value;
            }
        }

        internal MultipartFormDataContent frm
        {
            get
            {
                if (_frm != null)
                {
                    return _frm;
                }

                _frm = new MultipartFormDataContent();

                return _frm;
            }
        }

        internal string strFunctionName
        {
            get
            {
                _strFunctionName = this.getStrFunctionName();

                return _strFunctionName;
            }
        }

        public Request(EnmFunction enmFunction)
        {
            this.enmFunction = enmFunction;
        }

        internal void addFile(string strName, string strPath)
        {
            if (string.IsNullOrEmpty(strPath))
            {
                return;
            }

            if (!File.Exists(strPath))
            {
                return;
            }

            byte[] arrBteFile = File.ReadAllBytes(strPath);

            this.frm.Add(new ByteArrayContent(arrBteFile, 0, arrBteFile.Length), strName, strName);
        }

        internal void addValue(string strName, string strValue)
        {
            if (string.IsNullOrEmpty(strName))
            {
                return;
            }

            if (string.IsNullOrEmpty(strValue))
            {
                return;
            }

            this.frm.Add(new StringContent(strValue), strName);
        }

        internal void addValue(string strName, long intValue)
        {
            this.addValue(strName, intValue.ToString());
        }

        private string getStrFunctionName()
        {
            switch (this.enmFunction)
            {
                case EnmFunction.GET_UPDATES:
                    return "getUpdates";

                case EnmFunction.SEND_MESSAGE:
                    return "sendMessage";

                case EnmFunction.SET_WEB_HOOK:
                    return "setWebhook";

                default:
                    return "getMe";
            }
        }
    }
}