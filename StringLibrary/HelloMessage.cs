using System;

namespace StringLibrary
{
    public class HelloMessage
    {
        public string GetHelloMessage(string username)
        {
            return DateTime.Now.ToString() + " Hello " + username;    
        }

    }
}
