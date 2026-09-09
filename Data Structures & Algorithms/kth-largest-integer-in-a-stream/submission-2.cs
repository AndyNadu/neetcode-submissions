public class KthLargest {
    private readonly PriorityQueue<int, int> queue;
    private readonly int Target;

    public KthLargest(int k, int[] nums) {
        queue = new PriorityQueue<int, int>();
        Target = k;

        foreach (var num in nums) {
            if (queue.Count < Target) {
                queue.Enqueue(num, num);
                continue;
            }

            TryReplaceQueueElement(num);
        }
    }
    
    public int Add(int val) {
        TryReplaceQueueElement(val);

        return queue.Peek();
    }

    private void TryReplaceQueueElement(int val) {
        if (queue.Count < Target) {
            queue.Enqueue(val, val);
            return;
        }

        if (val > queue.Peek()) {
            queue.Dequeue();
            queue.Enqueue(val, val);
        }
    }
}