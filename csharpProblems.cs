
     
using System;
using System.Text;
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


public class Solution {

    public int CountMaxOrSubsets(int[] nums) { 
        int max = 0;
        foreach(int item in nums)
        {
            max |= item;
        }
        
        return CalculateCounter(nums, 0, max, 0, 0); 
    }
  public int CalculateCounter(int[] nums, int idx, int max, int temp, int counter)
    {
        if(idx >= nums.Length)
        {
            if(temp == max){
                counter++;
            }

            return counter;
        }
        
        counter = CalculateCounter(nums, idx + 1, max, temp, counter);
        counter = CalculateCounter(nums, idx + 1, max, (temp | nums[idx]), counter);
        
        return counter;
    }


    public int MaximumSwap(int num) {
            
        int[] last = new int[10];
        char[] charArr = num.ToString().ToCharArray();
        for(int i = 0; i < charArr.Length; i++)
        {   Console.WriteLine("char Array with i *** " +charArr[i]);
            int a = charArr[i] - '0';
            Console.WriteLine("char Array with charArr[i] - 0 ****" +  a );
            last[charArr[i] - '0'] = i;
            Console.WriteLine("char Array last value *** "+   last[charArr[i] - '0']);
        }
        
        for(int i = 0; i < charArr.Length; i++)
        {       
            for(int j = 9; j > charArr[i] - '0'; j--)
            {
                if(last[j] > i)
                {
                    char tmp = charArr[i];
                    charArr[i] = charArr[last[j]];
                    charArr[last[j]] = tmp;
                    return Convert.ToInt32(new string(charArr));
                }
            }
        }
        
        return num; 
    }
public double myPow(double x, int n) {
      
     if(n<0) return 1/x * myPow(1/x, -(n+1));
        if(n==0) return 1;
        if(n==2) return x*x;
        if(n%2==0) return myPow( myPow(x, n/2), 2);
        else return x*myPow( myPow(x, n/2), 2);
    }

    public string LongestDiverseString(int a, int b, int c) {
        	var sb = new StringBuilder();
		var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
		if (a != 0) pq.Enqueue('a', a);
		if (b != 0) pq.Enqueue('b', b);
		if (c != 0) pq.Enqueue('c', c);
		
		while (pq.Count != 0)
		{
			pq.TryDequeue(out var currentChar, out var currentCount);
			
			if (sb.Length >= 2 && sb[sb.Length - 1] == sb[sb.Length - 2] && sb[sb.Length - 1] == currentChar)
			{
				if (!pq.TryDequeue(out var nextChar, out var nextCount))
					break;
				
				sb.Append(nextChar);
				nextCount--;
				if (nextCount != 0)
					pq.Enqueue(nextChar, nextCount);
			}
			else
			{
				currentCount--;
				sb.Append(currentChar);
			}

			if (currentCount != 0)
				pq.Enqueue(currentChar, currentCount);
		}

		return sb.ToString();
    }
}