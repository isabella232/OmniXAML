namespace Glass
{
    using System;
    using System.Collections.Generic;

    public static class StackingLinkedListMixin
    {
        public static IEnumerable<T> TraverseBackwards<T>(this StackingLinkedList<T> sll) where T : class
        {
            LinkedListNode<T> node = sll.Current;

            while (node != null)
            {
                yield return node.Value;
                node = node.Previous;
            }
        }
    }
}