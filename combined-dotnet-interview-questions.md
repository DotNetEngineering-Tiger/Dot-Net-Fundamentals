# .NET Entry-Level Engineer Interview Questions

## Object-Oriented Programming (OOP)

### 1. What are the four pillars of OOP?
**Answer:** The four pillars of Object-Oriented Programming are:
- **Encapsulation:** Wrapping data and methods that operate on that data within a single unit (class)
- **Abstraction:** Hiding implementation details and showing only functionality to the user
- **Inheritance:** The ability of a class to inherit properties and methods from a parent class
- **Polymorphism:** The ability of objects to take different forms depending on the context

**Example:** 
```csharp
// Encapsulation
public class BankAccount
{
    private decimal balance; // Data is private (encapsulated)
    
    public void Deposit(decimal amount) // Public method to access the data
    {
        if (amount > 0)
            balance += amount;
    }
    
    public decimal GetBalance()
    {
        return balance;
    }
}
```

### 2. What is the difference between an abstract class and an interface?
**Answer:** 
- **Abstract Class:** Can have implementations for some methods and require derived classes to implement others; can have fields/state; a class can inherit from only one abstract class
- **Interface:** Contains only method signatures, properties, events, and indexers without implementation; a class can implement multiple interfaces

**Example:**
```csharp
// Abstract class
public abstract class Shape
{
    public abstract double CalculateArea(); // Must be implemented by derived classes
    
    public void DisplayType() // Implemented in base class
    {
        Console.WriteLine("This is a shape");
    }
}

// Interface
public interface IDrawable
{
    void Draw(); // Just a signature, no implementation
}

// Class implementing both
public class Circle : Shape, IDrawable
{
    private double radius;
    
    public Circle(double r)
    {
        radius = r;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
```

### 3. What is method overloading and method overriding?
**Answer:**
- **Method Overloading:** Creating multiple methods with the same name but different parameters in the same class
- **Method Overriding:** Redefining a method in a derived class that already exists in the base class with the same signature

**Example:**
```csharp
public class Calculator
{
    // Method overloading
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public double Add(double a, double b)
    {
        return a + b;
    }
}

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    // Method overriding
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
```

### 4. What is the difference between a class and an object?
**Answer:**
- **Class:** A blueprint or template that defines the properties and behaviors of a type
- **Object:** An instance of a class that occupies memory and has actual values

**Example:**
```csharp
// Class definition (blueprint)
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public void Drive()
    {
        Console.WriteLine($"Driving the {Year} {Make} {Model}");
    }
}

// Creating objects (instances)
Car car1 = new Car { Make = "Toyota", Model = "Corolla", Year = 2022 };
Car car2 = new Car { Make = "Honda", Model = "Civic", Year = 2023 };
```

### 5. Explain access modifiers in C#.
**Answer:** Access modifiers control the accessibility of classes, methods, and other members. The main access modifiers in C# are:
- **public:** Accessible from anywhere
- **private:** Accessible only within the class
- **protected:** Accessible within the class and all derived classes
- **internal:** Accessible within the same assembly
- **protected internal:** Accessible within the same assembly or derived classes
- **private protected:** Accessible by derived classes within the same assembly

**Example:**
```csharp
public class Person
{
    public string Name { get; set; }     // Accessible from anywhere
    private int age;                     // Only accessible within this class
    protected string SSN { get; set; }   // Accessible in this class and derived classes
    internal string Address { get; set; } // Accessible within the same assembly
}
```

### 6. What is the difference between a value type and a reference type?
**Answer:**
- **Value Types:** Store their data directly and are allocated on the stack (struct, enum, primitive types like int, float, etc.)
- **Reference Types:** Store a reference to their data, which is allocated on the heap (class, interface, delegate, string, array)

**Example:**
```csharp
// Value type example
int number = 10;
int anotherNumber = number; // Creates a copy
anotherNumber = 20; // number is still 10

// Reference type example
List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = list1; // Both variables reference the same object
list2.Add(4); // Both list1 and list2 now contain [1, 2, 3, 4]
```

### 7. What are constructors in C#?
**Answer:** Constructors are special methods used to initialize objects. They have the same name as the class and don't have return types. Constructor types include:
- Default constructor (no parameters)
- Parameterized constructor
- Copy constructor
- Static constructor
- Private constructor

**Example:**
```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    // Default constructor
    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }
    
    // Parameterized constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    // Copy constructor
    public Student(Student otherStudent)
    {
        Name = otherStudent.Name;
        Age = otherStudent.Age;
    }
    
    // Static constructor - called once before any instance is created
    static Student()
    {
        Console.WriteLine("Student class initialized");
    }
}
```

### 8. What is the 'this' keyword used for in C#?
**Answer:** The 'this' keyword is used to:
- Refer to the current instance of the class
- Differentiate between instance variables and parameters with the same name
- Call another constructor in the same class (constructor chaining)

**Example:**
```csharp
public class Person
{
    private string name;
    private int age;
    
    public Person(string name)
    {
        this.name = name; // Differentiating between parameter and instance variable
    }
    
    public Person(string name, int age) : this(name) // Constructor chaining
    {
        this.age = age;
    }
    
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {this.name} and I'm {this.age} years old"); // Using this to refer to instance variables
    }
}
```

### 9. What is inheritance and what are its types in C#?
**Answer:** Inheritance is a mechanism where a new class (derived/child) can inherit properties and behaviors from an existing class (base/parent). Types of inheritance in C# include:
- Single inheritance (one base class)
- Multilevel inheritance (child of a child)
- Hierarchical inheritance (multiple classes inherit from one base class)
- Multiple inheritance (through interfaces only, not with classes)

**Example:**
```csharp
// Base class
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

// Single inheritance
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    
    public override void Start()
    {
        Console.WriteLine("Car started");
    }
}

// Multilevel inheritance
public class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }
    
    public override void Start()
    {
        Console.WriteLine("Electric car started silently");
    }
}
```

