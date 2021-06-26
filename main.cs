 using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Enter salesperson's Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    var amount = Console.ReadLine();        
    int comm = Convert.ToInt32(amount);
    double x = 0.09;
    double y = comm;
    double commission = (200 + (x*y));       
      Console.WriteLine("Sales commission for " + name + " is $" + commission);
    

    
    if(comm <= 2999)
    {
      Console.WriteLine("Performance is poor");
    }
    else if (comm <= 4999)
    {
      Console.WriteLine("Performance is average");
    }
    else if (comm <= 9999)
    {
      Console.WriteLine("Performance is good");
    }
    else if (comm <= 14999)
    {
      Console.WriteLine("Performance is excellent");
    }
    else if (comm >= 15000)
    {
      Console.WriteLine("Performance is Outstanding");
    }
  //Wow, this was pretty difficult. I got a lot of the syntax wrong!!! =)!
  }
}