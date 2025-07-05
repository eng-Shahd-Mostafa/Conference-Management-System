# 🎓 Conference Management System 

## 📖 Overview
This project is a powerful and easy-to-use Conference Management System built with C#. It provides 
a comprehensive set of features for managing conferences, attendees, sessions, and reports efficiently.

## 📦 Project Structure
The project includes various components organized into folders and files, covering different aspects of conference management. 
Below is a general description of the key components:

## 🧱 Key Components

### 📂 Models
- Contains data models representing entities like attendees, conferences, and sessions.  
- Ensures a structured representation of data using C# classes.

### 📁 Repos
- Handles data repository logic for storing and retrieving data.  
- Manages persistent storage operations efficiently.

### 📋 Forms & Interfaces

- 🎨 **AttendeeForm**: Manages attendee registration and updates.  
- 🎓 **ConferenceForm**: Handles creation and management of conferences.  
- 📊 **ConferenceReportForm**: Manages report generation and editing.  
- 🖥️ **Form1**: Main UI form for navigation.  
- 📝 **PaperForm**: Handles paper submissions and reviews.  
- 👥 **ParticipantForm**: Manages participant data and operations.  
- ⏯️ **SessionForm**: Handles session scheduling and updates.

### 🔧 Operations

- ➕ **CreateConference**: Logic for creating new conferences.  
- ➕ **CreateSession**: Logic for creating new sessions.  
- ❌ **DeleteConference**: Deletes existing conferences.  
- ❌ **DeleteSession**: Deletes existing sessions.  
- 🔄 **UpdateConference**: Updates data of existing conferences.  
- 🔄 **UpdateSession**: Updates session information.

### 🔍 Search & Utilities

- 🔎 **Search**: Search functionality across all core entities.  
- 🚀 **Program**: Main entry point of the application.


## 🌟 Features

- **OOP Design:** Modular structure with encapsulation, inheritance, and clean class separation.
- **Persistent Storage:** Data is saved and retrieved using file I/O (CSV/text files).
- **Menu-Driven Console Interface:** Simple user navigation through main options.
- **Error Handling:** Input validation and exception management to ensure data consistency.

---

## 🛠️ How to Run

1. Open the project in **Visual Studio** (2022 or later recommended).
2. Make sure all `.cs` files are part of the project.
3. Set the file with `Main()` as the startup object (e.g., `Program.cs`).
4. Run the application using `Start Debugging (F5)`.

---

## 🎯 Use Cases

- Academic conferences
- Tech meetups and summits
- Internal corporate events with scheduled speakers
