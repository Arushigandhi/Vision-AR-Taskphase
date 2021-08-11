public class QueueUsing2Stacks
{
    Stack stack1 = new Stack();
    Stack stack2 = new Stack();


    public void Enqueue(int elements)
    {

        for (int i = 0; i < stack1.Count; i++)
        {
            stack2.Push(stack1.Pop());
        }

        stack1.Push(data);

        for (int i = 0; i < stack2.Count; i++)
        {
            _stack1.Push(_stack2.Pop());
        }
    }

}