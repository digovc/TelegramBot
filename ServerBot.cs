using System;
using TelegramBot.Model;

namespace TelegramBot
{
    public class ServerBot : Service
    {
        private static ServerBot _i;

        private bool _isRunning;
        private ITelegramBotListener _objITelegramBotListener;

        public static ServerBot i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ServerBot();

                return _i;
            }
        }

        public ITelegramBotListener objITelegramBotListener
        {
            get
            {
                return _objITelegramBotListener;
            }

            set
            {
                _objITelegramBotListener = value;
            }
        }

        protected virtual bool isRunning
        {
            get
            {
                return _isRunning;
            }

            set
            {
                _isRunning = value;
            }
        }

        private ServerBot()
        {
        }

        internal void processRequest(string strMessage)
        {
        }

        protected override void service()
        {
            if (!this.validate())
            {
                return;
            }

            //this.initializeBot();
            this.initializeServer();
        }

        private void getUpdates()
        {
            Update[] arrObjUpdate = TelegramServer.i.getUpdates(this.objITelegramBotListener.intOffSet, 100, this.objITelegramBotListener.intTimeOut);

            if (arrObjUpdate == null)
            {
                return;
            }

            if (arrObjUpdate.Length < 1)
            {
                return;
            }

            this.objITelegramBotListener.onUpdate(arrObjUpdate);
        }

        private void initializeBot()
        {
            Console.WriteLine("Starting the bot configurations.");

            Request objRequest = new Request(Request.EnmFunction.SET_WEB_HOOK);

            objRequest.enmFunction = Request.EnmFunction.SET_WEB_HOOK;

            objRequest.addValue("url", string.Empty);

            Response objResponse = TelegramServer.i.sentRequest(objRequest);

            if (!this.initializeBotValidate(objResponse.strResult))
            {
                Console.WriteLine("Error on configure this bot.");
                return;
            }
        }

        private bool initializeBotValidate(string strResult)
        {
            // TODO: Make this validation.
            return true;
        }

        private void initializeServer()
        {
            this.isRunning = true;

            Console.WriteLine("Starting the server.");

            this.serverLoop();
        }

        private void serverLoop()
        {
            while (this.isRunning)
            {
                this.getUpdates();
            }
        }

        private bool validate()
        {
            Console.WriteLine("Validating the values to start the bot.");

            if (this.objITelegramBotListener == null)
            {
                Console.WriteLine("Invalid objITelegramBotListener.");
                return false;
            }

            return true;
        }
    }
}