### 10. What is a static class in C#?
**Answer:** A static class:
- Cannot be instantiated
- Can only contain static members
- Cannot be inherited
- Is sealed by default
- Is primarily used to organize methods that don't require object state

**Example:**
```csharp
public static class MathHelper
{
    public static double Pi = 3.14159;
    
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static double CalculateCircleArea(double radius)
    {
        return Pi * radius * radius;
    }
}

// Usage
int sum = MathHelper.Add(5, 3);
double area = MathHelper.CalculateCircleArea(5);
```

## MVC (Model-View-Controller)

### 11. What is MVC architecture?
**Answer:** MVC (Model-View-Controller) is a software design pattern that separates an application into three main components:
- **Model:** Represents data and business logic
- **View:** Displays data to the user (user interface)
- **Controller:** Handles user requests and orchestrates interaction between the Model and View

**Example:**
```csharp
// Model
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

// Controller
public class CustomerController : Controller
{
    private readonly ICustomerRepository _repository;
    
    public CustomerController(ICustomerRepository repository)
    {
        _repository = repository;
    }
    
    public IActionResult Index()
    {
        var customers = _repository.GetAllCustomers();
        return View(customers);
    }
    
    public IActionResult Details(int id)
    {
        var customer = _repository.GetCustomerById(id);
        if (customer == null)
            return NotFound();
            
        return View(customer);
    }
}

// View (Razor syntax)
@model IEnumerable<Customer>

<h2>Customer List</h2>
<table>
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Email</th>
    </tr>
    @foreach (var customer in Model)
    {
        <tr>
            <td>@customer.Id</td>
            <td>@customer.Name</td>
            <td>@customer.Email</td>
        </tr>
    }
</table>
```

### 12. What are action methods in MVC?
**Answer:** Action methods are methods in controller classes that handle HTTP requests. They:
- Are public methods in a controller class
- Return an IActionResult (or derived type)
- Can have parameters that are bound to HTTP request data
- Process requests and determine what response to send back

**Example:**
```csharp
public class ProductController : Controller
{
    // GET: /Product/
    public IActionResult Index()
    {
        var products = _productService.GetAllProducts();
        return View(products);
    }
    
    // GET: /Product/Details/5
    public IActionResult Details(int id)
    {
        var product = _productService.GetProductById(id);
        if (product == null)
            return NotFound();
            
        return View(product);
    }
    
    // POST: /Product/Create
    [HttpPost]
    public IActionResult Create(ProductViewModel model)
    {
        if (ModelState.IsValid)
        {
            _productService.CreateProduct(model);
            return RedirectToAction("Index");
        }
        return View(model);
    }
}
```

### 13. What are the common return types of controller actions?
**Answer:** Common return types include:
- ViewResult (View()): Returns a view
- PartialViewResult (PartialView()): Returns a partial view
- RedirectResult (Redirect()): Redirects to a URL
- RedirectToActionResult (RedirectToAction()): Redirects to another action
- JsonResult (Json()): Returns JSON-formatted data
- FileResult (File()): Returns a file
- ContentResult (Content()): Returns plain text
- BadRequestResult (BadRequest()): Returns 400 status code
- NotFoundResult (NotFound()): Returns 404 status code

**Example:**
```csharp
public class ResultsController : Controller
{
    public ViewResult ShowView()
    {
        return View(); // Returns a view
    }
    
    public PartialViewResult ShowPartial()
    {
        return PartialView("_PartialName"); // Returns a partial view
    }
    
    public RedirectResult RedirectToUrl()
    {
        return Redirect("https://example.com"); // Redirects to URL
    }
    
    public RedirectToActionResult RedirectToAnotherAction()
    {
        return RedirectToAction("Index", "Home"); // Redirects to another action
    }
    
    public JsonResult GetJson()
    {
        var data = new { Name = "John", Age = 30 };
        return Json(data); // Returns JSON
    }
    
    public FileResult DownloadFile()
    {
        byte[] fileContents = GetFileContents();
        return File(fileContents, "application/pdf", "report.pdf"); // Returns a file
    }
    
    public ContentResult GetText()
    {
        return Content("Hello, World!"); // Returns plain text
    }
}
```

### 14. What is routing in ASP.NET MVC?
**Answer:** Routing is the mechanism that maps incoming URLs to specific controller actions. It determines which controller and action method should handle a specific request.

**Example:**
```csharp
// In Startup.cs (ASP.NET Core)
public void Configure(IApplicationBuilder app)
{
    app.UseRouting();
    
    app.UseEndpoints(endpoints =>
    {
        // Default route
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
            
        // Custom route
        endpoints.MapControllerRoute(
            name: "blog",
            pattern: "blog/{year}/{month}/{day}",
            defaults: new { controller = "Blog", action = "Post" },
            constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });
    });
}
```

### 15. What are attribute routes in MVC?
**Answer:** Attribute routing allows you to define routes directly on controller actions using attributes. It provides more control and flexibility over routing compared to conventional routing.

**Example:**
```csharp
[Route("api/[controller]")]
public class ProductsController : Controller
{
    [HttpGet]
    public IActionResult GetAll()
    {
        // Return all products
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // Return product with specified id
    }
    
    [HttpGet("category/{categoryName}")]
    public IActionResult GetByCategory(string categoryName)
    {
        // Return products in specified category
    }
    
    [HttpPost]
    public IActionResult Create([FromBody] ProductModel product)
    {
        // Create new product
    }
}
```

### 16. What is Model Binding in MVC?
**Answer:** Model binding is the process of mapping HTTP request data (form values, route data, query string parameters, etc.) to action method parameters or model objects. It automatically converts request data to .NET types.

