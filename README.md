# BankAccountOOP

A simple C# console application demonstrating **Object-Oriented Programming (OOP)** principles: **Encapsulation, Abstraction, Inheritance, and Polymorphism**.

---

## 📌 Overview

This project models a basic bank account system with two account types: **Current Account** and **Savings Account**. It is designed for educational purposes to illustrate core OOP concepts in C#.

## 🎯 OOP Principles Demonstrated

| Principle      | Definition                                                                                     | Goal                                                                                     | Implementation Example                                                                 |
|----------------|------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| **Encapsulation**  | Bundling data and methods, restricting direct access to some of the object's components. | Protect object integrity, prevent unintended interference, and provide controlled access. | `_balance` is protected; accessed via methods with validation.                        |
| **Abstraction**    | Hiding complex implementation, showing only necessary features. | Reduce complexity, improve maintainability, and allow for code reuse.                   | `IAccount` interface and `Account` abstract class.                                      |
| **Inheritance**    | New class inherits properties and behavior of an existing class.       | Promote code reuse, establish hierarchical relationships, and enable method overriding. | `CurrentAccount` and `SavingsAccount` inherit from `Account`.                          |
| **Polymorphism**   | Presenting the same interface for different underlying forms.            | Enable flexibility, simplify code, and allow for dynamic method binding.               | Overloaded `Deposit`, overridden `Withdraw`, interface-based processing in `ProcessAccounts`. |
