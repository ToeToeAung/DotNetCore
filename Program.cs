// See https://aka.ms/new-console-template for more information



        int[][] intervals = [[5,10],[6,8],[1,5],[2,3],[1,10]];
        
        var max = intervals.Max(x => x[1]);
        Console.WriteLine("Max "+ max);
        var freq = new int[max + 2];
        foreach (var interval in intervals) {
            freq[interval[0]]++;
          //  Console.WriteLine("freq[interval[0]] "+ freq[interval[0]]);
           // Console.WriteLine("interval "+ interval[0]);
            // Console.WriteLine("freq[interval[0]] "+ freq[interval[0]]);
        //     freq[interval[0]]++;
            //  Console.WriteLine("freq[interval[0]] "+ freq[interval[1]]);
             freq[interval[1] + 1]--;
        }
        int sum = 0, result = 0;
        for (int i = 0; i < freq.Length; i++) {
            sum += freq[i];
            result = Math.Max(result, sum);
        }
    

    Console.WriteLine("Hello, World!" +result);