**Example:**
```csharp
// Model
public class RegisterViewModel
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

// Controller
public class AccountController : Controller
{
    // Model binding from form data
    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Process registration
            return RedirectToAction("Success");
        }
        return View(model);
    }
    
    // Model binding from query string
    public IActionResult Search(string query, int? page)
    {
        // Parameters automatically populated from query string
        // e.g., /Search?query=test&page=2
        return View();
    }
    
    // Model binding from route data
    [Route("users/{userId}/orders/{orderId}")]
    public IActionResult GetOrder(int userId, int orderId)
    {
        // Parameters bound from route
        return View();
    }
}
```

### 17. What is the ViewBag and ViewData in MVC?
**Answer:**
- **ViewBag:** A dynamic property that enables passing data from controller to view. It uses C#'s dynamic feature.
- **ViewData:** A dictionary object that also passes data from controller to view, but requires type casting in the view.

**Example:**
```csharp
// Controller
public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Using ViewBag
        ViewBag.Message = "Welcome to ASP.NET MVC";
        ViewBag.CurrentDate = DateTime.Now;
        
        // Using ViewData
        ViewData["Title"] = "Home Page";
        ViewData["Items"] = new List<string> { "Item1", "Item2", "Item3" };
        
        return View();
    }
}

// View
@{
    Layout = "_Layout";
}

<h2>@ViewData["Title"]</h2>
<p>@ViewBag.Message</p>
<p>Current date: @ViewBag.CurrentDate.ToShortDateString()</p>

<ul>
    @foreach (string item in (List<string>)ViewData["Items"])
    {
        <li>@item</li>
    }
</ul>
```

### 18. What are Partial Views in MVC?
**Answer:** Partial Views are reusable view components that render a portion of a view's content. They help to break complex views into smaller, manageable pieces and promote code reuse.

**Example:**
```csharp
// Controller
public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = _productService.GetFeaturedProducts();
        return View(products);
    }
}

// Main View (Index.cshtml)
@model IEnumerable<Product>

<h2>Featured Products</h2>
<div class="product-grid">
    @foreach (var product in Model)
    {
        <div class="product-item">
            @await Html.PartialAsync("_ProductCard", product)
        </div>
    }
</div>

// Partial View (_ProductCard.cshtml)
@model Product

<div class="card">
    <h3>@Model.Name</h3>
    <p>@Model.Description</p>
    <p class="price">$@Model.Price.ToString("F2")</p>
    <button class="btn">Add to Cart</button>
</div>
```

### 19. What is the difference between TempData, ViewData, and ViewBag?
**Answer:**
- **ViewData:** Dictionary object that persists data only from controller to view (not from one request to another)
- **ViewBag:** A dynamic wrapper around ViewData, providing a more convenient syntax
- **TempData:** Dictionary that preserves data for one subsequent request after the current request

**Example:**
```csharp
public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Process login
            
            // TempData persists through the redirect
            TempData["SuccessMessage"] = "You have successfully logged in!";
            return RedirectToAction("Dashboard");
        }
        
        // These only work when returning a View directly (not through redirects)
        ViewData["Title"] = "Login Page";
        ViewBag.ErrorMessage = "Invalid login attempt";
        
        return View(model);
    }
    
    public IActionResult Dashboard()
    {
        // Can access TempData here after redirect
        // The success message is available for this request only
        return View();
    }
}

// In Dashboard.cshtml
@if (TempData["SuccessMessage"] != null)
{
    <div class="alert alert-success">
        @TempData["SuccessMessage"]
    </div>
}
```

### 20. What are tag helpers in ASP.NET Core MVC?
**Answer:** Tag Helpers are components that enable server-side code to participate in creating and rendering HTML elements in Razor files. They provide a more HTML-friendly way to write server-side logic compared to HTML helpers.

**Example:**
```csharp
// Traditional HTML helpers
@Html.ActionLink("Home", "Index", "Home")
@Html.TextBoxFor(m => m.Username)

// Tag Helpers
<a asp-controller="Home" asp-action="Index">Home</a>
<input asp-for="Username" />

// Tag Helper in form
<form asp-controller="Account" asp-action="Login" method="post">
    <div class="form-group">
        <label asp-for="Username"></label>
        <input asp-for="Username" class="form-control" />
        <span asp-validation-for="Username" class="text-danger"></span>
    </div>
    <div class="form-group">
        <label asp-for="Password"></label>
        <input asp-for="Password" class="form-control" />
        <span asp-validation-for="Password" class="text-danger"></span>
    </div>
    <button type="submit" class="btn btn-primary">Login</button>
</form>
```

## SQL

### 21. What is SQL and what are the different types of SQL commands?
**Answer:** SQL (Structured Query Language) is a domain-specific language used for managing and manipulating relational databases. The main types of SQL commands are:
- **DDL (Data Definition Language):** CREATE, ALTER, DROP, TRUNCATE
- **DML (Data Manipulation Language):** SELECT, INSERT, UPDATE, DELETE
- **DCL (Data Control Language):** GRANT, REVOKE
- **TCL (Transaction Control Language):** COMMIT, ROLLBACK, SAVEPOINT

**Example:**
```sql
-- DDL: Create a table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2)
);

-- DML: Insert data
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary)
VALUES (1, 'John', 'Doe', 1, 50000);

-- DML: Query data
SELECT FirstName, LastName, Salary 
FROM Employees
WHERE DepartmentID = 1;

-- DML: Update data
UPDATE Employees
SET Salary = 55000
WHERE EmployeeID = 1;

-- DML: Delete data
DELETE FROM Employees
WHERE EmployeeID = 1;

-- DCL: Grant privileges
GRANT SELECT ON Employees TO User1;

-- TCL: Transaction control
BEGIN TRANSACTION;
    UPDATE Accounts SET Balance = Balance - 100 WHERE AccountID = 1;
    UPDATE Accounts SET Balance = Balance + 100 WHERE AccountID = 2;
COMMIT;
```

