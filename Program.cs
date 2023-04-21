using olassessment;

namespace ConsoleApp1;

public class Program{
    public static void Main(string[] args){
        var q1 = new Question1();
        q1.EnterCredentials();
        Question2.DecimalToBinary();
        
        Question3.Calculate(1,1);
        Question3.Calculate(1,1,1);

    }
}


