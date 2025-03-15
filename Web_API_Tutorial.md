# Web API, MVC Framework, and Data Schemas Tutorial

## Introduction
This tutorial covers **Web APIs**, the **MVC framework**, and **data schemas**, explaining how they work together in modern web applications.

## Table of Contents
- [What is a Web API?](#what-is-a-web-api)
- [Understanding the MVC Framework](#understanding-the-mvc-framework)
- [Data Schemas in Web Development](#data-schemas-in-web-development)
- [Integrating Web API with MVC](#integrating-web-api-with-mvc)
- [Reference Materials](#reference-materials)

---

## What is a Web API?
A **Web API (Application Programming Interface)** allows communication between different software applications over the web using **HTTP requests**.

### Key Features:
- Uses **REST (Representational State Transfer)** principles.
- Communicates using JSON or XML.
- Provides CRUD operations (`GET`, `POST`, `PUT`, `DELETE`).

### Example HTTP Methods:
| Method | Description |
|--------|-------------|
| **GET** | Retrieve data from a resource |
| **POST** | Send data to create a new resource |
| **PUT** | Update an existing resource |
| **DELETE** | Remove a resource |

### Example API Endpoint:
```http
GET /api/products
```
Response:
```json
[
  { "id": 1, "name": "Laptop", "price": 999.99 }
]
```

---

## Understanding the MVC Framework
The **MVC (Model-View-Controller)** framework is a design pattern that separates an application into three components:

1. **Model**: Represents data and business logic.
2. **View**: Defines the UI (User Interface).
3. **Controller**: Handles user requests and interacts with the Model and View.

### How MVC Works:
1. **User sends a request** (e.g., `/products`)
2. **Controller processes the request** (calls Model for data)
3. **Model retrieves data** from a database
4. **View presents data** as a webpage or JSON response

### MVC in ASP.NET Core:
```csharp
public class ProductsController : Controller
{
    private readonly ProductDbContext _context;
    
    public ProductsController(ProductDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }
}
```

---

## Data Schemas in Web Development
A **data schema** defines how data is structured in a database or API response.

### Example: Product Schema
```json
{
  "id": 1,
  "name": "Laptop",
  "price": 999.99
}
```

### Database Schema (Entity Framework Model)
```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
```

---

## Integrating Web API with MVC
To combine Web APIs with MVC:
- **Controllers** handle both API and HTML responses.
- **Razor Views** display data when using MVC.
- **JavaScript (AJAX or Fetch API)** consumes API endpoints in the frontend.

### Example: Fetch API Call in JavaScript
```js
fetch('/api/products')
    .then(response => response.json())
    .then(data => console.log(data));
```

---

## Reference Materials
For further reading, check these resources:
- **Microsoft Docs:** [ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-7.0)
- **RESTful API Design:** [REST API Tutorial](https://restfulapi.net/)
- **Entity Framework Core:** [EF Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- **Postman API Testing:** [Postman Guide](https://learning.postman.com/)

---

This guide provides an overview of Web APIs, MVC frameworks, and data schemas. Let me know if you need deeper details on any topic! 🚀