### 22. What are primary keys and foreign keys in SQL?
**Answer:**
- **Primary Key:** A column or set of columns that uniquely identifies each row in a table. Each table can have only one primary key, and it cannot contain NULL values.
- **Foreign Key:** A column or set of columns that establishes a link between data in two tables. It references the primary key of another table and maintains referential integrity.

**Example:**
```sql
-- Creating a Departments table with primary key
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50)
);

-- Creating an Employees table with primary key and foreign key
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
```

### 23. What are the different types of joins in SQL?
**Answer:** The main types of SQL joins are:
- **INNER JOIN:** Returns rows when there is a match in both tables
- **LEFT JOIN (or LEFT OUTER JOIN):** Returns all rows from the left table and matching rows from the right table
- **RIGHT JOIN (or RIGHT OUTER JOIN):** Returns all rows from the right table and matching rows from the left table
- **FULL JOIN (or FULL OUTER JOIN):** Returns rows when there is a match in either table
- **CROSS JOIN:** Returns the Cartesian product of both tables (all possible combinations)

**Example:**
```sql
-- INNER JOIN: Get employees with their department names
SELECT e.EmployeeID, e.FirstName, e.LastName, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- LEFT JOIN: Get all employees and their department names (if they have one)
SELECT e.EmployeeID, e.FirstName, e.LastName, d.DepartmentName
FROM Employees e
LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- RIGHT JOIN: Get all departments and their employees (if they have any)
SELECT e.EmployeeID, e.FirstName, e.LastName, d.DepartmentName
FROM Employees e
RIGHT JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- FULL JOIN: Get all employees and all departments with matches where they exist
SELECT e.EmployeeID, e.FirstName, e.LastName, d.DepartmentName
FROM Employees e
FULL JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- CROSS JOIN: Get all possible combinations of employees and departments
SELECT e.EmployeeID, e.FirstName, d.DepartmentName
FROM Employees e
CROSS JOIN Departments d;
```

### 24. What are aggregate functions in SQL?
**Answer:** Aggregate functions perform calculations on a set of values and return a single value. Common aggregate functions include:
- **COUNT:** Counts the number of rows
- **SUM:** Calculates the sum of values
- **AVG:** Calculates the average of values
- **MIN:** Finds the minimum value
- **MAX:** Finds the maximum value

**Example:**
```sql
-- Count total number of employees
SELECT COUNT(*) AS TotalEmployees
FROM Employees;

-- Calculate total salary by department
SELECT DepartmentID, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID;

-- Calculate average salary
SELECT AVG(Salary) AS AverageSalary
FROM Employees;

-- Find the highest and lowest salaries
SELECT 
    MAX(Salary) AS HighestSalary,
    MIN(Salary) AS LowestSalary
FROM Employees;

-- Get department with the highest average salary
SELECT TOP 1 DepartmentID, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY AvgSalary DESC;
```

### 25. What is the GROUP BY clause in SQL?
**Answer:** The GROUP BY clause groups rows that have the same values into summary rows. It is often used with aggregate functions to perform calculations on each group.

**Example:**
```sql
-- Count employees in each department
SELECT DepartmentID, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY DepartmentID;

-- Calculate average salary by department and job title
SELECT DepartmentID, JobTitle, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY DepartmentID, JobTitle
ORDER BY DepartmentID, AvgSalary DESC;

-- Find the total salary budget by department
SELECT d.DepartmentName, SUM(e.Salary) AS TotalSalary
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName;
```

### 26. What is the difference between WHERE and HAVING clauses?
**Answer:**
- **WHERE:** Filters rows before grouping. Used to filter individual rows.
- **HAVING:** Filters groups after the GROUP BY clause is applied. Used to filter groups based on aggregate values.

**Example:**
```sql
-- WHERE filters individual rows (before grouping)
SELECT DepartmentID, AVG(Salary) AS AvgSalary
FROM Employees
WHERE Salary > 30000  -- Filters employees with salary > 30000
GROUP BY DepartmentID;

-- HAVING filters groups (after grouping)
SELECT DepartmentID, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY DepartmentID
HAVING AVG(Salary) > 50000;  -- Filters departments with avg salary > 50000

-- Combined example
SELECT d.DepartmentName, COUNT(*) AS EmployeeCount, AVG(e.Salary) AS AvgSalary
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '2020-01-01'  -- Only consider employees hired after 2020
GROUP BY d.DepartmentName
HAVING COUNT(*) > 5;  -- Only include departments with more than 5 employees
```

### 27. What are SQL indexes and why are they used?
**Answer:** Indexes are special data structures that improve the speed of data retrieval operations on database tables. They work similar to a book's index by allowing the database engine to find specific rows quickly without scanning the entire table.

**Example:**
```sql
-- Create a table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    ZipCode VARCHAR(10)
);

-- Create a non-clustered index on LastName
CREATE INDEX IX_Customers_LastName
ON Customers (LastName);

-- Create a composite index on ZipCode and LastName
CREATE INDEX IX_Customers_ZipCode_LastName
ON Customers (ZipCode, LastName);

-- Create a unique index on Email
CREATE UNIQUE INDEX IX_Customers_Email
ON Customers (Email);
```

### 28. What are stored procedures and why are they used?
**Answer:** Stored procedures are prepared SQL code that can be saved and reused. Benefits include:
- Improved performance (precompiled)
- Enhanced security (restricted permissions)
- Reduced network traffic
- Code reusability and maintenance
- Support for complex business logic

