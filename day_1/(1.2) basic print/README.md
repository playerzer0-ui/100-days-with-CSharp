# The Basic Output

Many years ago, people type commands in terminal to get certain results (to this day some still do)

Nowadays people just write one big file and tells the terminal to compile it and run it

In the previous lesson you saw the structure of C#, now try looking at:

```csharp
Console.WriteLine();
```

what this command does is it prints out whatever is inside the brackets. In this case it is "hello world"

so the output is:

```
hello world
```

another command to print out text is:

```
Console.Write();
```

This command works similar to WriteLine, except that it doesn't create a new line when printed, here is an example:

```csharp
Console.Write("this");
Console.Write("this");
Console.Write("this");
```

output
```
thisthisthis
```

while WriteLine does this instead:
```csharp
Console.WriteLine("this");
Console.WriteLine("this");
Console.WriteLine("this");
```

output
```
this
this
this
```

## What are those "" capsulating those text?

they are necessary for the text to be outputted, without them it will be an error

The source code is in Program.cs, if you want to look into it more.

There will be a programming exercise in the next folder, good luck