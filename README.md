# Telegram Bot
A simple implementation of Telegram Bot API in C# language.

# How to use

To have a functional bot just implement the ITelegramBotListener interface, nothing more.

## Example

```csharp
using TelegramBot;
using TelegramBot.Model;

namespace TelegramBot.Example
{
    /// <summary>
    /// All you have to make to use this API, basically, is implement this interface.
    /// </summary>
    internal class Example : ITelegramBotListener
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
        }

        /// <summary>
        /// Here your console or Windows forms, or whatever project type, starts.
        /// </summary>
        private static void Main(string[] args)
        {
            // Tell to API where class implement the ITelegramBotListener interface.
            ServerBot.i.objITelegramBotListener = new Example();

            // And finally, start the server to keep you in touch with bot updates.
            ServerBot.i.start();
        }
    }
}
```