**Example:**
```sql
-- Create a stored procedure to get employees by department
CREATE PROCEDURE GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT EmployeeID, FirstName, LastName, Salary
    FROM Employees
    WHERE DepartmentID = @DepartmentID
    ORDER BY LastName, FirstName;
END;

-- Execute the stored procedure
EXEC GetEmployeesByDepartment @DepartmentID = 3;

-- Create a stored procedure to insert a new employee
CREATE PROCEDURE InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10, 2),
    @EmployeeID INT OUTPUT
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary);
    
    SET @EmployeeID = SCOPE_IDENTITY();
END;

-- Execute the procedure
DECLARE @NewEmployeeID INT;
EXEC InsertEmployee 
    @FirstName = 'Jane',
    @LastName = 'Smith',
    @DepartmentID = 2,
    

@Salary = 60000,
    @EmployeeID = @NewEmployeeID OUTPUT;
    
SELECT @NewEmployeeID AS 'New Employee ID';
```

### 29. What are triggers in SQL?
**Answer:** Triggers are special stored procedures that automatically execute when an event (like INSERT, UPDATE, DELETE) occurs on a specific table. They are used to enforce business rules, maintain data integrity, and automate tasks.

**Example:**
```sql
-- Create a trigger that logs employee updates
CREATE TABLE EmployeeAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    Action VARCHAR(10),
    ModifiedDate DATETIME,
    ModifiedBy VARCHAR(50)
);

CREATE TRIGGER trg_EmployeeUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, Action, ModifiedDate, ModifiedBy)
    SELECT 
        i.EmployeeID,
        'UPDATE',
        GETDATE(),
        SYSTEM_USER
    FROM inserted i;
END;

-- Create a trigger that prevents deleting departments with employees
CREATE TRIGGER trg_PreventDepartmentDelete
ON Departments
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Employees e
        JOIN deleted d ON e.DepartmentID = d.DepartmentID
    )
    BEGIN
        RAISERROR('Cannot delete department with existing employees', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    
    DELETE FROM Departments
    WHERE DepartmentID IN (SELECT DepartmentID FROM deleted);
END;
```

### 30. What are subqueries in SQL?
**Answer:** Subqueries (or nested queries) are queries within another SQL query. They can be used in various parts of a SQL statement (SELECT, FROM, WHERE, HAVING) to return data that will be used in the main query.

**Example:**
```sql
-- Subquery in WHERE clause
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees);

-- Subquery in FROM clause
SELECT DepartmentName, AvgSalary
FROM (
    SELECT d.DepartmentName, AVG(e.Salary) AS AvgSalary
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID
    GROUP BY d.DepartmentName
) AS DeptSalaries
WHERE AvgSalary > 50000;

-- Correlated subquery
SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary > (
    SELECT AVG(Salary)
    FROM Employees
    WHERE DepartmentID = e.DepartmentID
);

-- Subquery with EXISTS
SELECT d.DepartmentName
FROM Departments d
WHERE EXISTS (
    SELECT 1
    FROM Employees e
    WHERE e.DepartmentID = d.DepartmentID
    AND e.Salary > 70000
);
```

## .NET Framework and C# Fundamentals

### 31. What is the difference between .NET Framework, .NET Core, and .NET 5/6?
**Answer:**
- **.NET Framework:** Original Windows-only framework, large and mature but less flexible
- **.NET Core:** Cross-platform, open-source, modular, and high-performance reimagining of .NET
- **.NET 5/6:** Unified platform that merges .NET Core and .NET Framework into a single framework with cross-platform support

**Example:**
```csharp
// .NET Framework (Windows-only)
// Program.cs in a traditional .NET Framework Console app
using System;

namespace DotNetFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET Framework!");
        }
    }
}

// .NET Core/.NET 5+
// Program.cs in a .NET Core/.NET 5+ Console app
using System;

Console.WriteLine("Hello from .NET Core/.NET 5+!");

// .NET 6 minimal API
// Program.cs in a .NET 6 Web API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from .NET 6!");

app.Run();
```

### 32. What is the difference between value types and reference types in C#?
**Answer:**
- **Value Types:** Stored directly on the stack, contain their data, and each variable has its own copy of the data
- **Reference Types:** Stored on the heap with a reference on the stack, contain a reference to their data, and multiple variables can reference the same object

**Example:**
```csharp
// Value types
int a = 10;
int b = a;  // b gets a copy of a's value
b = 20;     // a is still 10

struct Point
{
    public int X;
    public int Y;
}

Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;  // p2 gets a copy of p1's value
p2.X = 3;       // p1.X is still 1

// Reference types
string s1 = "Hello";
string s2 = s1;  // s2 references the same string as s1
                // (strings are immutable, so this is a special case)

List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = list1;  // list2 references the same list as list1
list2.Add(4);             // list1 also contains 4 now
```

### 33. What are extension methods in C#?
**Answer:** Extension methods allow you to add methods to existing types without modifying the original type. They are defined as static methods in static classes and use the 'this' keyword before the first parameter to specify the type being extended.

**Example:**
```csharp
// Extension method for string type
public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
    
    public static string Truncate(this string str, int maxLength)
    {
        if (str == null) return null;
        
        return str.Length <= maxLength ? str : str.Substring(0, maxLength) + "...";
    }
}

// Usage
string name = "John Doe";
bool isEmpty = name.IsNullOrEmpty();  // false
string truncated = name.Truncate(4);  // "John..."

// Extension method for IEnumerable<T>
public static class EnumerableExtensions
{
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
    {
        Random rng = new Random();
        return source.OrderBy(item => rng.Next());
    }
}

// Usage
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var shuffled = numbers.Shuffle();
```

### 34. What is LINQ and how is it used?
**Answer:** LINQ (Language Integrated Query) is a set of features in C# that provides a syntax for querying data from various sources (arrays, collections, databases, XML, etc.) using a consistent syntax. It allows for querying data directly within C# code.

