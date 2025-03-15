# C# Data Structures Reference Guide

## **1. Dictionary**
A `Dictionary<TKey, TValue>` is a collection of **key-value pairs** that allows fast lookups.

### **Usage Example**
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

        Console.WriteLine(students[1]); // Output: Alice

        if (students.ContainsKey(2))
        {
            Console.WriteLine("Student ID 2 exists.");
        }

        foreach (var kvp in students)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}
```
✔ **Fast lookups** using keys.  
✔ **Keys must be unique**.  
✔ **Order is not guaranteed**.  

---

## **2. Array**
An `Array` is a **fixed-size** collection of elements of the same type.

### **Usage Example**
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine(numbers[2]); // Output: 3

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"Array Length: {numbers.Length}");
    }
}
```
✔ **Fixed-size** (cannot be resized after creation).  
✔ **Fast access** by index.  
✔ **Stored in contiguous memory**, making it efficient.  

---

## **3. ArrayList**
An `ArrayList` is a **dynamic** array that can grow or shrink in size.

### **Usage Example**
```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 10, "Hello", 3.14 };
        list.Add(20);
        list.Add("World");

        list.Remove(10);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
```
✔ **Can store mixed data types** (not type-safe).  
✔ **Resizes automatically**.  
✔ **Less efficient than List<T>**.  

---

## **4. List<T>**
A `List<T>` is a **strongly-typed dynamic collection** that provides better performance than `ArrayList`.

### **Usage Example**
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Alice", "Bob" };
        names.Add("Charlie");
        names.Remove("Bob");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        if (names.Contains("Alice"))
        {
            Console.WriteLine("Alice is in the list.");
        }
    }
}
```
✔ **Type-safe** (only stores elements of type `T`).  
✔ **Resizable**.  
✔ **Supports LINQ queries**.  

---

## **5. HashSet<T>**
A `HashSet<T>` is a **collection of unique elements**, meaning duplicates are not allowed.

### **Usage Example**
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };
        numbers.Add(5);
        numbers.Add(2); // Will not be added (duplicate)

        numbers.Remove(3);

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
```
✔ **Does not allow duplicates**.  
✔ **Unordered**.  
✔ **Faster lookups than List<T>** for large datasets.  

---

# **Comparison Table**
| Collection | Key Feature | Duplicates Allowed? | Ordered? | Fast Lookup? |
|------------|------------|------------------|---------|-------------|
| **Dictionary<TKey, TValue>** | Key-value pairs | ❌ No | ❌ No | ✅ Yes (by key) |
| **Array** | Fixed size, fast access | ✅ Yes | ✅ Yes | ✅ Yes |
| **ArrayList** | Dynamic array, not type-safe | ✅ Yes | ✅ Yes | ❌ No (boxing/unboxing overhead) |
| **List<T>** | Dynamic, type-safe | ✅ Yes | ✅ Yes | ✅ Yes |
| **HashSet<T>** | Unique elements only | ❌ No | ❌ No | ✅ Yes |

---

This guide provides **clear explanations, examples, and comparisons** of C# collections. Let me know if you need more details! 🚀
