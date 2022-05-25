
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

### Chain Of Responsibilities
This pattern aims to create a chain in which it is possible to pass a calling, here the idea is create some methods (using the same idea of a linked list of C) where which item in the chain knows who is the next one to be called. The main idea is: each one of the methods will decide if it will process the request, if it decides that it won't, it passes the request for the next member in the chain.

The Case: For the following implementation imagine that you have a Loyalty program to an enterprise of rides (like uber) in which you give points according to the travel distance, the rules are the following:
- If the travel was larger than 5km you will give one point per km.
- If the travel was larger than 10km you will give two points per km.
- If the travel was larger than 20km you will give three points per km.

These points are not cumulative, it means, the program will apply only one of these rules for you, what fits better to the length of the travel, and the higher possible.

In this example we were able to do something magical using the minimal code for each scenario. We didn't pass the Five Km verification if it was Ten or Fifteen first. We throw way the complexity and verifications that could cost something to the processor. Take a look into ChainOfResponsabilities folder.


### Template Method
This pattern defines a way to reduce the code redundancy providing a Template path and delegating the core implementation to specialized classes that inherits a abstract class which the methods are used by the main code structure. Imagine that you have a default code behavior, for example a if, and you have a lot of cases to  check using the same structure, template method can help you to use OO to solve this problem.

The case: For the next scenario we’ll implement taxes over salaries, here in Brazil taxes are distributed by salary range, but the most important part is, there is rooftop on this range, it means if your salary is greater than R$ 4660 the tax will be the same if it goes higher. The idea is to implement these rules over two taxes that we pay in our salaries here in Brazil, INSS (12%) and IR (11%). We’ll not consider the others ranges, our goal is to calculate the right taxes taking care of the rooftop according the following infos:

 - INSS
 -- Regular: 12%
 -- Rooftop: 25%

- IR
-- Regular: 11%
-- Rooftop: 27%

Take a look inside the Template Method Folder.
