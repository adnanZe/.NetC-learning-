// // // // // // // // // // // See https://aka.ms/new-console-template for more information
// // // // // // // // // // Console.WriteLine("This is the first line.");
// // // // // // // // // // Console.Write("This ");
// // // // // // // // // // Console.Write("is the ");
// // // // // // // // // // Console.WriteLine("second line.");
// // // // // // // // // // Console.WriteLine(123);
// // // // // // // // // // Console.WriteLine(0.25F);
// // // // // // // // // // Console.WriteLine(12.39816m);
// // // // // // // // // // Console.WriteLine(true);
// // // // // // // // // // Console.WriteLine(false);

// // // // // // // // // // Console.WriteLine("123");
// // // // // // // // // // Console.WriteLine(123);

// // // // // // // // // // Console.WriteLine("true");
// // // // // // // // // // Console.WriteLine(true);

// // // // // // // // // // string firstName;
// // // // // // // // // // int age;
// // // // // // // // // // char dadFirstLetter;
// // // // // // // // // // decimal salary;
// // // // // // // // // // bool isEmployed;

// // // // // // // // // // firstName = "Joe";
// // // // // // // // // // age = 20;
// // // // // // // // // // dadFirstLetter = 'B';
// // // // // // // // // // salary = 5555555.5m;
// // // // // // // // // // isEmployed = true;

// // // // // // // // // // Console.WriteLine("My first name is " + firstName + " age is " + age + " dad first letter " + dadFirstLetter + " salary is " + salary + " " + " is hired ? " + isEmployed);

// // // // // // // // // // firstName = "Bill";

// // // // // // // // // // Console.WriteLine("My first name is " + firstName);

// // // // // // // // // string firstName;
// // // // // // // // // firstName = "Bob";
// // // // // // // // // Console.WriteLine(firstName);
// // // // // // // // // firstName = "Liem";
// // // // // // // // // Console.WriteLine(firstName);
// // // // // // // // // firstName = "Isabella";
// // // // // // // // // Console.WriteLine(firstName);
// // // // // // // // // firstName = "Yasmin";
// // // // // // // // // Console.WriteLine(firstName);

// // // // // // // // // string lastName = "Black";
// // // // // // // // // Console.WriteLine(lastName);

// // // // // // // // var message;
// // // // // // // // message = "Hello world!";

// // // // // // // // Console.WriteLine(message);

// // // // // // // // message = 10.703m;

// // // // // // // // Console.WriteLine(message);
// // // // // // // // Console.WriteLine(message);

// // // // // // // string name = "Bob";
// // // // // // // int numberMessage = 3;
// // // // // // // double temperature = 34.4;

// // // // // // // Console.WriteLine("Hello " + name + "! You have " + numberMessage + " in your inbox. The temperature is " + temperature + " celsius.");

// // // // // // // Console.WriteLine(34.40M);

// // // // // // // decimal x = 12.3m;

// // // // // // Console.WriteLine("Hello\nWorld!");
// // // // // // Console.WriteLine("Hello\tWorld!");

// // // // // // Console.WriteLine("Hello \"World\"!");

// // // // // // Console.WriteLine("c:\\source\\repos");

// // // // // Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
// // // // // Console.WriteLine("Invoice: 1021\t\tComplete!");
// // // // // Console.WriteLine("Invoice: 1022\t\tComplete!");
// // // // // Console.WriteLine("\nOutput Directory:\t");

// // // // // // Console.WriteLine(@"    c:\source\repos
// // // // // //         (this is where your code goes)");

// // // // // Console.WriteLine(@"c:\invoices");

// // // // // // Kon'nichiwa World
// // // // // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// // // // // // To generate Japanese invoices:
// // // // // // Nihon no seikyū-sho o seisei suru ni wa:
// // // // // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // // // // // User command to run an application
// // // // // Console.WriteLine(@"c:\invoices\app.exe -j");

// // // // // string firstName = "Bob";
// // // // // string greeting  = "Hello";
// // // // // // string message = greeting + " " + firstName + "!";
// // // // // string message = $"{greeting} {firstName}!";
// // // // // string message2 = $"Hello {firstName}!";
// // // // // Console.WriteLine(message); 
// // // // // Console.WriteLine(message2);

// // // // // int version = 11;
// // // // // string updateText = "Update to Windows";
// // // // // string message = $"{updateText} {version}";
// // // // // Console.WriteLine(message);
// // // // // Console.WriteLine($"{updateText} {version}!");
// // // // // string projectName = "First-Project";
// // // // // Console.WriteLine($@"C:\Output\{projectName}\Data");

// // // // // string projectName = "ACME";

// // // // // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// // // // // Console.WriteLine($@"View English output:
// // // // //     c:\Exercise\{projectName}\data.txt

// // // // // {russianMessage}:
// // // // //     c:\Exercise\{projectName}\ru-Ru\data.txt
// // // // // ");

// // // // // string projectName = "ACME";
// // // // // string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
// // // // // Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

// // // // // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// // // // // string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
// // // // // Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

// // // // // int firstNumber = 12;
// // // // // int secondNumber = 7;
// // // // // Console.WriteLine(firstNumber + secondNumber);

