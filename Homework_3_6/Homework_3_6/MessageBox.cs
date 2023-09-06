using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_6
{
    internal sealed class MessageBox
    {
        public Action<State> WindowIsClosed;

        public MessageBox() 
        {
        }

        public async void Open()
        {
            Console.WriteLine("The window is open");
            await Task.Delay(3000);
            Console.WriteLine("The window was closed by the user");
            WindowIsClosed.Invoke(GetRandomState());
        }

        private State GetRandomState()
        {
            Random rnd = new Random();
            return (State)rnd.Next(0, 2);
        }
    }
}
