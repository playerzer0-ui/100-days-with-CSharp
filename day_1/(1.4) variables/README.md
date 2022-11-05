# Variables (the labels)

variables act like containers, for specific items

it's like putting pencils in a pencilcase, labeling it pencilcase

or putting tomatoes in a can, labeling it tomato can

variables are exactly that, store certain values and giving them names, and you just need to call them to execute.

and variables have certain types you need to know, since there is common sense to not put a banana in a pencil case or put a pencil in the fridge (you can but you shouldn't)

## string variable

this type stores strings, which is basically words or text, recall the Console.WriteLine previously, remember how you should add "" around the text otherwise an error will occur? that is a string.

example:

```csharp
string x = "hello";
Console.WriteLine("hi" + x);
```

output:
```
hello
```

## integer variable

this type only stores numbers, it ranges from negatives to positives, no decimals allowed, you don't need "" around it

```csharp
int x = 5;
Console.WriteLine("this number is " + x);
```

output:
```
5
```

they could be used like how everyday people use math.

```csharp
int x = 5;
int y = 3;
Console.WriteLine(x + y);
```

output:
```
8
```

## double variable

this type is like integer, but is able to store decimals as well, if you wonder why some people still use integer, it's probably they want to conserve space or prove a point that this is an integer / double.

```csharp
double x = 2.324432;
Console.WriteLine(x);
```

output:
```
2.324432
```

## boolean variable

a special type of variable, only stores true or false, like a switch, useful for certain situations we might discuss in later days (notice how there isn't "" around it, that's because true and false are not strings, they are some kind of fixed boolean values)

```csharp
boolean x = true;
boolean y = false;
Console.WriteLine(x);
Console.WriteLine(y);
```

output:
```
true
false
```

there are more variable types out there, but this alone should get you started since they are the more popular types used.

## override values and changing

you can store a variable's value inside another variable (or override) like this:

```csharp
string x = "hello";
string y = x;

x = "xxxxxx";

Console.WriteLine(x);
Console.WriteLine(y);
```

output:
```
xxxxxx
hello
```

notice how x changes value and y gets the previous value of x before it changes

## notice: there can only be one

all labels are unique, there can only be one of each, here is an example:

```csharp
//this is no no
string x = "hi";
string x = "hello";

//but this is fine, different type
int z = 0;
string z = "wdwd";
```

this one will result in error. Try it and see for yourself, print any of them.

## set up a variable with no value

you can initialize a variable with no value. There's no harm in preparing them.

```csharp
//set them up beforehand
string x;
int a;
int b;

//then insert values
x = "www";
a = 10;
b = 23;
```

## more ways of displaying variables (concatenate)

you can combine things together in a sentence with "+" (excluding numbers because it will just add them up if no string is present)
```csharp
string name = "max";
int age = 10;
Console.WriteLine("this is " + name);
Console.WriteLine("he is " + age + " years old")
```

output:
```
this is max
he is 10 years old
```