**Example:**
```csharp
// Sample data
List<Person> people = new List<Person>
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "Jane", Age = 25 },
    new Person { Name = "Bob", Age = 40 },
    new Person { Name = "Alice", Age = 35 }
};

// LINQ query syntax
var youngPeople = from person in people
                  where person.Age < 30
                  orderby person.Name
                  select person;

// LINQ method syntax
var youngPeople2 = people
    .Where(p => p.Age < 30)
    .OrderBy(p => p.Name);

// Projecting to a new type
var nameAgePairs = people
    .Where(p => p.Age >= 30)
    .Select(p => new { p.Name, AgeCategory = p.Age < 35 ? "Young" : "Senior" });

// Aggregation
int totalAge = people.Sum(p => p.Age);
double averageAge = people.Average(p => p.Age);
int oldestAge = people.Max(p => p.Age);

// Grouping
var ageGroups = people
    .GroupBy(p => p.Age < 30 ? "Young" : "Senior")
    .Select(g => new
    {
        AgeCategory = g.Key,
        Count = g.Count(),
        People = g.Select(p => p.Name)
    });
```

### 35. What are async and await in C#?
**Answer:** The async and await keywords in C# simplify asynchronous programming by allowing you to write asynchronous code that looks and behaves like synchronous code. They work together to enable non-blocking code execution.

**Example:**
```csharp
// Synchronous method
public string DownloadWebpage(string url)
{
    // This blocks the thread until the download completes
    WebClient client = new WebClient();
    return client.DownloadString(url);
}

// Asynchronous method
public async Task<string> DownloadWebpageAsync(string url)
{
    // The await keyword makes this non-blocking
    HttpClient client = new HttpClient();
    return await client.GetStringAsync(url);
}

// Using async/await in a method
public async Task ProcessDataAsync()
{
    Console.WriteLine("Starting to process data...");
    
    // This doesn't block the thread
    string data = await DownloadWebpageAsync("https://example.com");
    
    // This code runs after the download completes
    Console.WriteLine($"Downloaded {data.Length} bytes");
    
    // Multiple async operations in parallel
    Task<string> task1 = DownloadWebpageAsync("https://example.com/1");
    Task<string> task2 = DownloadWebpageAsync("https://example.com/2");
    
    // Wait for all tasks to complete
    await Task.WhenAll(task1, task2);
    
    Console.WriteLine("All downloads complete");
}
```

### 36. What is dependency injection in .NET?
**Answer:** Dependency Injection (DI) is a design pattern that implements Inversion of Control (IoC) for resolving dependencies between objects. It allows you to make your code more modular, testable, and maintainable by removing the responsibility of creating and managing dependencies from the class that uses them.

**Example:**
```csharp
// Without DI
public class CustomerService
{
    private readonly CustomerRepository _repository;
    
    public CustomerService()
    {
        _repository = new CustomerRepository();  // Hard dependency
    }
    
    public Customer GetCustomer(int id)
    {
        return _repository.GetById(id);
    }
}

// With DI
public interface ICustomerRepository
{
    Customer GetById(int id);
}

public class CustomerRepository : ICustomerRepository
{
    public Customer GetById(int id)
    {
        // Implementation
    }
}

public class CustomerService
{
    private readonly ICustomerRepository _repository;
    
    public CustomerService(ICustomerRepository repository)  // Constructor injection
    {
        _repository = repository;
    }
    
    public Customer GetCustomer(int id)
    {
        return _repository.GetById(id);
    }
}

// In ASP.NET Core Startup.cs
public void ConfigureServices(IServiceCollection services)
{
    // Register services
    services.AddTransient<ICustomerRepository, CustomerRepository>();
    services.AddTransient<CustomerService>();
}

// Usage with DI container
public class CustomerController : Controller
{
    private readonly CustomerService _service;
    
    public CustomerController(CustomerService service)  // DI container injects the service
    {
        _service = service;
    }
    
    public IActionResult Details(int id)
    {
        var customer = _service.GetCustomer(id);
        return View(customer);
    }
}
```

### 37. What is the difference between IEnumerable and IQueryable?
**Answer:**
- **IEnumerable:** Executes queries in-memory (client-side) and retrieves all data from the source before filtering
- **IQueryable:** Executes queries at the data source (server-side) and can translate LINQ queries into SQL, retrieving only the required data

**Example:**
```csharp
// IEnumerable example - filtering happens in memory
public IEnumerable<Customer> GetCustomersByName(string name)
{
    // This loads ALL customers into memory first
    IEnumerable<Customer> allCustomers = dbContext.Customers.ToList();
    
    // Then filters in memory
    return allCustomers.Where(c => c.Name.Contains(name));
}

// IQueryable example - filtering happens at the database level
public IQueryable<Customer> GetCustomersByName(string name)
{
    // This builds a query that will be executed at the database
    IQueryable<Customer> query = dbContext.Customers;
    
    // This modifies the query, not the results
    return query.Where(c => c.Name.Contains(name));
    
    // The query is only executed when results are enumerated
    // e.g., .ToList(), .FirstOrDefault(), or in a foreach loop
}

// Performance comparison
public void QueryPerformanceExample()
{
    // IEnumerable approach (inefficient for large datasets)
    var customersEnum = dbContext.Customers.ToList()  // Loads ALL customers
        .Where(c => c.City == "Seattle")
        .Take(10);
    
    // IQueryable approach (efficient)
    var customersQuery = dbContext.Customers  // No database query yet
        .Where(c => c.City == "Seattle")      // Adds WHERE clause to SQL
        .Take(10);                            // Adds TOP 10 to SQL
    
    // The SQL query is only executed here
    var results = customersQuery.ToList();
    
    // Equivalent SQL:
    // SELECT TOP 10 * FROM Customers WHERE City = 'Seattle'
}
```

### 38. What are Generic Collections in C#?
**Answer:** Generic collections in C# are strongly-typed collections that provide type safety and better performance than non-generic collections. They are defined in the System.Collections.Generic namespace and allow you to specify the type of elements stored in the collection.

