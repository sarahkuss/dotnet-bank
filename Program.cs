
// Console.WriteLine("Hello, World!");

// int age = 27;
// string name = "Sarah";
// bool isHere = true;
// //int salary = 22000;
// double raise = 22000.01; //double lets you use decimals

// Console.WriteLine($"Hi, {name}. Your age is {age} and is here? {isHere}");
// Console.WriteLine($"And you make ${raise} a year");
try
{
savingsAccount myAccount = new savingsAccount(300);
// myAccount.balance = 300;

Console.WriteLine($"Your balance is ${myAccount.getBalance()}");
} catch (Exception ex) {
  Console.WriteLine($"We got an error: {ex.Message}");
}