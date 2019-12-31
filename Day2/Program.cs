using System;

namespace Day2
{
    class  Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("input.txt");
            Console.WriteLine($"Processing input: {input}");
            
            string[] string_arr = input.Split(","); 
            int[] arr = Array.ConvertAll(string_arr, int.Parse);

            int mem0;
          
            for (int i=0; i<100; i++ )
            {
                arr[1] = i;
            
                for (int j=0; j<100; j++ )
                {
                    arr[2] = j;
                    try
                    {
                        string output = IntcodeProcessor.ProcessIntcode(arr, out mem0);
                        if (mem0 == 19690720)
                        {
                            Console.WriteLine($"i: {i}");
                            Console.WriteLine($"j: {j}");
                        }
                    }
                    catch (System.ArgumentException e)
                    {
                        // Well that didn't work. 
                    }
                }
            }
        }
    }
    
    public class IntcodeProcessor
    {
        public static string ProcessIntcode(int[] memory)
        {
            int mem0;
            return ProcessIntcode(memory, out mem0);
        }
        public static string ProcessIntcode(int[] arg_memory, out int mem0)
        {
            int[] memory = new int[arg_memory.Length];
            Array.Copy(arg_memory, memory, arg_memory.Length);
            int instructionPointer = 0;
            while(true)
            {
                bool exiting = false;
                int opcode = memory[instructionPointer];
                switch (opcode)
                {
                    case 1:
                        // Addition
                        //Console.WriteLine($"Addition");
                        int addition_arg1_address  = memory[instructionPointer + 1];
                        int addition_arg1 = memory[addition_arg1_address];
                        int addition_arg2_address  = memory[instructionPointer + 2];
                        int addition_arg2 = memory[addition_arg2_address];
                        int addition_address = memory[instructionPointer + 3];
                        memory[addition_address] = addition_arg1 + addition_arg2;
                        instructionPointer += 4;
                        break;
                    case 2:
                        // Multiplication
                        //Console.WriteLine($"Multiplication");
                        int multiplication_arg1_address = memory[instructionPointer + 1];
                        int multiplication_arg1 = memory[multiplication_arg1_address];
                        int multiplication_arg2_address = memory[instructionPointer + 2];
                        int multiplication_arg2 = memory[multiplication_arg2_address];
                        int multiplication_address = memory[instructionPointer + 3];
                        memory[multiplication_address] = multiplication_arg1 * multiplication_arg2;
                        instructionPointer += 4;
                        break;
                    case 99:
                        // Exit
                        //Console.WriteLine($"Exit");
                        exiting = true;
                        break;
                    
                    default:
                        //Console.WriteLine($"ERROR");
                        throw new System.ArgumentException("Invalid opcode");
                }
                if (exiting)
                {
                    mem0 = memory[0];
                    return string.Join(",", memory);
                }
            }
        }
    }
}
