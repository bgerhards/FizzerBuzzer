namespace FizzBuzz.Core;

public class FizzerBuzzer
{
    public string Evaluate(int number)
    {
        var response = CaptureFizz(number);
        response+=CaptureBuzz(number);

        return response == "" ? number.ToString() : response;
    }

    private string CaptureFizz(int number){
        return number % 3 == 0 ? "Fizz" : "";
    }
    private string CaptureBuzz(int number){
        return number % 5 == 0 ? "Buzz" : "";
    }
}
//hi👌😎