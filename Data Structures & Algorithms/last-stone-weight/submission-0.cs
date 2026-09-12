public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();

        foreach (var stone in stones) {
            pq.Enqueue(stone, -stone);
        }

        while (pq.Count is > 1) {
            var firstStone = pq.Dequeue();
            var secondStone = pq.Dequeue();

            if (firstStone != secondStone) {
                pq.Enqueue(firstStone - secondStone, secondStone - firstStone);
            }
        }

        return pq.Count is 1
            ? pq.Dequeue()
            : 0;
    }
}