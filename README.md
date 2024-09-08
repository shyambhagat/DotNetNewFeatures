
# DotNetNewFeatures - Project

This repository contains a collection of C# projects demonstrating various new language features introduced in recent versions of .NET and C#. Each file covers a specific feature, providing practical examples to help you understand and apply them in real-world scenarios.

## Project List

### Caller Information Attributes
Demonstrates the use of caller information attributes like `CallerMemberName`, `CallerFilePath`, and `CallerLineNumber` to obtain information about the caller of a method.

### Property Improvements
Covers improvements to properties, including init-only setters, and features introduced to simplify and enhance property definitions.

### Null Conditional Operators
Shows how to use null-conditional operators (?. and ?[]) to safely access members and elements, preventing `NullReferenceException`.

### Exception Filter
Demonstrates exception filtering in C# using `when` clauses, allowing you to catch exceptions conditionally based on specific criteria.

### Tuples
Explores tuples, allowing you to return multiple values from a method, and covers the use of named tuples for better code readability.

### Pattern Matching
Covers pattern matching features introduced in recent versions of C#, including type patterns, switch expressions, and positional patterns.

### LocalFunctions
Shows how to define functions inside other functions using local functions, which can help in organizing code more clearly.

### RefReturns And Locals
Demonstrates the use of `ref` returns and `ref` locals, allowing methods to return references to variables and enabling modifications to be reflected in the caller.

### Expression Bodied Members.cs
Covers expression-bodied members, which allow you to define methods, properties, and other members using a concise syntax.

### Required Members.cs
Introduces the concept of required members, ensuring that certain properties must be initialized during object construction.

### Default Interface Methods
Shows how to use default interface methods, allowing you to provide a default implementation for methods in interfaces.

### Null Coalescing Assignment
Demonstrates the null-coalescing assignment operator (??=), which assigns a value to a variable if it is currently null.

### Switch Expressions
Explores switch expressions, which offer a more concise and expressive way to write switch statements.

### Records
Introduces record types, a new reference type for immutable data that comes with built-in value equality, useful for data transfer objects (DTOs).

### Init Only Properties
Covers init-only properties, which allow properties to be set only during object initialization, providing a safer alternative to mutable properties.

### With Expressions
Demonstrates the use of `with` expressions for non-destructive mutation of immutable objects, typically used with records.

### Target Typed New Expressions
Shows target-typed new expressions, which allow the omission of the type when creating an object if the type can be inferred from the context.

### Global Usings
Covers global usings, which enable you to declare common usings at a global level, reducing redundancy across multiple files in the project.

### File Scoped Namespace Declaration
Introduces file-scoped namespace declarations, providing a more concise syntax for declaring namespaces that apply to an entire file.

### Inline Type Members
Demonstrates inline initialization of type members, allowing fields and properties to be initialized directly in the type definition.

### Primary Constructors For Classes
Explores primary constructors, which allow you to define constructors directly in the class header, simplifying the class structure.

### Improved Lambda Syntax
Covers the improvements to lambda syntax, including the ability to specify return types and use more concise syntax.

### Additional Pattern Matching Enhancements
Demonstrates additional enhancements to pattern matching, including new patterns and more expressive matching capabilities.

### Goto Statement
Shows how to use the `goto` statement, typically for low-level control of program flow, though it is generally discouraged in favor of structured control statements.

### Digit Separators
Covers digit separators, which allow you to use underscores (_) in numeric literals for better readability of large numbers.

### Throw Expressions
Demonstrates throw expressions, which allow exceptions to be thrown in expression contexts, such as in conditional expressions.

### Switch Expressions
Explores string interpolation improvements, making it easier to format strings with embedded expressions.

## How to Use

Each file is self-contained and can be run individually. Open the solution in Visual Studio or any other IDE that supports .NET projects. Explore each file to see practical implementations of various new language features in C#.

Feel free to clone this repository and use the examples as a reference for your own learning or development projects.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
