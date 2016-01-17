using System;
using System.Net.Http;
using TelegramBot.Model;

namespace TelegramBot
{
    public class TelegramServer
    {
        internal const string STR_FNC_NAME_SET_WEB_HOOK = "setWebhook";
        private static TelegramServer _i;

        public static TelegramServer i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new TelegramServer();

                return _i;
            }
        }

        private TelegramServer()
        {
        }

        public Update[] getUpdates(long intOffSet = 0, int intLimite = 100, int intTimeOut = 0)
        {
            Request objRequest = new Request(Request.EnmFunction.GET_UPDATES);

            objRequest.enmFunction = Request.EnmFunction.GET_UPDATES;

            objRequest.addValue("offset", intOffSet);
            objRequest.addValue("limit", intLimite);
            objRequest.addValue("timeout", intTimeOut);

            Response objResponse = this.sentRequest(objRequest);

            if (objResponse == null)
            {
                return null;
            }

            if (!objResponse.validate())
            {
                return null;
            }

            return objResponse.getArrObjResult<Update>();
        }

        public Message sendMessage(int intChatId, string strText)
        {
            if (intChatId < 1)
            {
                return null;
            }

            if (string.IsNullOrEmpty(strText))
            {
                return null;
            }

            Request objRequest = new Request(Request.EnmFunction.SEND_MESSAGE);

            objRequest.addValue("chat_id", intChatId);
            objRequest.addValue("text", strText);

            Response objResponse = this.sentRequest(objRequest);

            if (objResponse == null)
            {
                return null;
            }

            return objResponse.getObjResult<Message>();
        }

        internal Response sentRequest(Request objRequest)
        {
            Console.WriteLine("Starting sending POST data to Telegram server.");

            if (objRequest == null)
            {
                Console.WriteLine("Invalid request.");
                return null;
            }

            HttpClient objHttpClient = new HttpClient();

            HttpResponseMessage objResponse = objHttpClient.PostAsync(this.getUrlBot(objRequest.strFunctionName), objRequest.frm).Result;

            objHttpClient.Dispose();

            string strResult = objResponse.Content.ReadAsStringAsync().Result;

            return new Response(strResult);
        }

        private string getUrlBot(string strFunctionName = "getMe")
        {
            string urlResult = "https://api.telegram.org/bot_bot_token/_function_name";

            urlResult = urlResult.Replace("_bot_token", ServerBot.i.objITelegramBotListener.strBotToken);
            urlResult = urlResult.Replace("_function_name", strFunctionName);

            return urlResult;
        }
    }
}