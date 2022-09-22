/*A fibonacci number is the sum of the two previous numbers. Here, we define variables for the 
first and second number.*/
int RecursiveFibonacci(int first, int second, int count)
{

    int nextFibo = first + second;
    //The count is decreased by 1 for each calculation
    count--;
    /*Writes result for each calculation. Not necessary for the code to work, but allows us 
    to see what's happening behind the scenes. The delay is for dramatic effect.*/
    Console.WriteLine("Count: " + count + " | Result: " + second);
    Thread.Sleep(400);

    //If the count is 0, the sequence has been completed
    if(count == 0) {
        return(nextFibo);
        
    
    //If not, we calculate the next number in the sequence 
    }else{
        return RecursiveFibonacci(second, nextFibo, count);
    }
}

/*Defines the variables for the recursive fibonacci. The first two variables are the first two numbers
of the sequence; the last variable is the fibonacci number we want to find. 
If we write 5, five calculations will be performed before the fibonacci number is returned.
*/
int lastFibo = RecursiveFibonacci(1,1,5);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nThe final fibonaccci number was " + lastFibo);
Console.ReadLine(); 