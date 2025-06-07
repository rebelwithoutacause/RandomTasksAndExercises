    # StringManipulator

A simple C# project demonstrating string manipulation with a focus on palindrome checking.

## Project Structure

- **StringManipulator** — Main library project containing string utility methods.  
- **StringManipulator.Tests** — MSTest unit test project validating the string utilities.

## Features

- Check if a string is a palindrome (ignoring spaces and case).  
- Unit tests verifying the correctness of the palindrome method.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- [Stryker.NET](https://stryker-mutator.io/docs/stryker-net/introduction/) (for mutation testing)

## How to Build and Test

Open a terminal in the project root (where the `.sln` file is) and run:

```bash
dotnet build
dotnet test
```

## Running Mutation Testing with Stryker.NET

Mutation testing helps assess the quality of your tests by introducing small changes ("mutants") in your code and verifying if tests catch them.

1. Install Stryker.NET globally (if not already):

```bash
dotnet tool install -g dotnet-stryker
```

2. Run mutation testing:

```bash
dotnet stryker
```

3. After completion, open the generated HTML report to see the results. The report path is printed in the terminal.

## Example Usage

```csharp
using StringManipulator;

bool result = StringUtilities.IsPalindrome("A man a plan a canal Panama");
Console.WriteLine(result); // Output: True
```

## Mutation Testing Results

- Mutation score: **88.89%**  
- All surviving mutants were killed by the unit tests.  
- Some mutants were skipped due to compile errors or lack of coverage.

## License

This project is licensed under the MIT License.

---

Created by Teodor Kostov for practicing unit and mutation testing.

    
