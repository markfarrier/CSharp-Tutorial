using System;

public class MyMissingTokenException : ArgumentException
{
    public MyMissingTokenException()
        : base("Missing token exception: Token is either null or empty.")
    {
        Console.WriteLine("Missing token exception: Token is either null or empty.");
    }
    public MyMissingTokenException(Exception innerException)
    : base("Missing token exception: Token is either null or empty.", innerException)
    {
        Console.WriteLine("Missing token exception: Token is either null or empty.");
    }
}