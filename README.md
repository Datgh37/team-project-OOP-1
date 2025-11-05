# 🏦 Bank Management System

A modern **C# OOP** project simulating a comprehensive banking system built with **.NET 8** and **WinForms**.  
Provides classes and utilities to manage customers, accounts, transactions, and data operations with a complete GUI.

---

## 📌 System Overview

### 🏗️ Architecture
- **Models**: Core business entities (Account, Customer, Transaction, AccountType)
- **Utils**: Management classes and helper utilities
- **Forms**: Windows Forms UI for user interaction
- **Data**: CSV-based persistent storage

---

## 🎯 Core Models

### 1️⃣ Account

Represents a single bank account with full transactional capabilities.

#### **Properties**
- `AccountNumber` *(string, read-only)*: Unique 5-digit account identifier (auto-incremented)
- `CustomerID` *(Guid, read-only)*: Owner's unique customer identifier
- `Balance` *(double, private set)*: Current account balance
- `InterestRate` *(double, private set)*: Current interest rate (0-20% based on account type)
- `OpenAt` *(DateTime, read-only)*: Account creation timestamp
- `Type` *(AccountType, read-only)*: Account type with rules and restrictions
- `AccountTypeName` *(string, computed)*: Human-readable type name

#### **Key Features**
- ✅ Create accounts with initial balance and specific type
- ✅ Deposit/Withdraw with comprehensive validation
- ✅ Apply interest calculation based on account type
- ✅ Support overdraft for Credit accounts (up to 20M VND limit)
- ✅ Automatic account number generation with seed management
- ✅ Copy constructor for safe cloning
- ✅ CSV serialization/deserialization support

#### **Interest Rate Limits**
- **Debit**: 0% - 0.5%
- **Credit**: 0% - 20%
- **Savings**: 0% - 6%

---

### 2️⃣ AccountType

Defines rules, permissions, and restrictions for account behavior.

#### **Enum: AccountTypeEnum**
```
Debit = 0    // Standard checking account
Credit = 1   // Credit card account with overdraft
Savings = 2  // Savings account (no transfers allowed)
```

#### **Properties**
- `Type` *(AccountTypeEnum, read-only)*: The account type enum value
- `AccType` *(string, computed)*: Type name as string
- `InterestRate` *(double, validated)*: Interest rate with type-specific limits
- `AllowOverdraft` *(bool)*: Whether negative balance is permitted
- `CreditLimit` *(double)*: Maximum overdraft amount (20M for Credit)
- `CanTransfer` *(bool)*: Whether transfers are allowed

#### **Type-Specific Rules**

| Type | Default Rate | Overdraft | Credit Limit | Can Transfer |
|------|-------------|-----------|--------------|--------------|
| **Debit** | 0.15% | ❌ No | 0 | ✅ Yes |
| **Credit** | 4% | ✅ Yes | 20,000,000 VND | ✅ Yes |
| **Savings** | 0.3% | ❌ No | 0 | ❌ No |

#### **Key Features**
- ✅ Custom interest rate support (within limits)
- ✅ Validated setter for InterestRate (throws on invalid values)
- ✅ Immutable type configuration after creation

---

### 3️⃣ Customer

Represents a bank customer with personal information and validation.

#### **Enum: Gender**
```
None = 0, Male = 1, Female = 2, Other = 3
```

#### **Properties**
- `UID` *(Guid, read-only)*: Unique customer identifier
- `CID` *(string, validated)*: 9-digit Citizen ID (optional, validated if provided)
- `FirstName` *(string)*: Customer's first name
- `LastName` *(string)*: Customer's last name
- `Address` *(string)*: Residential address
- `Email` *(string, validated)*: Email with format validation
- `Phone` *(string, validated)*: 10-digit phone number (optional)
- `BirthDate` *(DateTime)*: Date of birth
- `Gender` *(Gender enum)*: Gender identification

#### **Validation Rules**
- **CID**: Must be exactly 9 digits (if provided)
- **Email**: Must match pattern `[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}`
- **Phone**: Must be exactly 10 digits (if provided)

#### **Key Features**
- ✅ Automatic UID generation
- ✅ Input validation with descriptive error messages
- ✅ Multiple UpdateInfo() overloads for flexible updates
- ✅ Copy constructor for safe cloning
- ✅ CSV import/export support
- ✅ GetInfo() method for data extraction

