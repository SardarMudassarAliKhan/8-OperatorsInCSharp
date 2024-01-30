class Program
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 20;
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = b / a;
        int remainder = b % a;

        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
        Console.WriteLine();

        // Assignment Operators
        int x = 10;
        x += 5;
        Console.WriteLine("Assignment Operator:");
        Console.WriteLine($"x after operation: {x}");
        Console.WriteLine();

        // Comparison Operators
        int p = 10;
        int q = 20;
        bool isEqual = (p == q);
        bool isNotEqual = (p != q);
        bool isGreaterThan = (p > q);
        bool isLessThan = (p < q);

        Console.WriteLine("Comparison Operators:");
        Console.WriteLine($"p == q: {isEqual}");
        Console.WriteLine($"p != q: {isNotEqual}");
        Console.WriteLine($"p > q: {isGreaterThan}");
        Console.WriteLine($"p < q: {isLessThan}");
        Console.WriteLine();

        // Logical Operators
        bool condition1 = true;
        bool condition2 = false;
        bool resultAnd = condition1 && condition2;
        bool resultOr = condition1 || condition2;
        bool resultNot = !condition1;

        Console.WriteLine("Logical Operators:");
        Console.WriteLine($"condition1 && condition2: {resultAnd}");
        Console.WriteLine($"condition1 || condition2: {resultOr}");
        Console.WriteLine($"!condition1: {resultNot}");
        Console.WriteLine();

        // Bitwise Operators
        int num1 = 5; // Binary: 101
        int num2 = 3; // Binary: 011
        int resultAndBitwise = num1 & num2; // Bitwise AND (result: 1)
        int resultOrBitwise = num1 | num2; // Bitwise OR (result: 7)
        int resultXorBitwise = num1 ^ num2; // Bitwise XOR (result: 6)

        Console.WriteLine("Bitwise Operators:");
        Console.WriteLine($"num1 & num2: {resultAndBitwise}");
        Console.WriteLine($"num1 | num2: {resultOrBitwise}");
        Console.WriteLine($"num1 ^ num2: {resultXorBitwise}");
        Console.WriteLine();

        // Conditional Operator (Ternary Operator)
        int age = 20;
        string message = (age >= 18) ? "Adult" : "Minor";

        Console.WriteLine("Conditional Operator:");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine();

        // Increment and Decrement Operators
        int count = 0;
        count++; // Increment
        count--; // Decrement

        Console.WriteLine("Increment and Decrement Operators:");
        Console.WriteLine($"Count after increment and decrement: {count}");
    }
}
