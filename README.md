# Bird Breeding Facility Management System

This is a Windows Forms application developed using C# (.NET Framework) that provides a user-friendly interface for managing a bird breeding facility. It features a login screen and a complete set of tools for managing bird records and breeding data stored in an Excel file.

---

## Project Overview

Developed a desktop application for managing the operations of a bird breeding facility using C# and Windows Forms. The application utilizes an Excel file as the data storage medium, offering functionalities like user login, bird registration, breeding tracking, and data management in a portable format.

---

## Technologies Used

- C# (.NET Framework)
- Windows Forms
- Microsoft Excel (.xls / .xlsx) as the database
- OleDb (for Excel file connectivity)
- Visual Studio

---

## Getting Started

Follow the steps below to run the project on your local machine:

 1. Clone the Repository

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

