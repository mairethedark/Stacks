using System;
using System.Collections;

namespace StackApp1
{
    class stack
    {
        static Stack s = new Stack();

        static public int push(string text)
        {
            if (text.Trim() != string.Empty)
            {
                s.Push(text);
                return 1;
            }
            else
                return 0;
        }

        static public string top()
        {
            string text;
            try
            {
                text = s.Peek().ToString();
                return text;
            }
            catch
            {
                return null;
            }

        }
        static public string pop()
        {
            string result;
            try
            {
                result = s.Pop().ToString();

                return result;
            }
            catch
            {
                return null;
            }
        }

}
    }

