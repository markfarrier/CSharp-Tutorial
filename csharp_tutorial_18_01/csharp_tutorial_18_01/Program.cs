// this tutorial section is on Common Patterns and Antipatterns
// I skipped past the Unit Test tutorial as it was built on the basis that Visual Studio used project.json files
// I have since discovered they have switched to .csproj / XML
// As a result, I'm not sure how to translate the necessary .json modifications the tutorial requires
// I will do a separate tutorial on unit tests.

// this first program in this tutorial section is demonstrating the Adapter design pattern

// this program assumes valid arguments in processpayment.  E.g. expiration must be in the dd/yy format

using System;


class Program
{
	static void Main()
	{
		IPaymentProcessorAdapter stwipe = new StwipeAdapter();
		if(!(stwipe.ProcessPayment("1234", "11111111111111", "04/05", Convert.ToDecimal(110.59))))
		{
			Console.WriteLine("Payment could not be processed");
		}

		IPaymentProcessorAdapter paySal = new PaySalAdapter();
		if(!(paySal.ProcessPayment("1234", "11111111111111", "04/05", Convert.ToDecimal(110.59))))
		{
			Console.WriteLine("Payment could not be processed");
		}

	}
}

