# Database Query Workbench (.NET 8, WinForms)

A lightweight, SSMS-style **ODBC** query client for Windows.  
Perfect for quick cross-database queries (SQL Server, IBM i / AS400, DB2, etc.) with **async execution**, **cancel**, **colored execution log**, and **image-aware result rendering** (shows real images when BLOBs are valid, otherwise “N bytes”).

![screenshot](docs/images/screenshot-1.png)

## ✨ Features
- ODBC connection string + **configurable timeout**
- **Execute (F5)** and **Cancel**
- **Colored** timestamped execution log
- Result grid:
  - Handles `SELECT` and **non-query** (rows affected)
  - Safe **BLOB** handling: show image preview if valid; else show byte size
  - Read-only, auto sizing, row count label
- Graceful error handling (no DataGridView popup storms)
- Keyboard: F5 (run), Ctrl+L (clear log)

## Getting Started
### Prereqs
- Windows, .NET 8 SDK (to build)
- An ODBC driver for your target DB:
  - SQL Server: “ODBC Driver 17/18 for SQL Server”
  - IBM i / AS400: “IBM i Access ODBC Driver”
  - DB2 LUW: “IBM DB2 ODBC DRIVER”

### Build & Run
```bash
git clone https://github.com/<you>/DatabaseQueryWorkbench.git
cd DatabaseQueryWorkbench/src/DatabaseQueryWorkbench
dotnet restore
dotnet build -c Release
dotnet run -c Release
