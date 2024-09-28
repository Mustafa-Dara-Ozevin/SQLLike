using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLLike
{
    internal class Interperter
    {
        List<char> _expression;

        public Interperter(string expression)
        {
            _expression = new List<char>(expression.ToLower());
        }

        bool interpetWord(Queue<char> word)
        {
            for (int i = 0; i < _expression.Count; i++)
            {
                switch (_expression[i])
                {
                    case '.':
                        if (word.Count == 0)
                            return false;
                        word.Dequeue();
                        break;
                    case '%':
                        if (i + 1 == _expression.Count)
                            return true;
                        i++;
                        while (word.Peek() != _expression[i])
                        {
                            word.Dequeue();
                            if (word.Count == 0)
                                return false;
                        }
                        word.Dequeue();
                        break;
                    case '[':
                        bool negative = false; 
                        bool range = false;
                        bool match = false;
                        Queue<char> letters = new Queue<char>();
                        while (_expression[i + 1] != ']')
                        {
                            i++;
                            if (_expression[i] == '^')
                            {
                                negative = true;
                            }
                            else
                            {
                                if (_expression[i] == '-')
                                    range = true;
                                else
                                    letters.Enqueue(_expression[i]);
                            }
                        }
                        if (range)
                        {
                            string regex = $"[{letters.Dequeue()}-{letters.Dequeue()}]";
                            if (Regex.IsMatch(word.Dequeue().ToString(), regex))
                            {
                                match = true;
                                break;
                            }
                        }
                        else
                        {
                            while (letters.Count > 0)
                            {
                                if (letters.Peek() == word.Peek())
                                {
                                    word.Dequeue();
                                    match = true;
                                    break;
                                }
                                letters.Dequeue();
                            }
                        }
                        if (!(match ^ negative))
                            return false;
                        break;
                    case ']':
                        break;
                    default:
                        if (_expression[i] != word.Dequeue())
                            return false;
                        break;
                }
            }
            if (word.Count != 0)
            {
                return false;
            }
            return true;
        }

        public List<bool> Interpert(List<string> valueList)
        {
            List<bool> result = new List<bool>();
            foreach (string value in valueList)
            {
                Queue<char> word = new Queue<char>(value.ToLower());
                result.Add(interpetWord(word));
            }
            return result;
        }
    }
}
