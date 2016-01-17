# Telegram Bot
A simple implementation of Telegram Bot API in C# language.

# How to use

To have a functional bot just implement the ITelegramBotListener interface, nothing more.

## Example

```csharp
using TelegramBot.Model;

namespace TelegramBot.Example
{
    /// <summary>
    /// All you have to make to use this API, basically, is implement this interface.
    /// </summary>
    internal class SimpleExampleBot : ITelegramBotListener
    {
        /// <summary>
        /// Use this long value to keep last update id that was processed.
        /// </summary>
        public long intOffSet
        {
            get;
            set;
        }

        /// <summary>
        /// This is timeout used in long polling request to Telegram servers represented in seconds.
        /// <para>In this example we used five minutes timout between empty requests.</para>
        /// <para>
        /// This API sends one request and waits this period to see if a new update is sent to your
        /// bot. After, sends a new request for a new try.
        /// </para>
        /// </summary>
        public int intTimeOut
        {
            get
            {
                return (60 * 5);
            }
        }

        /// <summary>
        /// Token to identify and keep your bot safe.
        /// <para>Don't show it to anyone!</para>
        /// </summary>
        public string strBotToken
        {
            get
            {
                return "<your_bot_token_provide_by_telegram_father_bot>";
            }
        }

        /// <summary>
        /// This is your best friend to keep the things working! This method is called every time
        /// that your bot receives updates. Therefore, your logic starts here!
        /// <para>Don't forget keep the <see cref="intOffSet"/> refreshed at every processed updates.</para>
        /// </summary>
        /// <param name="arrObjUpdate"></param>
        public void onUpdate(Update[] arrObjUpdate)
        {
            // Your logic starts here.
            foreach (Update objUpdate in arrObjUpdate)
            {
                this.processUpdate(objUpdate);
            }
        }

        /// <summary>
        /// Here your console or Windows forms, or whatever project type, starts.
        /// </summary>
        private static void Main(string[] args)
        {
            // Tell to API where class implement the ITelegramBotListener interface.
            ServerBot.i.objITelegramBotListener = new SimpleExampleBot();

            // And finally, start the server to keep you in touch with bot updates.
            ServerBot.i.start();
        }

        private void processUpdate(Update objUpdate)
        {
            if (objUpdate.objMessage != null)
            {
                this.processUpdateMessage(objUpdate.objMessage);
            }
        }

        private void processUpdateMessage(Message objMessage)
        {
            // You can find all methods of the Telegram Bot API at TelegramServer.i instance, as
            // well as yours results.
            TelegramServer.i.sendMessage(objMessage.objChat.intId, "I'm in construction! See you later.");
        }
    }
}
```