---

### 4️⃣ Transaction

Records all banking transactions with complete audit trail.

#### **Enum: TransactionType**
```
Deposit = 0    // Money deposit to account
Withdraw = 1   // Money withdrawal from account
Transfer = 2   // Money transfer between accounts
```

#### **Properties**
- `TransactionID` *(string, auto-generated)*: Unique transaction GUID
- `FromAccountNumber` *(string, nullable)*: Source account (null for deposits)
- `Sender` *(string, nullable)*: Sender's full name
- `ToAccountNumber` *(string, nullable)*: Destination account (null for withdrawals)
- `Receiver` *(string, nullable)*: Receiver's full name
- `Amount` *(double)*: Transaction amount (must be > 0)
- `Type` *(TransactionType)*: Transaction type enum
- `TransactionTime` *(DateTime, auto)*: Transaction timestamp

#### **Key Features**
- ✅ Automatic ID and timestamp generation
- ✅ Type-specific validation (e.g., Transfer requires both accounts)
- ✅ Immutable after creation (audit integrity)
- ✅ CSV serialization/deserialization
- ✅ Support for all three transaction types

---

## 🛠️ Management Classes (Utils)

### 5️⃣ AccountManagement

Central hub for all account operations and business logic.

#### **Key Methods**

**CRUD Operations:**
- `AddAccount(Account)` - Add new account with duplicate/type checks
- `RemoveAccount(Account/string)` - Remove by reference or account number
- `FindByCustomerID(Guid)` - Get all accounts for a customer
- `FindByBalance(double/min,max)` - Search by exact or range
- `this[string]` - Indexer for quick account lookup

**Business Logic:**
- `HasAccountType(Guid, AccountTypeEnum)` - Check if customer has account type
- `GetAccountByCustomerAndType(Guid, AccountTypeEnum)` - Find specific account
- `ApplyInterestAll()` - Apply interest to all accounts
- `SortByBalance()` / `SortDescByBalance()` - Sorting methods

**Data Operations:**
- `ImportAccountListFromCSV(string?)` - Load from CSV with validation
- `SaveAccountsToCSV(string?)` - Export to CSV
- `GetTotalItemsInList()` - Count total accounts
- `GetTotalItemsEachAccountType()` - Get (debit, credit, savings) counts

#### **Key Features**
- ✅ One account per type per customer enforcement
- ✅ Automatic account number seed management
- ✅ Transaction-safe operations
- ✅ CSV integration with error handling

---

### 6️⃣ CustomerManagement

Manages customer records and relationships.

#### **Key Methods**

**CRUD Operations:**
- `AddCustomer(Customer)` - Add with UID/CID duplicate check
- `RemoveCustomer(Customer/Guid)` - Remove by reference or UID
- `FindById(Guid)` / `FindByCID(string)` - Search methods
- `this[Guid]` / `this[string]` - Indexers for lookup

**Data Operations:**
- `ImportCustomerListFromCSV(string?)` - Load customers
- `SaveCustomersToCSV(string?)` - Export customers
- `GetCustomerListFromCSV(string?)` - Get list without loading

#### **Key Features**
- ✅ UID and CID uniqueness enforcement
- ✅ Indexer for quick customer lookup by name
- ✅ Safe CSV operations with encoding support

---

### 7️⃣ TransactionManagement

Maintains transaction history and analytics.

#### **Key Methods**

**CRUD Operations:**
- `AddTransaction(Transaction)` - Record new transaction
- `ClearHistory()` - Clear all transaction history

**Query Methods:**
- `FindByAccount(string)` - Get all transactions for an account
- `FindByCustomer(string)` - Get all transactions for a customer name
- `FindByType(TransactionType)` - Filter by transaction type
- `FindByDateRange(DateTime, DateTime)` - Date range queries

**Analytics:**
- `GetStatistics(TransactionType)` - Returns (count, totalAmount) for type

**Data Operations:**
- `ImportTransactionListFromCSV(string?)` - Load transaction history
- `SaveTransactionListToCSV(string?)` - Export transaction history

#### **Key Features**
- ✅ Complete transaction audit trail
- ✅ Flexible querying and filtering
- ✅ Statistical analysis support
- ✅ CSV persistence

---

