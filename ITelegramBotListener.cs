using TelegramBot.Model;

namespace TelegramBot
{
    /// <summary>
    /// To use this API, just implement this interface.
    /// </summary>
    public interface ITelegramBotListener
    {
        long intOffSet
        {
            get;
        }

        int intTimeOut
        {
            get;
        }

        string strBotToken
        {
            get;
        }

        void onUpdate(Update[] arrObjUpdate);
    }
}