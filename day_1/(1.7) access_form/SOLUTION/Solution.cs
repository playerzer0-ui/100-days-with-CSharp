internal class Solution{
    private static void main(string[] args){
        string name;
        int age;

        Console.WriteLine("Welcome to the access panel");
        Console.WriteLine("insert name: ");
        name = Console.ReadLine();
        Console.WriteLine("insert age");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("name: " + name);
        Console.WriteLine("age: " + age);
    }
}