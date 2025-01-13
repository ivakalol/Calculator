# Calculator

A simple calculator application built using Windows Forms in C#. This calculator supports basic arithmetic operations such as addition, subtraction, multiplication, division, and percentage calculations. It also maintains a history of computations.

## Features

- Basic arithmetic operations: addition, subtraction, multiplication, division
- Percentage calculations
- Clear and delete functionalities
- Maintains a history of computations

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET Framework 4.7.2

### Installation

1. Clone the repository: 
```git clone https://github.com/yourusername/calculator.git```
2. Open the solution file `Calculator.sln` in Visual Studio 2022.

### Running the Application

1. Build the solution by clicking on `Build > Build Solution` or pressing `Ctrl+Shift+B`.
2. Run the application by clicking on `Debug > Start Debugging` or pressing `F5`.

## Usage

- **Number Buttons (0-9)**: Click to input numbers.
- **Operator Buttons (+, -, *, /)**: Click to perform arithmetic operations.
- **Equals Button (=)**: Click to compute the result of the operation.
- **Clear Button (C)**: Click to clear the current input and reset the calculator.
- **Delete Button (DEL)**: Click to remove the last character from the current input.
- **Decimal Point Button (.)**: Click to add a decimal point to the current input.
- **Percentage Button (%)**: Click to calculate the percentage.

## Code Overview

### Main Form (`Form1.cs`)

- **Variables**:
  - `resultValue`: Stores the result of the computation.
  - `operationPerformed`: Stores the current operation.
  - `num1`, `num2`: Stores the operands.
  - `isOperationPerformed`: Indicates if an operation is currently being performed.
  - `clearButton`, `newComputation`: Flags for managing input states.

- **Methods**:
  - `numberButton`: Handles number button clicks.
  - `point_Click`: Handles decimal point button clicks.
  - `operation`: Handles operator button clicks.
  - `delete_Click`: Handles delete button clicks.
  - `clear_Click`: Handles clear button clicks.
  - `equals_Click`: Handles equals button clicks and performs the computation.
  - `endOfComputation`: Resets the calculator state and updates the history.

### History

- The application maintains a history of computations, which is displayed in a `ListBox` named `History`.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.


