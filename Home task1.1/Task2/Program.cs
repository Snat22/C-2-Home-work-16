
        int count = 0;
        string input;
        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "end")
            {
                break;
            }
            count++;
        }

        Console.WriteLine($"Count: {count}");
 
