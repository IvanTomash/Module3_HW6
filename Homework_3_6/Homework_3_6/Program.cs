using System;

namespace Homework_3_6
{
    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            TaskCompletionSource<State> taskCompletionSource = new TaskCompletionSource<State>();
            MessageBox mb = new MessageBox();
            mb.WindowIsClosed = taskCompletionSource.SetResult;
            mb.Open();
            RespondWindowClosed(taskCompletionSource.Task.Result);
        }

        private static void RespondWindowClosed(State state)
        {
            switch (state)
            {
                case State.Ok:
                    Console.WriteLine("the operation has been confirmed");
                    break;
                case State.Cancel:
                    Console.WriteLine("the operation was rejected");
                    break;
                default:
                    Console.WriteLine("Not appropriate state");
                    break;
            }
        }
    }
}



