public class KthLargest {
    private readonly PriorityQueue<int, int> queue;

    public KthLargest(int k, int[] nums) {
        queue = new PriorityQueue<int, int>();

        foreach (var num in nums) {
            if (queue.Count < k) {
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
        if (queue.Count is 0) {
            queue.Enqueue(val, val);
            return;
        }

        if (val > queue.Peek()) {
            queue.Dequeue();
            queue.Enqueue(val, val);
        }
    }
}