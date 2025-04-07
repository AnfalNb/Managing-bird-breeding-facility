# Bird Breeding Facility Management System

## Overview
This Windows Forms application is designed to efficiently manage operations in a bird breeding facility. It includes comprehensive tools for user authentication, bird registration, breeding tracking, and storing data in an Excel file. The application is built using C# and the .NET Framework, ensuring robust functionality with a straightforward user interface. The core functionality relies on the Excel file as a portable database, managed via OleDb connectivity.

## Technologies Used

- **C# (.NET Framework)**: Backend programming language for implementing core functionalities.
- **Windows Forms**: GUI framework used for creating the application’s user interface.
- **Microsoft Excel (.xls / .xlsx)**: Used as a lightweight database for storing bird breeding data.
- **OleDb**: Data access technology used to interface with the Excel file, enabling read and write operations.
- **Visual Studio**: IDE used for development, debugging, and testing the application.
- **Microsoft Access Database Engine**: Required for Excel file connectivity with OleDb.

## Project Architecture

### 1. **User Interface (UI) - Windows Forms**
The application provides a simple yet functional interface built using **Windows Forms**. Each form is designed to handle a specific task, including login, bird data entry, and breeding history tracking. The forms are user-friendly, ensuring that users can easily manage and input data without needing advanced technical knowledge.

- **Login Form**: First point of entry, authenticates users before allowing them to access the system.
- **Bird Registration Form**: Allows input of bird details such as species, age, color, and breeding information.
- **Breeding Tracking Form**: Tracks the mating and offspring data of birds, helping the facility monitor breeding progress.
- **Data Management Form**: Enables exporting and importing data to and from the Excel database.

### 2. **Backend Logic - C# & OleDb**
The backend of the application handles the core logic, such as processing user input, managing bird records, and interacting with the Excel file (used as the database). Key components include:

- **Authentication**: Verifies users through a simple username/password combination, ensuring that only authorized personnel can access the system.
- **Excel Data Access**: 
    - The application uses **OleDb** to connect to the Excel file (BirdData.xlsx). This file acts as a lightweight, portable database.
    - The connection string is set as follows to work with the Excel file:
    ```csharp
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BirdData.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';"
    ```
    - The **OleDbConnection** class is used to open and interact with the Excel file, executing SQL-like queries for inserting, updating, and retrieving data.
- **Bird Data Management**: 
    - The system stores bird details like species, age, color, and breeding status in the Excel file.
    - When a new bird is registered, the data is saved in the corresponding Excel sheet.
    - Breeding records are linked to the respective birds, enabling the facility to track mating pairs and offspring.

### 3. **Database (Excel File)**
The data is stored in an Excel workbook (e.g., **BirdData.xlsx**), organized across different sheets. The Excel file serves as the data storage, and the application performs CRUD (Create, Read, Update, Delete) operations on this file. The key tables in the Excel file are:

- **Birds Table**: Contains records for each bird (ID, species, age, color, etc.).
- **Breeding Table**: Tracks mating pairs and their offspring.
- **User Table**: Stores user authentication data (username, password).

Example of data in the "Birds" sheet:

| BirdID | Species   | Age | Color  |
|--------|-----------|-----|--------|
| 001    | Parrot    | 2   | Green  |
| 002    | Finch     | 1   | Yellow |
| 003    | Sparrow   | 3   | Brown  |

Example of data in the "Breeding" sheet:

| BreedingID | BirdID_Female | BirdID_Male | DateMated | OffspringCount |
|------------|---------------|-------------|-----------|----------------|
| 001        | 001           | 002         | 2024-01-15| 3              |
| 002        | 002           | 003         | 2024-03-10| 2              |

### 4. **Excel File Management**
- **Data Storage**: The Excel file holds all the breeding data, bird records, and user information. The system provides an interface for users to import, update, or export data as necessary. This ensures data portability without requiring complex database management systems.
- **File Location**: The Excel file is stored within the project directory, typically in a folder called `Data`. The correct path is used when establishing the OleDb connection in the backend logic.

### 5. **Authentication and User Management**
The application requires users to authenticate before they can access the main functionalities. The authentication process is basic, relying on a static user table stored in the Excel file. User credentials are checked against this table when logging in.

Example login flow:
- The user enters their **username** and **password** in the login form.
- The system checks the credentials against the **User Table** in the Excel database.
- If the credentials are valid, the user is granted access to the main application interface.
- If invalid, an error message is displayed, prompting the user to retry.

## Features

### 1. **Bird Registration**
- Users can register new birds by entering details like species, age, and color.
- The bird’s information is saved to the **Birds Table** in the Excel file.

### 2. **Breeding Tracking**
- Users can track the mating pairs, including the date of mating and the number of offspring produced.
- Breeding records are stored in the **Breeding Table**, linking the female and male birds to the offspring count.

### 3. **User Authentication**
- Ensures that only authorized personnel can access sensitive data.
- Simple login system using stored username and password in the Excel file.

### 4. **Data Management**
- The system allows for data exports to external formats (e.g., CSV or Excel) for reporting or backup.
- Import functionality to load data into the system from pre-existing Excel files.

### 5. **Reporting**
- Generate reports on breeding success, bird age distribution, and other relevant statistics based on the data in the system.

## Installation

### Prerequisites
- **Microsoft Excel**: The application uses Excel as a database. Ensure that Excel is installed on your system.
- **Microsoft Access Database Engine**: Required for OleDb connectivity to the Excel file.

### Setup Instructions:
1. **Clone the repository**:
```bash
git clone https://github.com/YourUsername/YourRepositoryName.git
```
2. Open the Project
Open Visual Studio.

Click on File → Open → Project/Solution.

Navigate to the project folder and open the solution file (e.g., BirdBreedingFacility.sln).

3. Set Up Excel File as Database
Make sure the Excel file (e.g., BirdData.xlsx) is located in the appropriate folder in your project directory.

Check the connection string in your code (typically found in your data access class) to ensure it points to the correct file path and format.
```bash
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BirdData.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';"
```
Ensure Microsoft Access Database Engine is installed to support Excel connectivity.

4. Build and Run the Project
Press Ctrl + F5 to run without debugging, or F5 to run with debugging.

The application will launch from the login screen:
```bash
Application.Run(new LogIn());
```

