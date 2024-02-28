// // // // // // // // See https://aka.ms/new-console-template for more information
// // // // // // // Console.WriteLine("This is the first line.");
// // // // // // // Console.Write("This ");
// // // // // // // Console.Write("is the ");
// // // // // // // Console.WriteLine("second line.");
// // // // // // // Console.WriteLine(123);
// // // // // // // Console.WriteLine(0.25F);
// // // // // // // Console.WriteLine(12.39816m);
// // // // // // // Console.WriteLine(true);
// // // // // // // Console.WriteLine(false);

// // // // // // // Console.WriteLine("123");
// // // // // // // Console.WriteLine(123);

// // // // // // // Console.WriteLine("true");
// // // // // // // Console.WriteLine(true);

// // // // // // // string firstName;
// // // // // // // int age;
// // // // // // // char dadFirstLetter;
// // // // // // // decimal salary;
// // // // // // // bool isEmployed;

// // // // // // // firstName = "Joe";
// // // // // // // age = 20;
// // // // // // // dadFirstLetter = 'B';
// // // // // // // salary = 5555555.5m;
// // // // // // // isEmployed = true;

// // // // // // // Console.WriteLine("My first name is " + firstName + " age is " + age + " dad first letter " + dadFirstLetter + " salary is " + salary + " " + " is hired ? " + isEmployed);

// // // // // // // firstName = "Bill";

// // // // // // // Console.WriteLine("My first name is " + firstName);

// // // // // // string firstName;
// // // // // // firstName = "Bob";
// // // // // // Console.WriteLine(firstName);
// // // // // // firstName = "Liem";
// // // // // // Console.WriteLine(firstName);
// // // // // // firstName = "Isabella";
// // // // // // Console.WriteLine(firstName);
// // // // // // firstName = "Yasmin";
// // // // // // Console.WriteLine(firstName);

// // // // // // string lastName = "Black";
// // // // // // Console.WriteLine(lastName);

// // // // // var message;
// // // // // message = "Hello world!";

// // // // // Console.WriteLine(message);

// // // // // message = 10.703m;

// // // // // Console.WriteLine(message);
// // // // // Console.WriteLine(message);

// // // // string name = "Bob";
// // // // int numberMessage = 3;
// // // // double temperature = 34.4;

// // // // Console.WriteLine("Hello " + name + "! You have " + numberMessage + " in your inbox. The temperature is " + temperature + " celsius.");

// // // // Console.WriteLine(34.40M);

// // // // decimal x = 12.3m;

// // // Console.WriteLine("Hello\nWorld!");
// // // Console.WriteLine("Hello\tWorld!");

// // // Console.WriteLine("Hello \"World\"!");

// // // Console.WriteLine("c:\\source\\repos");

// // Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
// // Console.WriteLine("Invoice: 1021\t\tComplete!");
// // Console.WriteLine("Invoice: 1022\t\tComplete!");
// // Console.WriteLine("\nOutput Directory:\t");

// // // Console.WriteLine(@"    c:\source\repos
// // //         (this is where your code goes)");

// // Console.WriteLine(@"c:\invoices");

// // // Kon'nichiwa World
// // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// // // To generate Japanese invoices:
// // // Nihon no seikyū-sho o seisei suru ni wa:
// // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // // User command to run an application
// // Console.WriteLine(@"c:\invoices\app.exe -j");

// // string firstName = "Bob";
// // string greeting  = "Hello";
// // // string message = greeting + " " + firstName + "!";
// // string message = $"{greeting} {firstName}!";
// // string message2 = $"Hello {firstName}!";
// // Console.WriteLine(message); 
// // Console.WriteLine(message2);

// // int version = 11;
// // string updateText = "Update to Windows";
// // string message = $"{updateText} {version}";
// // Console.WriteLine(message);
// // Console.WriteLine($"{updateText} {version}!");
// // string projectName = "First-Project";
// // Console.WriteLine($@"C:\Output\{projectName}\Data");

// // string projectName = "ACME";

// // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// // Console.WriteLine($@"View English output:
// //     c:\Exercise\{projectName}\data.txt

// // {russianMessage}:
// //     c:\Exercise\{projectName}\ru-Ru\data.txt
// // ");

// // string projectName = "ACME";
// // string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
// // Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

// // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// // string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
// // Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

// // int firstNumber = 12;
// // int secondNumber = 7;
// // Console.WriteLine(firstNumber + secondNumber);

// // string firstName = "Bob";
// // int widgetsSold = 7;
// // Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// // string firstName = "Bob";
// // int widgetsSold = 7;
// // Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// // string firstName = "Bob";
// // int widgetsSold = 7;
// // Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// // int sum = 7 + 5;
// // int difference = 7 - 5;
// // int product = 7 * 5;
// // int quotient = 7 / 5;

// // Console.WriteLine("Sum: " + sum);
// // Console.WriteLine("Difference: " + difference);
// // Console.WriteLine("Product: " + product);
// // Console.WriteLine("Quotient: " + quotient);

// // decimal decimalQuotient = 7.0m / 5;
// // decimal decimalQuotient = 7 / 5.0m;
// // decimal decimalQuotient = 7.0m / 5.0m;
// // int decimalQuotient = 7 / 5.0m;
// // int decimalQuotient = 7.0m / 5;
// // int decimalQuotient = 7.0m / 5.0m;
// // decimal decimalQuotient = 7 / 5;
// // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// // int first = 7;
// // int second = 5;
// // decimal quotient = first / (decimal)second;
// // Console.WriteLine(quotient);

// // Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// // Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// // int value1 = 3 + 4 * 5;
// // int value2 = (3 + 4) * 5;
// // Console.WriteLine(value1);
// // Console.WriteLine(value2);

// // int value = 0;     // value is now 0.
// // value = value + 5; // value is now 5.
// // value += 5;        // value is now 10.

// // int value = 0;     // value is now 0.
// // value = value + 1; // value is now 1.
// // value++;           // value is now 2.

// int value = 1;

// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value++;
// Console.WriteLine("Third increment: " + value);

// value = value - 1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));