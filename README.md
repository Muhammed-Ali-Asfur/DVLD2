# 🚗 Digital Vehicle & Driver Licensing System

**A layered desktop application built with Windows Forms** for managing vehicle registration and driver licensing processes. Database operations are optimized with ADO.NET, and full auditability is achieved through Windows Registry and Event Log integration.

---

## ✨ Features

- 🚙 **Vehicle Registration Management** — Register, update, and track vehicle records
- 🪪 **Driver Licensing Workflow** — Manage the full driver licensing lifecycle
- 🗄️ **Optimized Data Access** — Direct, high-performance database operations via ADO.NET
- 🧱 **Three-Layer Architecture** — Clear separation between UI, business logic, and data access
- 📝 **Windows Event Log Integration** — System-level auditability and traceability of operations
- 🔧 **Windows Registry Integration** — Persistent application configuration and settings management

---

## 🛠️ Tech Stack

| Layer | Technologies |
|---|---|
| **Application** | .NET Framework (C#), Windows Forms |
| **Database** | SQL Server, T-SQL, ADO.NET |
| **Architecture** | Three-Layer (Katmanlı) Architecture |
| **System Integration** | Windows Registry, Windows Event Log |

---

## 🏗️ Architecture

This project follows a **three-layer architecture**, separating presentation from business rules and data access:

```
VehicleLicensingSystem/
├── Presentation Layer     → Windows Forms (UI)
├── Business Layer         → Business Rules, Validation
└── Data Access Layer      → ADO.NET, T-SQL Queries/Procedures
```

---

## 🔍 System Integration Highlights

- **Windows Event Log** — Key operations (registrations, licensing actions, errors) are logged at the OS level, enabling traceability and easier diagnostics in production environments
- **Windows Registry** — Application settings are persisted at the system level, allowing configuration to survive across sessions without relying on external config files

---

## 🚀 Getting Started

### Prerequisites
- .NET Framework (compatible version installed)
- SQL Server
- Visual Studio 2019/2022

### Installation

```bash
# Clone the repository
git clone https://github.com/Muhammed-Ali-Asfur/DVLD2.git


# Navigate to the project directory
cd VehicleLicensingSystem

# Restore the database
# Run the provided .sql script(s) against your SQL Server instance

# Open the solution in Visual Studio and build
```

> 💡 Update the connection string in the app configuration file before running. Some features (Event Log, Registry) may require running with appropriate Windows permissions.

---

## 📬 Contact

Feel free to reach out or open an issue if you have questions or suggestions.

---

⭐ If you found this project useful, consider giving it a star!
