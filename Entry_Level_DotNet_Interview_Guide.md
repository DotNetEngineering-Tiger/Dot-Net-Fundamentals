# Entry-Level .NET Engineer Interview Guide

## Introduction
This guide is designed to help **entry-level .NET engineers** prepare for technical interviews. It covers **fundamental concepts, sample questions, coding problems, system design basics, behavioral questions, and best practices**.

---

## Table of Contents
- [Technical Concepts](#technical-concepts)
- [Common Interview Questions](#common-interview-questions)
- [Coding Problems](#coding-problems)
- [System Design Basics](#system-design-basics)
- [Behavioral Questions](#behavioral-questions)
- [Interview Tips](#interview-tips)
- [Reference Materials](#reference-materials)

---

## Technical Concepts

### 1. **C# Fundamentals**
- **Data Types**: `int`, `string`, `bool`, `float`, `double`, `decimal`.
- **Control Flow**: `if-else`, `switch`, `for`, `while`, `do-while` loops.
- **Methods**: `static`, instance methods, parameters (value vs reference type).
- **Exception Handling**: `try-catch-finally`, `throw`, `custom exceptions`.
- **Collections**: `Array`, `List<T>`, `Dictionary<K,V>`.

### 2. **OOP (Object-Oriented Programming)**
- **Encapsulation**: Protecting object states using `private`, `protected` access modifiers.
- **Abstraction**: Using interfaces (`IShape`) and abstract classes (`Shape`).
- **Inheritance**: `DerivedClass : BaseClass`.
- **Polymorphism**: Method Overloading vs Method Overriding.

### 3. **.NET Framework & .NET Core**
- Differences between **.NET Framework** and **.NET Core**.
- **Advantages of .NET Core** (Cross-platform, lightweight, modular).
- ASP.NET Core basics (`Startup.cs`, `Middleware`, `Configuration`).

### 4. **Web Development with ASP.NET Core**
- **MVC (Model-View-Controller)** pattern.
- **RESTful APIs** (`GET`, `POST`, `PUT`, `DELETE`).
- **Middleware and Filters**.
- **Authentication & Authorization**: Identity framework, JWT.

### 5. **Databases & ORM (Entity Framework Core)**
- **SQL Basics**: CRUD (`SELECT`, `INSERT`, `UPDATE`, `DELETE`).
- **LINQ (Language Integrated Query)**: `Where()`, `Select()`, `GroupBy()`.
- **Entity Framework Core (EF Core)**: Migrations, Lazy Loading.

### 6. **Version Control (Git)**
- Git Commands: `git clone`, `git commit -m "message"`, `git push`.
- Branching & Merging: `git checkout -b feature-branch`, `git merge`.

---

## Common Interview Questions

### **General C# Questions**
1. What is the difference between `ref` and `out` parameters?
2. Explain `readonly`, `const`, and `static`.
3. What are `sealed` classes in C#?
4. How does `async` and `await` work?
5. What is `Garbage Collection` in .NET?

### **.NET & ASP.NET Core Questions**
6. Explain `Dependency Injection (DI)`.
7. What is the role of `appsettings.json`?
8. How does middleware work in ASP.NET Core?
9. Difference between `IEnumerable`, `IQueryable`, and `List<T>`.
10. What is `Serilog` and why is it used?

### **Database & Entity Framework Questions**
11. Difference between `FirstOrDefault()` and `SingleOrDefault()`.
12. What are **EF Core Migrations**?
13. What is **Lazy Loading**?
14. How do you improve database performance?
15. SQL Server vs NoSQL databases?

---

## Coding Problems

### **1. Reverse a String**
```csharp
using System;

class Program {
    static void Main() {
        string input = "hello";
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}
```

### **2. Find the Largest Number in an Array**
```csharp
using System;
using System.Linq;

class Program {
    static void Main() {
        int[] numbers = {3, 5, 7, 2, 8};
        Console.WriteLine(numbers.Max());
    }
}
```

### **3. FizzBuzz Problem**
```csharp
using System;

class Program {
    static void Main() {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
}
```

---

## System Design Basics
1. Explain the **MVC architecture**.
2. How does **caching** improve performance?
3. What is **load balancing**, and why is it important?
4. How would you design a URL shortener?
5. Monolithic vs Microservices architecture?

---

## Behavioral Questions
1. Tell me about yourself.
2. Describe a time you faced a technical challenge.
3. How do you handle working under pressure?
4. Have you worked in a team? What was your role?
5. Where do you see yourself in 5 years?

---

## Interview Tips
- **Practice coding** on platforms like LeetCode, HackerRank.
- **Learn system design** basics.
- **Understand SQL queries** for database questions.
- **Be confident**, and explain your thought process clearly.
- **Review Git** and version control basics.

---

## Reference Materials
- [Microsoft Docs: C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [LeetCode (Coding Practice)](https://leetcode.com/)
- [System Design Basics](https://github.com/donnemartin/system-design-primer)

---

This guide should help you prepare for **entry-level .NET engineering interviews**. Good luck! 🚀
