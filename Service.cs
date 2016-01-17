using System;
using System.Threading;

namespace TelegramBot
{
    public abstract class Service
    {
        private Thread _objThread;

        protected Thread objThread
        {
            get
            {
                if (_objThread != null)
                {
                    return _objThread;
                }

                _objThread = new Thread(this.service);

                return _objThread;
            }
        }

        public void start()
        {
            this.objThread.Start();
        }

        protected abstract void service();
    }
}