using System;

public class MemberNameNotFoundException : Exception
{
    public MemberNameNotFoundException(string memberName)
        : base($"Could not find member: {memberName}.")
    { }
}