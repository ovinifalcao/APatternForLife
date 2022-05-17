# Welcome to A Pattern for Life!
This is a project that aims to be a "Cheat Sheet" for some Design Patterns. Its name is a joke with the ideia f partner for a life time, like a romance between the coder and its code. This repo aims to be a easy way for me to find this patterns and keep this in mind, along the examples I'll use a lot of code samples from the community, but all the rights are reserved to the original authors.


### Strategy Pattern
*Based on Alura Approach*

This pattern helps us to switch between codes without using a Switch Statement or a Chain of If Statements. Its useful because it maintains the SOLID principle Open/Closed well defined, Avoid use of IFs Statements on our code, and divide the concerns in different classes.

The Case: You have to implement a code that support a lot multiple kinds of Taxes, some of then already exists, but others are under discussion on the government, so you need to keep your code open to new Taxes, but you have to do your job now, right? One of the (poor, but) possible solutions to this case is:

    public double CalculateTax(double totalValue, string taxName)
    {  
	    if(taxName == "ICMS")
	    {
		    return totalValue * 0.13;
	    }
		 else if(taxName == "IPI")
	    {
		    return totalValue * 0.068;
	    }
	    return 0;
	}
	     
Look into the StrategyPattern folder to see the suggested response.