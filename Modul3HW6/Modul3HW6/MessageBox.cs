using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW6
{
    internal class MessageBox
    {
        public MessageBox()
        {
            this.WindowClosedEvent += StateResult;
        }

        public delegate void WindowClosed(State state);
        public event WindowClosed WindowClosedEvent;
        public void StateResult(State state)
        {
            if (state == State.Cansel)
            {
                Console.WriteLine("Operation denied");
            }
            else
            {
                Console.WriteLine("Operation confirmed");
            }
        }

        public async Task Open()
        {
            Console.WriteLine("Window open");
            await Task.Delay(3000);
            Console.WriteLine("Window closed by user");
            await ResultInvoke();
        }

        public Task ResultInvoke()
        {
            var rand = new Random().Next(0, 2);
            if (rand == 0)
            {
                WindowClosedEvent.DynamicInvoke(State.Cansel);
            }
            else
            {
                WindowClosedEvent.DynamicInvoke(State.Ok);
            }

            return Task.CompletedTask;
        }
    }
}