// // // // // string firstName = "Bob";
// // // // // int widgetsSold = 7;
// // // // // Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// // // // // string firstName = "Bob";
// // // // // int widgetsSold = 7;
// // // // // Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// // // // // string firstName = "Bob";
// // // // // int widgetsSold = 7;
// // // // // Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// // // // // int sum = 7 + 5;
// // // // // int difference = 7 - 5;
// // // // // int product = 7 * 5;
// // // // // int quotient = 7 / 5;

// // // // // Console.WriteLine("Sum: " + sum);
// // // // // Console.WriteLine("Difference: " + difference);
// // // // // Console.WriteLine("Product: " + product);
// // // // // Console.WriteLine("Quotient: " + quotient);

// // // // // decimal decimalQuotient = 7.0m / 5;
// // // // // decimal decimalQuotient = 7 / 5.0m;
// // // // // decimal decimalQuotient = 7.0m / 5.0m;
// // // // // int decimalQuotient = 7 / 5.0m;
// // // // // int decimalQuotient = 7.0m / 5;
// // // // // int decimalQuotient = 7.0m / 5.0m;
// // // // // decimal decimalQuotient = 7 / 5;
// // // // // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// // // // // int first = 7;
// // // // // int second = 5;
// // // // // decimal quotient = first / (decimal)second;
// // // // // Console.WriteLine(quotient);

// // // // // Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// // // // // Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// // // // // int value1 = 3 + 4 * 5;
// // // // // int value2 = (3 + 4) * 5;
// // // // // Console.WriteLine(value1);
// // // // // Console.WriteLine(value2);

// // // // // int value = 0;     // value is now 0.
// // // // // value = value + 5; // value is now 5.
// // // // // value += 5;        // value is now 10.

// // // // // int value = 0;     // value is now 0.
// // // // // value = value + 1; // value is now 1.
// // // // // value++;           // value is now 2.

// // // // int value = 1;

// // // // value = value + 1;
// // // // Console.WriteLine("First increment: " + value);

// // // // value += 1;
// // // // Console.WriteLine("Second increment: " + value);

// // // // value++;
// // // // Console.WriteLine("Third increment: " + value);

// // // // value = value - 1;
// // // // Console.WriteLine("First decrement: " + value);

// // // // value -= 1;
// // // // Console.WriteLine("Second decrement: " + value);

// // // // value--;
// // // // Console.WriteLine("Third decrement: " + value);

// // // // int value = 1;
// // // // value++;
// // // // Console.WriteLine("First: " + value);
// // // // Console.WriteLine($"Second: {value++}");
// // // // Console.WriteLine("Third: " + value);
// // // // Console.WriteLine("Fourth: " + (++value));

// // // // int fahrenheit = 94;
// // // // decimal celsius = (fahrenheit - 32) * (5m / 9);

// // // // Console.Write($"The temperature is {celsius} Celsius \n");


// // // // string message = "The quick brown fox jumps over the lazy dog.";
// // // // bool result = message.Contains("dog");
// // // // Console.WriteLine(result);

// // // // if (message.Contains("fox"))
// // // // {
// // // //     Console.WriteLine("What does the fox say?");
// // // // }

// // // Random dice = new Random();

// // // int roll1 = dice.Next(1, 7);
// // // int roll2 = dice.Next(1, 7);
// // // int roll3 = dice.Next(1, 7);

// // // int total = roll1 + roll2 + roll3;

// // // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// // // {
// // //     if ((roll1 == roll2) && (roll2 == roll3))
// // //     {
// // //         Console.WriteLine("You rolled triples!  +6 bonus to total!");
// // //         total += 6;
// // //     }
// // //     else
// // //     {
// // //         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
// // //         total += 2;
// // //     }
// // // }

// // // if (total >= 16)
// // // {
// // //     Console.WriteLine("You win a new car!");
// // // }
// // // else if (total >= 10)
// // // {
// // //     Console.WriteLine("You win a new laptop!");
// // // }
// // // else if (total == 7)
// // // {
// // //     Console.WriteLine("You win a trip for two!");
// // // }
// // // else
// // // {
// // //     Console.WriteLine("You win a kitten!");
// // // }

// // Random random = new();
// // int daysUntilExpiration = random.Next(12);
// // int discountPercentage = 0;

// // if (daysUntilExpiration == 0)
// // {
// //     Console.WriteLine("Your subscription has expired.");
// // }
// // else if (daysUntilExpiration == 1)
// // {
// //     discountPercentage = 20;
// //     Console.WriteLine($"Your subscription expires in a day!\nRenew now and save {discountPercentage}%!");
// // }
// // else if (daysUntilExpiration <= 5)
// // {
// //     discountPercentage = 10;
// //     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
// // }
// // else if (daysUntilExpiration <= 10)
// // {
// //     Console.WriteLine("Your subscription will expire soon. Renew now!");
// // }


// // #pragma warning disable IDE0300 // Simplify collection initialization
// // string[] fraudulentOrderIDs = new string[3];
// // #pragma warning restore IDE0300 // Simplify collection initialization

// // fraudulentOrderIDs[0] = "A123";
// // fraudulentOrderIDs[1] = "B456";
// // fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";
// #pragma warning disable IDE0300 // Simplify collection initialization
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
// #pragma warning restore IDE0300 // Simplify collection initialization

// Console.WriteLine(fraudulentOrderIDs.Length);

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = ["Bob", "Conrad", "Grant"];
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");