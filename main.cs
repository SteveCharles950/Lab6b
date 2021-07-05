using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int[] num = new int[10];
    int[] OddNum = new int[10];
    int[] EvenNum = new int[10];
    int j=0,k=0;
    for(int pos=0; pos < num.Length; pos++)
    {
      Console.WriteLine("Enter a number");
      num[pos] = Convert.ToInt32(Console.ReadLine());
    }

     for(int pos=0; pos < num.Length; pos++){
      if (num[pos] % 2 == 0)
      {
        
        EvenNum[j] = num[pos];
        j++;
      }
      else
      {
        
        OddNum[k]= num[pos];
        k++;
      }
    }
    
      Console.WriteLine ("Odd Numbers:");
     
       for(int pos=0; pos < OddNum.Length; pos++)
    {
      Array.Sort(OddNum);
      Array.Reverse(OddNum);
      Console.WriteLine(OddNum[pos]);
    }
    Console.WriteLine ("Even Numbers:");
       for(int pos=0; pos < EvenNum.Length; pos++)
    {
        Array.Sort(EvenNum);
        Console.WriteLine(EvenNum[pos]);
    }
    double sum1 = OddNum.Sum();
    double sum2 = EvenNum.Sum();
    Console.WriteLine("Sum of the odd numbers is " + sum1);
    Console.WriteLine("Sum of the even numbers is " + sum2);

      

  
  }
}