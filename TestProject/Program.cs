// ﻿// // // // Random dice = new Random();
// // // // // int roll = dice.Next();

// // // // int roll = dice.Next(1, 7);
// // // // Console.WriteLine(roll);


// // // // Console.WriteLine(dice.Next(1, 7));

// // // // int number = 7;
// // // // string text = "seven";

// // // // Console.WriteLine(number);
// // // // Console.WriteLine();
// // // // Console.WriteLine(text);

// // // Random dice = new Random();
// // // int roll1 = dice.Next();
// // // int roll2 = dice.Next(101);
// // // int roll3 = dice.Next(50, 101);

// // // Console.WriteLine($"First roll: {roll1}");
// // // Console.WriteLine($"Second roll: {roll2}");
// // // Console.WriteLine($"Third roll: {roll3}");

// // // initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;


// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
// decimal jeongScore = (decimal)jeongSum / currentAssignments;


// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);

// Console.WriteLine("Sophia: " + sophiaScore);
// Console.WriteLine("Nicolas: " + nicolasScore);
// Console.WriteLine("Zahirah: " + zahirahScore);
// Console.WriteLine("Jeong: " + jeongScore);

// Console.WriteLine("Sophia: " + sophiaScore + " A");
// Console.WriteLine("Nicolas: " + nicolasScore + " B");
// Console.WriteLine("Zahirah: " + zahirahScore + " B");
// Console.WriteLine("Jeong: " + jeongScore + " A");

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
// Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

// decimal sophieExamScore = 0;
// decimal andrewExamScore = 0;
// decimal emmaExamScore = 0;
// decimal loganExamScore = 0;



// Console.WriteLine("Student\t Exam Score\t Overall \n");
// Console.WriteLine("Sophia\t " + sophieExamScore + "\t");

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");