**Example:**
```csharp
// List<T> - Dynamic array
List<string> names = new List<string>();
names.Add("John");
names.Add("Jane");
names.Insert(1, "Bob");
bool containsJohn = names.Contains("John");  // true
names.Remove("Bob");
string firstPerson = names[0];  // "John"

// Dictionary<TKey, TValue> - Key-value pairs
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("John", 30);
ages["Jane"] = 25;
int johnsAge = ages["John"];  // 30
bool containsJane = ages.ContainsKey("Jane");  // true
ages.Remove("John");

// HashSet<T> - Unique elements
HashSet<int> numbers = new HashSet<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(1);  // Ignored (duplicate)
bool containsTwo = numbers.Contains(2);  // true
numbers.Remove(1);

// Queue<T> - FIFO (First In, First Out)
Queue<string> queue = new Queue<string>();
queue.Enqueue("First");
queue.Enqueue("Second");
string next = queue.Peek();  // "First" (without removing)
string first = queue.Dequeue();  // "First" (and removes it)

// Stack<T> - LIFO (Last In, First Out)
Stack<string> stack = new Stack<string>();
stack.Push("First");
stack.Push("Second");
string top = stack.Peek();  // "Second" (without removing)
string popped = stack.Pop();  // "Second" (and removes it)
```

### 39. What are delegates and events in C#?
**Answer:**
- **Delegate:** A type that represents references to methods with a specific parameter list and return type. Delegates allow methods to be passed as parameters.
- **Event:** A special kind of delegate that facilitates the publisher-subscriber pattern. Events are used to notify other objects when something happens.

**Example:**
```csharp
// Delegate definition
public delegate void MessageHandler(string message);

// Event publisher
public class Notifier
{
    // Event declaration
    public event MessageHandler MessageReceived;
    
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending message: {message}");
        
        // Raise the event
        MessageReceived?.Invoke(message);
    }
}

// Event subscriber
public class Logger
{
    public void OnMessageReceived(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}

// Usage
public void DelegateEventExample()
{
    // Using a delegate
    MessageHandler handler = message => Console.WriteLine($"Received: {message}");
    handler("Hello via delegate");  // Outputs: Received: Hello via delegate
    
    // Using an event
    Notifier notifier = new Notifier();
    Logger logger = new Logger();
    
    // Subscribe to the event
    notifier.MessageReceived += logger.OnMessageReceived;
    
    // Add anonymous method as handler
    notifier.MessageReceived += message => Console.WriteLine($"Anonymous: {message}");
    
    // Trigger the event
    notifier.SendMessage("Important notification");
    
    // Unsubscribe from the event
    notifier.MessageReceived -= logger.OnMessageReceived;
}
```

### 40. What is Entity Framework and how does it work?
**Answer:** Entity Framework (EF) is an Object-Relational Mapping (ORM) framework for .NET that enables developers to work with databases using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.

**Example:**
```csharp
// Define entity classes
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}

// Create database context
public class ECommerceContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=ECommerce;Trusted_Connection=True;");
    }
}

// Usage examples
public void EntityFrameworkExample()
{
    // Create context
    using (var context = new ECommerceContext())
    {
        // Create and save a new customer
        var customer = new Customer
        {
            Name = "John Doe",
            Email = "john@example.com"
        };
        context.Customers.Add(customer);
        context.SaveChanges();
        
        // Query for customers
        var customers = context.Customers
            .Where(c => c.Name.Contains("John"))
            .ToList();
            
        // Update a customer
        var existingCustomer = context.Customers.Find(1);
        if (existingCustomer != null)
        {
            existingCustomer.Email = "updated@example.com";
            context.SaveChanges();
        }
        
        // Delete a customer
        var customerToDelete = context.Customers.Find(2);
        if (customerToDelete != null)
        {
            context.Customers.Remove(customerToDelete);
            context.SaveChanges();
        }
        
        // Load related data
        var customersWithOrders = context.Customers
            .Include(c => c.Orders)
            .ToList();
    }
}
```

## General Programming Concepts

### 41. What is a RESTful API?
**Answer:** REST (Representational State Transfer) is an architectural style for designing networked applications. RESTful APIs use HTTP methods explicitly and are stateless, with resources identified by URIs.

**Example:**
```csharp
// ASP.NET Core RESTful API Controller
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repository;
    
    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }
    
    // GET: api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(_repository.GetAll());
    }
    
    // GET: api/products/5
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _repository.GetById(id);
        if (product == null)
            return NotFound();
            
        return Ok(product);
    }
    
    // POST: api/products
    [HttpPost]
    public ActionResult<Product> Create(ProductDto productDto)
    {
        var product = new Product
        {
            Name = productDto.Name,
            Price = productDto.Price
        };
        
        _repository.Add(product);
        
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }
    
    // PUT: api/products/5
    [HttpPut("{id}")]
    public IActionResult Update(int id, ProductDto productDto)
    {
        var existingProduct = _repository.GetById(id);
        if (existingProduct == null)
            return NotFound();
            
        existingProduct.Name = productDto.Name;
        existingProduct.Price = productDto.Price;
        
        _repository.Update(existingProduct);
        
        return NoContent();
    }
    
    // DELETE: api/products/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = _repository.GetById(id);
        if (product == null)
            return NotFound();
            
        _repository.Delete(id);
        
        return NoContent();
    }
}
```

### 42. What is the Repository Pattern?
**Answer:** The Repository Pattern is a design pattern that abstracts the data access layer from the rest of the application. It provides a collection-like interface for accessing and manipulating domain objects, while hiding the details of data access logic.

**Example:**
```csharp
// Domain entity
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

// Repository interface
public interface ICustomerRepository
{
    IEnumerable<Customer> GetAll();
    Customer GetById(int id);
    void Add(Customer customer);
    void Update(Customer customer);
    void Delete(int id);
}

// Repository implementation with Entity Framework
public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;
    
    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }
    
    public Customer GetById(int id)
    {
        return _context.Customers.Find(id);
    }
    
    public void Add(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }
    
    public void Update(Customer customer)
    {
        _context.Entry(customer).State = EntityState.Modified;
        _context.SaveChanges();
    }
    
    public void Delete(int id)
    {
        var customer = _context.Customers.Find(id);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}

// Usage in a service
public class CustomerService
{
    private readonly ICustomerRepository _repository;
    
    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }
    
    public void ProcessCustomer(int id)
    {
        var customer = _repository.GetById(id);
        // Process customer...
    }
}
```

