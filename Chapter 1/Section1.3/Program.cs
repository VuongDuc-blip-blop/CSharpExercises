namespace Section1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Parentheses = Console.ReadLine();
            Dictionary<string, string> ParentheseRelation = new Dictionary<string, string>();
            ParentheseRelation.Add("{", "}");
            ParentheseRelation.Add("[", "]");
            ParentheseRelation.Add("(", ")");



            FixedCapacityStack<char> ParentheseStack = new FixedCapacityStack<char>();


            Console.WriteLine(ParentheseStack.isEmpty());
        }

        public bool AddParentheseToStack(FixedCapacityStack<string> Stack, Dictionary<string, string> Relation, string c)
        {
            if (Relation.ContainsKey(c))
            {
                Stack.Push(c);
                return true;
            }
            else if (Relation.ContainsValue(c))
            {
                if (Stack.isEmpty())
                {
                    return false;
                }
                Stack.Pop();
                return true;
            }
            else
            {
                Console.WriteLine("Error:Symbol missing from relation");
                return false;
            }
        }
    }

    //1.3.2 Give the output printed by java Stack for the input
    //it was - the best - of times - - - it was - the - -

    //solution: - - eht - saw ti - - - semit fo - tseb eht - saw ti

    //    1.3.3 Suppose that a client performs an intermixed sequence of(stack) push and pop
    // operations.The push operations put the integers 0 through 9 in order onto the stack;
    //    the pop operations print out the return values.Which of the following sequence(s)
    //could not occur?
    // a. 4 3 2 1 0 9 8 7 6 5: possible, push 0-4, pop 4-0, push 5-9, pop 9-5
    // b. 4 6 8 7 5 3 2 9 0 1: impossible, once 0 is popped, 1 must be popped before 
    //c. 2 5 6 7 4 8 9 3 1 0: possible, push 0-2, pop 2, push 3-7, pop 5-7, pop 4, push 8-9, pop 8-9, pop 3, pop 1-0
    // d. 4 3 2 1 0 5 6 7 8 9: possible, push 0-4, pop 4-0, push 5-9, pop 9-5
    // e. 1 2 3 4 5 6 9 8 7 0: possible, push 0-6, pop 1-6, push 7-9, pop 9-7, pop 0
    // f. 0 4 6 5 3 8 1 7 2 9: impossible, after popping 8, 7 must be popped before 1
    // g. 1 4 7 9 8 6 5 3 0 2: impossible, after popping 3, 0 must be popped before 2
    // h. 2 1 4 3 6 5 8 7 9 0: possible, push 0-2, pop 2-1, push 3-4, pop 4-3, push 5-6, pop 6-5, push 7-8, pop 8-7,push 9, pop 9, pop 0

    //1.3.5 What does the following code fragment print when N is 50? Give a high-level
    //description of what it does when presented with a positive integer N.
    // Stack<Integer> stack = new Stack<Integer>(); 
    //while (N > 0) 
    //{ 
    //}
    //stack.push(N % 2);
    //N = N / 2;
    //for (int d : stack) StdOut.print(d);
    //StdOut.println();
    //Answer: Prints the binary representation of N (110010 when N is 50).


    //     1.3.6 What does the following code fragment do to the queue q?
    // Stack<String> stack = new Stack<String>(); 
    //while (!q.isEmpty()) 
    //   stack.push(q.dequeue()); 
    //while (!stack.isEmpty()) 
    //   q.enqueue(stack.pop());
    //Answer: Reverses the order of the elements in queue q.
}
