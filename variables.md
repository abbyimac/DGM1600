A variable is a reference to a value in your code that can change. It is beneficial because you can change the value in one place and it will change throughout the code wherever it is used. It can also give hints to what the meaning of the value is, because you can give it a descriptive name.

For example, you can represent an age in your code like this:
``` csharp
int age = 18
```
You can represent a name like this:
``` csharp
string name = "Abby"
```

You can set a variable like this to change what happens in your code:
``` csharp
bool isAwesome = true
if (isAwesome) {
    giveHighFive();
}
```

You can set a variable and use the value in the variable later in the program.
```csharp
string name = "Bob";
print ("Hello " + name + "!");
```

You can set the variable to a different value. For example:

```csharp
int age = 15;
age = age + 1;
```