### 43. What are the SOLID principles?
**Answer:** SOLID is an acronym for five design principles intended to make software more maintainable and flexible:
- **S**ingle Responsibility Principle: A class should have only one reason to change
- **O**pen/Closed Principle: Software entities should be open for extension but closed for modification
- **L**iskov Substitution Principle: Derived classes must be substitutable for their base classes
- **I**nterface Segregation Principle: Many client-specific interfaces are better than one general-purpose interface
- **D**ependency Inversion Principle: Depend on abstractions, not concretions

**Example:**
```csharp
// Single Responsibility Principle
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Each class has a single responsibility
public class CustomerRepository
{
    public Customer GetById(int id) { /* ... */ }
    public void Save(Customer customer) { /* ... */ }
}

public class CustomerValidator
{
    public bool IsValid(Customer customer) { /* ... */ }
}

public class CustomerFormatter
{
    public string FormatAsJson(Customer customer) { /* ... */ }
}

// Open/Closed Principle
public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(decimal amount);
}

// Adding new payment methods without modifying existing code
public class CreditCardProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount) { /* ... */ }
}

public class PayPalProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount) { /* ... */ }
}

// Liskov Substitution Principle
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    
    public int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    private int _size;
    
    public override int Width
    {
        get { return _size; }
        set { _size = value; }
    }
    
    public override int Height
    {
        get { return _size; }
        set { _size = value; }
    }
}

// Interface Segregation Principle
// Bad: One large interface
public interface IEmployee
{
    void CalculateSalary();
    void GenerateReport();
    void CalculateRetirement();
    void CalculateBonus();
}

// Good: Segregated interfaces
public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IReportGenerator
{
    void GenerateReport();
}

public interface IRetirementCalculator
{
    void CalculateRetirement();
}

public interface IBonusCalculator
{
    void CalculateBonus();
}

// Dependency Inversion Principle
// High-level module
public class NotificationService
{
    private readonly IMessageSender _messageSender;
    
    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }
    
    public void NotifyCustomer(string message)
    {
        _messageSender.SendMessage(message);
    }
}

// Abstraction
public interface IMessageSender
{
    void SendMessage(string message);
}

// Low-level modules
public class EmailSender : IMessageSender
{
    public void SendMessage(string message) { /* ... */ }
}

public class SmsSender : IMessageSender
{
    public void SendMessage(string message) { /* ... */ }
}
```

### 44. What is the difference between unit testing, integration testing, and end-to-end testing?
**Answer:**
- **Unit Testing:** Tests individual components or functions in isolation, often using mocks or stubs for dependencies
- **Integration Testing:** Tests how components work together, with actual dependencies or subsystems
- **End-to-End Testing:** Tests the entire application flow from start to finish, simulating real user scenarios

**Example:**
```csharp
// Unit Test Example (using xUnit)
public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(5, 3);
        
        // Assert
        Assert.Equal(8, result);
    }
}

// Integration Test Example
public class CustomerServiceIntegrationTests
{
    private readonly CustomerService _service;
    private readonly AppDbContext _dbContext;
    
    public CustomerServiceIntegrationTests()
    {
        // Setup test database
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;
            
        _dbContext = new AppDbContext(options);
        var repository = new CustomerRepository(_dbContext);
        _service = new CustomerService(repository);
        
        // Seed test data
        _dbContext.Customers.Add(new Customer { Id = 1, Name = "Test Customer" });
        _dbContext.SaveChanges();
    }
    
    [Fact]
    public void GetCustomerById_ExistingCustomer_ReturnsCustomer()
    {
        // Act
        var customer = _service.GetCustomerById(1);
        
        // Assert
        Assert.NotNull(customer);
        Assert.Equal("Test Customer", customer.Name);
    }
}

// End-to-End Testing Example (using Selenium)
public class CustomerWorkflowTests
{
    private IWebDriver _driver;
    
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
    }
    
    [Test]
    public void CreateNewCustomer_ThenViewDetails()
    {
        // Navigate to customer creation page
        _driver.Navigate().GoToUrl("https://localhost:5001/customers/create");
        
        // Fill form
        _driver.FindElement(By.Id("Name")).SendKeys("New Customer");
        _driver.FindElement(By.Id("Email")).SendKeys("new@example.com");
        
        // Submit form
        _driver.FindElement(By.Id("submit-button")).Click();
        
        // Assert redirect to customer list
        Assert.IsTrue(_driver.Url.Contains("/customers"));
        
        // Assert customer appears in list
        var customerLinks = _driver.FindElements(By.CssSelector(".customer-link"));
        var newCustomerLink = customerLinks.FirstOrDefault(e => e.Text.Contains("New Customer"));
        Assert.IsNotNull(newCustomerLink);
        
        // Click on customer details
        newCustomerLink.Click();
        
        // Assert customer details are displayed
        Assert.IsTrue(_driver.Url.Contains("/customers/details"));
        Assert.IsTrue(_driver.FindElement(By.Id("customer-name")).Text.Contains("New Customer"));
    }
    
    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
    }
}
```

### 45. What are Design Patterns and why are they important?
**Answer:** Design patterns are reusable solutions to common problems in software design. They represent best practices evolved over time by experienced software developers. They are important because they:
- Provide proven solutions to common problems
- Improve code readability and maintainability
- Facilitate communication between developers
- Help prevent subtle issues that can cause major problems

**Example:**
```csharp
// Singleton Pattern
public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new