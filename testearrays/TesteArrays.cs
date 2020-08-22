using System;

namespace testearrays
 {
   public class TesteArrays 
    {
        public static int Fator ( params int[] numbers) 
        {
            int sum = 1;
            for (int i = 1; i < numbers.Length; i++) 
            {
                sum *= numbers[i];
            }

            return sum;
        }

    }
}