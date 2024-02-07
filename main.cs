using System;

class MainClass 
{
  
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Hello World");
  }
  
 
  
 public static string Input(string text, string option1, string option2) 
  {
    bool valid;
    string response;

    do  
    {
      Console.WriteLine("\r\n" + text + " (" + option1 + ", " + option2 +"): ");
      response = Console.ReadLine (). ToLower();
      valid = response.Equals(option1.ToLower()) || response.Equals(option2.ToLower());

      if (!valid)
        Console.WriteLine("That is not a valid response.");
    } while(!valid);
    
    return response;
  

  string response = Input("Try to (G)rab the bar? or (F)all?", "G", "F");
          if (response.Equals(g))
          {
            Print("You grip the bar but it is slippery and your hands slide off and you continue to fall.");
            Print(" ");
          }
          else
          {
            Print("You continue plummeting towards the ground.");
            Print(" ");
          }
 }
}