## 🧰 Utility Classes

### 8️⃣ myConvert

Comprehensive type conversion and CSV handling utilities.

#### **Conversion Methods**
- `ToInt(this string)` - String to integer
- `ToDouble(this string)` - String to double
- `ToFloat(this string)` - String to float
- `ToDecimal(this string)` - String to decimal
- `ToDateMonthYear(this string)` - Parse dd/MM/yyyy or dd-MM-yyyy
- `ToMonthDateYear(this string)` - Parse MM/dd/yyyy or MM-dd-yyyy
- `ToYearMonthDate(this string)` - Parse yyyy-MM-dd or yyyy/MM/dd

#### **CSV Operations**
- `ListToCSV<T>(this List<T>)` - Convert list to CSV string with headers
- `SaveCSV<T>(this List<T>, string?)` - Save list to CSV file
- `LoadCSV<T>(string)` - Load CSV file into list with reflection

#### **Key Features**
- ✅ Extension methods for fluent syntax
- ✅ Multiple date format support with time components
- ✅ Automatic CSV header generation from properties
- ✅ Smart property filtering (primitives, string, Guid, DateTime only)
- ✅ DateTime formatting to "dd-MM-yyyy" on export
- ✅ Guid formatting without hyphens
- ✅ CSV escape handling for commas and quotes
- ✅ Generic type support with reflection
- ✅ Enum parsing (supports both names and values)

---

### 9️⃣ myString

String manipulation and formatting utilities for Vietnamese names.

#### **Methods**
- `Standard(this string)` - Trim and remove extra spaces
- `Left(this string, int)` - Get leftmost n characters
- `Right(this string, int)` - Get rightmost n characters
- `Mid(this string, int, int)` - Get substring from index
- `Proper(this string)` - Capitalize first letter of each word
- `TachHoTen(this string)` - Split Vietnamese name (LastName, FirstName)
- `SplitFullName(this string)` - Split English name (FirstName, LastName)

#### **Key Features**
- ✅ Extension methods for natural syntax
- ✅ Vietnamese name format support (Họ Tên)
- ✅ Safe null/empty string handling
- ✅ Whitespace normalization

---

### 🔟 MoneyFmt (Internal Static Class)

Simple money formatting utility.

#### **Method**
- `Format(double?)` - Format amount as "X,XXX VND" (e.g., 1,000,000 VND)

---

## 🖥️ Windows Forms (UI Layer)

### 📋 FormMain

Primary data management interface with DataGridView.

