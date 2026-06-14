# 🛒 ProductCatalogApp

A console-based product catalog application built in C#.  
This is my fourth OOP project, created while following a C# course on Udemy.  
The focus of this project was on learning LINQ and combining it with CSV file reading, OOP classes, and Dictionaries.

---

## About the project

ProductCatalogApp reads a list of products from a CSV file and provides various ways to query and analyze the data.  
Each query uses a different LINQ method — the project was specifically designed to practice LINQ syntax in a practical context.

---

## Features

- Load products from a CSV file
- Group products by category using a `Dictionary<string, List<Product>>`
- Display all products in a given category
- Find the cheapest product in a category
- Calculate the total stock value of all products
- Calculate the average price of all products
- Display all products sorted by price
- Count the number of products in a category

---

## LINQ methods used

| Method | Used in |
|---|---|
| `.Where()` | Filtering products by category |
| `.OrderBy()` | Sorting products by price |
| `.First()` | Getting the cheapest product |
| `.Sum()` | Calculating total stock value |
| `.Average()` | Calculating average price |
| `.Count()` | Counting products per category |

---

## OOP concepts used

| Concept | Where |
|---|---|
| Classes & Objects | `Product`, `Catalog` |
| Properties (`get` / `private set`) | All classes |
| Encapsulation | `{ get; }` on lists and dictionaries |
| Constructors with parameters | `Product` |
| Methods | All query methods in `Catalog` |
| `List<T>` | `Products` in `Catalog` |
| `Dictionary<string, List<Product>>` | `ByCategory` in `Catalog` |

---

## Project structure

```
ProductCatalogApp/
├── Models/
│   └── Product.cs
├── Catalog.cs
├── products.csv
└── Program.cs
```

---

## The CSV file

The app reads from `products.csv` with the following structure:

```
Id,Name,Category,Price,Stock
1,Apple,Food,0.50,200
2,Laptop,Electronics,999.99,15
...
```

Place `products.csv` in the project folder and set **"Copy to Output Directory"** to **"Always Copy"** in Visual Studio.

---

## What I learned

This project brought together everything from my previous OOP projects — classes, constructors, lists, and dictionaries — and added LINQ on top.  
I learned how to write concise queries using lambda expressions like `p => p.Price` instead of writing manual `foreach` loops for every operation.  
I also practiced using `Dictionary<string, List<Product>>` where the value itself is a list, which required thinking carefully about how to initialize and populate nested data structures.

---

## Built with

- C# / .NET
- Visual Studio

---

> This README was created with the assistance of Claude (AI by Anthropic).
