# TP02 – Razor Pages Web Application

## Course Information

This project was developed as part of the **Web Development with .NET and Databases** course in the **Analysis and Systems Development (ADS)** programme at **Infnet – Instituto Infnet, Rio de Janeiro, Brazil**.

The purpose of this assignment was to practise building web applications using **ASP.NET Core Razor Pages**, applying concepts of server-side development, form handling, validation and basic data modelling.

---

## Project Description

This repository contains a Razor Pages web application that implements several exercises related to managing cities and countries.

The application demonstrates how to create, list and validate entities using ASP.NET Core Razor Pages, following the MVC-inspired structure provided by the framework.

The project was built using **.NET 8** and organised into models, Razor Pages and supporting assets.

---

## Implemented Exercises

### 1. Country Model

A model representing a country was created with properties such as:

* Name
* Code
* Additional descriptive fields

This model is used as the basis for several form exercises.

---

### 2. Create Country Page

A Razor Page that allows users to create a new country by submitting a form.

Concepts demonstrated:

* Form submission
* Model binding
* Server-side processing

---

### 3. Create Country with Validation

An improved version of the country creation form with validation rules.

Concepts demonstrated:

* Data validation
* Error messages
* Input constraints

---

### 4. Create Multiple Countries

A page allowing the creation of multiple country entries within a single request.

Concepts demonstrated:

* Handling collections of data
* Dynamic form handling
* Server-side processing

---

### 5. City Management

Several pages were implemented to simulate a simple city management system:

* City List
* City Details
* City Creation

Concepts demonstrated:

* Page routing
* Passing data between pages
* Displaying lists of entities

---

### 6. Reading Notes from Files

A page that reads notes stored in files within the application.

Concepts demonstrated:

* File reading
* Working with server resources

---

## Technologies Used

* **C#**
* **ASP.NET Core**
* **Razor Pages**
* **.NET 8**
* **HTML5**
* **CSS**
* **Bootstrap**
* **JavaScript**
* **Git**
* **GitHub**

---

## Project Structure

```
TP02CSharp
│
├── Models
│   └── Country.cs
│
├── Pages
│   ├── CityManager
│   │   ├── CityList
│   │   ├── CityDetails
│   │   ├── CreateCity
│   │   └── CreateCountry
│   │
│   ├── Index
│   ├── Privacy
│   └── Shared
│
├── wwwroot
│   ├── css
│   ├── js
│   └── lib
│
└── Program.cs
```

---

## Learning Objectives

The main objectives of this project were:

* Understanding the **ASP.NET Core Razor Pages architecture**
* Implementing **server-side form processing**
* Applying **data validation**
* Managing **structured web project organisation**
* Practising **Git and GitHub for version control**

---

## Author

**Fernando Fogaca**

Student of **Analysis and Systems Development (ADS)**
Infnet – Instituto Infnet
Rio de Janeiro, Brazil

---

## Licence

This repository is for **educational purposes** as part of coursework at Infnet.
