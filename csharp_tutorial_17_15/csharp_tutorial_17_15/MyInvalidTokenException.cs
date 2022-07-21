using System;

public class MyInvalidTokenException : ArgumentException
{
    public MyInvalidTokenException()
    : base($"Invalid token exception: Token exceeds the maximum number of characters.")
    {
        Console.WriteLine($"Invalid token exception: Token exceeds the maximum number of characters.");
    }
    public MyInvalidTokenException(string token)
        : base($"Invalid token exception: Token {token} exceeds the maximum number of characters.")
    {
        Console.WriteLine($"Invalid token exception: Token {token} exceeds the maximum number of characters.");
    }
    public MyInvalidTokenException(string token, Exception innerException)
   : base($"Invalid token exception: Token {token} exceeds the maximum number of characters.", innerException)
    {
        Console.WriteLine($"Invalid token exception: Token {token} exceeds the maximum number of characters.");
    }
}