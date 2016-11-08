using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.Codility
{
    public class Class3
    {
        public class MyStack
        {
            private Stack<int> _myStack;

            public MyStack()
            {
                _myStack = new Stack<int>();
            }
            public void Flush()
            {
                _myStack.Clear();
            }
            public int Count
            {
                get {
                    if(_myStack != null) {
                        return _myStack.Count;
                    } else {
                        return 0;
                    }
                }
            }
            public void Push(int element)
            {
                _myStack.Push(element);
            }
            public int Pop()
            {
                if(Count == 0) {
                    return -1;
                } else {
                    return _myStack.Pop();
                }
            }
        }


        private const int MAX = 4096;
        private MyStack _stack;
        public Class3()
        {
            _stack = new MyStack();
        }
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            _stack.Flush();
            for(var i = 0 ; i < S.Length ; i++) {

                if(ISDigital(S[i])) {
                    _stack.Push(S[i]-'0');
                } else {
                    var front = _stack.Pop();
                    var back = _stack.Pop();

                    // stack is empty
                    if(front < 0 || back < 0) {
                        return -1;
                    }

                    int result = Operator(S[i],front, back);

                    if(ISOverflow(result)) {
                        return -1;
                    } else {
                        _stack.Push(result);
                    }
                }
            }
            return _stack.Pop();
        }



        private bool ISDigital(char ch)
        {
            return char.IsDigit(ch);
        }
        

        private int Operator(char ch, int front, int back)
        {
            if(ISAdd(ch)) {
                return front + back;
            } else if(ISMultiple(ch)) {
                return front * back;
            } else {
                return -1;
            }
        }

        private bool ISAdd(char ch)
        {
            return ch == '+';
        }

        private bool ISMultiple(char ch)
        {
            return ch == '*';
        }

        private bool ISOverflow(int number)
        {
            return (number > MAX) || number <0;
        }
    }
}