#### **Key Features**
- ✅ Display all accounts in sortable grid
- ✅ Add/Edit/Delete operations via buttons/context menu
- ✅ Search/filter by account number, type, or customer ID
- ✅ Multi-column sorting (Account #, Balance, Interest Rate, Open Date, Type)
- ✅ Double-click to view full customer details
- ✅ Automatic refresh after data changes
- ✅ Statistics display (Total, Debit, Credit, Savings counts)
- ✅ Auto-save prompt on closing with unsaved changes
- ✅ Date formatting (dd/MM/yyyy) for OpenAt column

#### **Data Tracking**
- Maintains `initAccountList` snapshot for change detection
- `isChanged` flag for unsaved modifications
- `IsAccountListChanged()` method for deep comparison

---

### ➕ FormAdd

Form for creating new accounts and customers.

#### **Key Features**
- ✅ Dual mode: Standalone + Called from FormMain
- ✅ Auto-fill customer info when CID is entered (9 digits)
  - Green background: Customer found (fields locked)
  - Yellow background: New customer (fields unlocked)
- ✅ One account per type per customer validation
- ✅ Name verification against existing customer data
- ✅ Gender dropdown (None, Male, Female, Other)
- ✅ Account type selection (Debit, Credit, Savings)
- ✅ Credit account: Balance locked at 0
- ✅ Initial balance validation (non-negative)
- ✅ CID validation (9 digits, optional)
- ✅ Immediate CSV save in standalone mode
- ✅ Pass-through mode when called from FormMain (no save)

#### **Properties**
- `NewAccount` - Created account (for caller access)
- `NewCustomer` - Created/existing customer (for caller access)

---

### ✏️ FormEdit

Form for editing existing account and customer information.

#### **Key Features**
- ✅ Edit customer personal information (Name, CID, Address, Email, Phone, DoB, Gender)
- ✅ Edit account balance and interest rate
- ✅ Interest rate validation per account type
- ✅ Balance validation (respect overdraft rules)
- ✅ Name change warning (affects all customer accounts)
- ✅ Display account type (read-only)
- ✅ Cancel/Save with validation
- ✅ Returns updated objects via properties

#### **Properties**
- `SelectedAccount` - Modified account
- `SelectedCustomer` - Modified customer

#### **Name Change Logic**
- Tracks original name in constructor
- Shows confirmation dialog if name changed
- Warns that ALL accounts will be updated (via CustomerID link)

---

### 👤 FormCustomer

Read-only customer detail viewer with edit capability.

#### **Key Features**
- ✅ Display full customer information
- ✅ Display linked account details
- ✅ "Edit" button opens FormEdit
- ✅ Automatic UI refresh after editing
- ✅ Change detection on form closing
- ✅ Returns DialogResult.OK if data modified

#### **Properties**
- `SelectedAccount` - Displayed/edited account
- `SelectedCustomer` - Displayed/edited customer

---

### 💸 FormTransfer

Multi-mode transaction form (Transfer/Deposit/Withdraw).

#### **Key Features**

**Three Transaction Modes:**
1. **Transfer** - Money transfer between accounts
2. **Deposit** - Add money to an account
3. **Withdraw** - Remove money from an account

**Smart Account Lookup:**
- ✅ Auto-lookup when 5+ digits entered
- ✅ Display customer name, account type, balance (if applicable)
- ✅ Real-time validation on field leave

**Comprehensive Validation:**
- ✅ Account existence checks
- ✅ Balance sufficiency checks
- ✅ Credit limit validation (with detailed breakdown)
- ✅ Transfer permission checks (Savings accounts blocked)
- ✅ Same-account transfer prevention
- ✅ Amount validation (must be > 0)

**Transaction Flow:**
1. User fills in account numbers and amount
2. System validates all constraints
3. Confirmation dialog with transaction summary
4. Execute transaction (with rollback on error)
5. Save to CSV (accounts + transaction history)
6. Display FormBill receipt
7. Close form

**Error Handling:**
- ✅ Rollback to original balance on failure
- ✅ Detailed error messages with suggestions
- ✅ No partial transactions (atomic operations)

**Constructor Overloads:**
- `FormTransfer()` - Empty form
- `FormTransfer(Account)` - Pre-fill "From Account"

---

### 🧾 FormBill

Transaction receipt/invoice viewer.

#### **Key Features**
- ✅ Dynamic layout based on transaction type:
  - **Deposit**: Show only receiver info
  - **Withdraw**: Show only sender info
  - **Transfer**: Show both sender and receiver
- ✅ Display transaction ID, timestamp, amount, status
- ✅ Optional notes/description display
- ✅ Professional receipt format
- ✅ Print-ready layout

**Constructor Overloads:**
- `FormBill(Transaction)` - Basic receipt
- `FormBill(Transaction, string note)` - With custom note

**Layout Methods:**
- `ApplyModeLayout()` - Adjust UI for transaction type
- `HideRow(Panel)` / `ShowRow(Panel)` - Dynamic row visibility
- `PopulateTransaction()` - Fill in transaction details
- `HideNotes()` - Clear note section

---

### ⚡ FormFlash

Splash screen displayed on application startup.

#### **Key Features**
- ✅ Auto-close after timer interval
- ✅ Returns DialogResult.OK when timer expires
- ✅ Displays branding/logo

---

### 🔲 FormMenu (MDI Container) - Optional

Main application window (if using MDI architecture).

#### **Key Features**
- ✅ MDI Parent for child forms
- ✅ Menu bar with form shortcuts
- ✅ Window layout options (Cascade, Tile Horizontal/Vertical)
- ✅ Status bar with clock and status messages
- ✅ Single instance enforcement per form type
- ✅ Coordinated form closing with unsaved data checks

---

## 📁 Data Storage (CSV Files)

### GlobalSettings.cs

Centralized configuration for file paths and date formats.

```
public static class GlobalSettings
{
    public static readonly string AccountInfoPath;    // Data/AccountInfo.csv
    public static readonly string CustomerInfoPath;   // Data/CustomerInfo.csv
    public static readonly string TransactionInfoPath; // Data/TransactionInfo.csv
    
    public static string DateDMY { get; } = "dd/MM/yyyy";
    public static string DateMDY { get; } = "MM/dd/yyyy";
    public static string DateYMD { get; } = "yyyy-MM-dd";
}
```

### CSV File Formats

**AccountInfo.csv:**
```
AccountNumber,Balance,InterestRate,OpenAt,AccountTypeName,CustomerID
10001,1500000,0.15,25-12-2024,0,9cca2eb56f7644e1b0925ed0b70d30af
```

**CustomerInfo.csv:**
```
UID,CID,LastName,FirstName,Address,Email,Phone,BirthDate,Gender
9cca2eb56f7644e1b0925ed0b70d30af,123456789,Nguyen,Van A,Ha Noi,test@email.com,0912345678,01-01-1990,Male
```

**TransactionInfo.csv:**
```
TransactionID,FromAccountNumber,Sender,ToAccountNumber,Receiver,Amount,Type,TransactionTime
abc123-def456,10001,Nguyen Van A,10002,Tran Thi B,500000,Transfer,25-12-2024 14:30:00
```

---

## 🗂️ Project Structure

```
BankManagement/
│
├── 📂 Data/                          # CSV data files
│   ├── AccountInfo.csv
│   ├── CustomerInfo.csv
│   └── TransactionInfo.csv
│
├── 📂 Models/                        # Core business entities
│   ├── Account.cs                   # Account model with transactions
│   ├── AccountType.cs               # Account type rules & validation
│   ├── Customer.cs                  # Customer model with validation
│   └── Transaction.cs               # Transaction recording
│
├── 📂 Utils/                         # Business logic & utilities
│   ├── AccountManagement.cs         # Account CRUD & operations
│   ├── CustomerManagement.cs        # Customer CRUD & operations
│   ├── TransactionManagement.cs     # Transaction history & analytics
│   ├── myConvert.cs                 # Type conversion & CSV handling
│   └── myString.cs                  # String manipulation utilities
│
├── 📂 Forms/                         # Windows Forms UI
│   ├── FormMain.cs                  # Main data grid interface
│   ├── FormAdd.cs                   # Add account/customer
│   ├── FormEdit.cs                  # Edit account/customer
│   ├── FormCustomer.cs              # Customer detail viewer
│   ├── FormTransfer.cs              # Transaction form (3 modes)
│   ├── FormBill.cs                  # Transaction receipt
│   ├── FormFlash.cs                 # Splash screen
│   └── FormMenu.cs                  # MDI container (optional)
│
├── GlobalSettings.cs                 # Configuration & constants
├── Program.cs                        # Application entry point
└── README.md                         # This file
```

---

## ⚡ Key Features Summary

### 🏛️ **Core Banking Operations**
- ✅ Multiple account types (Debit, Credit, Savings) with distinct rules
- ✅ Interest rate management with validated limits
- ✅ Overdraft support for Credit accounts (20M VND limit)
- ✅ One account per type per customer enforcement
- ✅ Automatic account number generation

### 👥 **Customer Management**
- ✅ Complete personal information with validation
- ✅ CID (9 digits), Email, Phone validation
- ✅ Link multiple accounts to one customer
- ✅ Safe updates (name changes affect all accounts)

### 💰 **Transaction System**
- ✅ Three transaction types: Deposit, Withdraw, Transfer
- ✅ Comprehensive validation (balance, limits, permissions)
- ✅ Atomic operations with rollback on failure
- ✅ Complete audit trail in CSV
- ✅ Transaction receipts with dynamic layout

### 🖥️ **User Interface**
- ✅ Professional WinForms interface
- ✅ Real-time data validation and feedback
- ✅ Sortable/filterable data grid
- ✅ Auto-fill for efficiency (CID lookup)
- ✅ Unsaved changes detection and prompts
- ✅ Context-sensitive help messages

### 💾 **Data Management**
- ✅ CSV-based persistent storage (UTF-8)
- ✅ Automatic import/export with error handling
- ✅ Change tracking and auto-save prompts
- ✅ Data integrity validation on load

### 🔒 **Validation & Safety**
- ✅ Input validation at every layer
- ✅ Business rule enforcement (no transfers from Savings, etc.)
- ✅ Transaction rollback on failure
- ✅ Duplicate prevention (accounts, customers)
- ✅ Type-safe operations throughout

---

## 🚀 Quick Start

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022 (or compatible IDE)

### Running the Application

1. **Clone/Download** the repository
2. **Open** `BankManagement.sln` in Visual Studio
3. **Build** the solution (Ctrl+Shift+B)
4. **Run** (F5) - FormFlash will show, then FormMain

### First Time Setup
- CSV files will be created automatically in `bin/Debug/net8.0/Data/`
- Initial sample data can be loaded via FormAdd

---

## 🔧 Configuration

### Changing Data File Paths
Edit `GlobalSettings.cs` to customize CSV file locations.

### Date Format Settings
Three formats available in `GlobalSettings`:
- `DateDMY` - dd/MM/yyyy (Vietnamese standard)
- `DateMDY` - MM/dd/yyyy (US standard)
- `DateYMD` - yyyy-MM-dd (ISO standard)

---

## 📊 Business Rules Reference

### Account Type Restrictions

| Rule | Debit | Credit | Savings |
|------|-------|--------|---------|
| Initial Balance Required | ✅ Yes | ❌ No (locked at 0) | ✅ Yes |
| Allow Negative Balance | ❌ No | ✅ Yes (up to limit) | ❌ No |
| Can Transfer | ✅ Yes | ✅ Yes | ❌ No |
| Interest Rate Range | 0-0.5% | 0-20% | 0-6% |
| Overdraft Limit | 0 | 20,000,000 VND | 0 |

### Customer Account Rules
- ✅ One customer can have **up to 3 accounts** (one of each type)
- ✅ Cannot create duplicate account type for same customer
- ✅ Changing customer name affects **all linked accounts**
- ✅ Deleting customer requires no linked accounts (implement if needed)

---

## 🐛 Error Handling

### Common Error Scenarios
1. **Duplicate Account** - "Customer already has a [Type] account!"
2. **Insufficient Balance** - Detailed breakdown of shortfall
3. **Credit Limit Exceeded** - Shows current debt and available credit
4. **Invalid Format** - CID, Email, Phone validation errors
5. **CSV File Locked** - "Cannot write file" with suggested actions
6. **Interest Rate Out of Range** - Type-specific limit violation

### Error Recovery
- ✅ Transaction rollback on failure (atomic operations)
- ✅ Original balance restoration on error
- ✅ User-friendly error messages with suggestions
- ✅ Validation before saving (prevent invalid state)

---

## 🎓 Learning Objectives

This project demonstrates:
- ✅ **OOP Principles**: Encapsulation, Inheritance, Polymorphism, Abstraction
- ✅ **SOLID Principles**: Single Responsibility, Open/Closed, Dependency Inversion
- ✅ **Design Patterns**: Factory (AccountType), Repository (Management classes)
- ✅ **WinForms UI**: MDI, DataGridView, Custom Controls, Event Handling
- ✅ **Data Validation**: Input sanitization, Business rule enforcement
- ✅ **Error Handling**: Try-catch, Exception types, Rollback mechanisms
- ✅ **File I/O**: CSV parsing, Encoding, Reflection-based serialization
- ✅ **C# Features**: Extension methods, Enums, Properties, Indexers, Tuples

---

## 📝 Version History

### v2.0 (Current)
- ✅ Complete refactor with .NET 8
- ✅ Enhanced validation system
- ✅ Three-mode transaction form
- ✅ Auto-fill CID lookup
- ✅ Dynamic transaction receipt
- ✅ Improved error messages

### v1.0 (Initial)
- Basic account/customer management
- Simple transfer functionality
- CSV storage

---

## 👥 Contributors

**Team Project - OOP Course**
- Repository: https://github.com/Datgh37/team-project-OOP-1
- Branch: BaoBeo
- Branch: Datgh37
- Branch: Raumania

---

## 📄 License

Educational project - Free to use and modify for learning purposes.

---

## 🆘 Support & Contact

For questions, issues, or suggestions:
1. Check existing issues on GitHub
2. Create new issue with detailed description
3. Contact repository maintainers

---

**Last Updated**: January 2025  
**Built with**: C# 12.0, .NET 8, Windows Forms  
**Data Storage**: CSV files (UTF-8)

---

*For detailed code documentation, see inline XML comments in source files.*