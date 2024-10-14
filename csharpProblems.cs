public class csharpProblems {
    public int CountPrimes(int n) {
      int count = 0; 
		int[] a = new int[n];

		for (int i = 2; i < n; i++) {
			if (a[i] != -1) {
				count++;

				for (int j = 2 * i; j < n; j += i) {
					a[j] = -1;
				}
			}
		}

		return count;
    }


    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        char[] source = s.ToCharArray();
        char[] target = t.ToCharArray();
        
        Array.Sort(source);
        Array.Sort(target);
        
        for(int i=0;i <=  source.Length-1 ;i++){
            if(source[i] != target[i]){
                return false;
            }
        }
        return true;
    }

        public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        
        while(current != null){
            ListNode temp = current.next;
            current.next = prev;
            
            prev = current;
            current = temp;
        }
        return prev;
    }

    public long maxKelements(int[] nums, int k) {
        var pq = new PriorityQueue<long, long>();
        long score = 0;
   
        for (var i = 0; i < nums.Length; i++){
             Console.WriteLine("First Param "+(long)nums[i] + " Second Param " +(long)-1 * nums[i]);
            pq.Enqueue((long)nums[i], (long)-1 * nums[i]);
        }
       
        
        while (k != 0 && pq.Count > 0)
        {             Console.WriteLine("K value " + k + " PQ Count " + pq.Count);
            var m = pq.Dequeue();
            Console.WriteLine("M value " +m);
            score += m;

            // Add number again
            pq.Enqueue((long)Math.Ceiling((decimal)m / 3), -1 * (long)Math.Ceiling((decimal)m / 3));
            k--;
        }
        
        return score;
    }

    
}


public class ListNode {
    public int val;
     public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }

 public class MyStack {
    Queue<int> queue = null;
    public MyStack() {
        queue = new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    public int Pop() {
        if (Empty())
            return Int32.MinValue;
        
        Queue<int> current = new Queue<int>();
        
        while (queue.Count > 1)
            current.Enqueue(queue.Dequeue());
        
        int top = queue.Dequeue();
        
        queue = current;
        
        return top;
    }
    
    public int Top() {
        if (Empty())
            return Int32.MinValue;
        
        Queue<int> current = new Queue<int>();
        
        while (queue.Count > 1)
            current.Enqueue(queue.Dequeue());
        
        int top = queue.Dequeue();
        
        current.Enqueue(top);
        queue = current;
        
        return top;
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
 }


     

