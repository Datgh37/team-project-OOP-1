# 🏦 Bank Management System

A modern **C# OOP** project simulating a comprehensive banking system built with **.NET 8** and **WinForms**.  
Provides classes and utilities to manage customers, accounts, transactions, and data operations with a complete GUI.

---

## 📌 System Overview

### 🏗️ Architecture
- **Models**: Core business entities (Account, Customer, Transaction, AccountType)
- **Utils**: Management classes, helper utilities, and extension methods
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
- `Email` *(string, validated)*: Email with format validation using MailAddress
- `Phone` *(string, validated)*: 10-digit phone number (optional)
- `BirthDate` *(DateTime, validated)*: Date of birth (minimum age: 15 years)
- `Gender` *(Gender enum)*: Gender identification

#### **Validation Rules**
- **CID**: Must be exactly 9 digits (if provided)
- **Email**: Validated using System.Net.Mail.MailAddress
- **Phone**: Must be exactly 10 digits (if provided)
- **BirthDate**: Must be at least 15 years old, cannot be in future, maximum 150 years old

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
- `GetTransType` *(string, computed)*: Type as string

#### **Key Features**
- ✅ Automatic ID and timestamp generation
- ✅ Type-specific validation (e.g., Transfer requires both accounts)
- ✅ Immutable after creation (audit integrity)
- ✅ CSV serialization/deserialization with dual format support (enum name/value)
- ✅ Support for all three transaction types

---

## 🛠️ Management Classes (Utils)

### 5️⃣ AccountManagement

Central hub for all account operations and business logic.

#### **Key Methods**

**CRUD Operations:**
- `AddAccount(Account)` - Add new account with duplicate/type checks
- `RemoveAccount(Account/string)` - Remove by reference or account number
- `ClearList()` - Clear all accounts from list
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
- `GetAccountListFromCSV(string?)` - Get list without loading
- `GetTotalItemsInList()` - Count total accounts
- `GetTotalItemsEachAccountType()` - Get (debit, credit, savings) counts

#### **Key Features**
- ✅ One account per type per customer enforcement
- ✅ Automatic account number seed management
- ✅ Transaction-safe operations
- ✅ CSV integration with error handling
- ✅ Line-by-line error tracking during import

---

### 6️⃣ CustomerManagement

Manages customer records and relationships.

#### **Key Methods**

**CRUD Operations:**
- `AddCustomer(Customer)` - Add with UID/CID duplicate check
- `RemoveCustomer(Customer/Guid)` - Remove by reference or UID
- `ClearList()` - Clear all customers from list
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

Maintains transaction history and analytics with filtering capabilities.

#### **Key Methods**

**CRUD Operations:**
- `AddTransaction(Transaction)` - Record new transaction
- `ClearHistory()` - Clear all transaction history

**Query Methods:**
- `UpdateFilteredTransaction(string)` - Filter transactions by account number
- `ResetFilter()` - Show all transactions
- `FindByAccount(string)` - Get all transactions for an account
- `FindByCustomer(string)` - Get all transactions for a customer name
- `FindByType(TransactionType)` - Filter by transaction type
- `FindByDateRange(DateTime, DateTime)` - Date range queries

**Analytics:**
- `GetTotalItemsInList(bool all)` - Count filtered or all transactions
- `GetTotalItemsEachTransactionType(bool all)` - Returns (deposit, withdraw, transfer) counts

**Data Operations:**
- `ImportTransactionListFromCSV(string?)` - Load transaction history with line tracking
- `SaveTransactionListToCSV(string?)` - Export transaction history

#### **Key Features**
- ✅ Dual-list system (filtered + all transactions)
- ✅ Dynamic filtering for account-specific history
- ✅ Complete transaction audit trail
- ✅ Flexible querying and filtering
- ✅ Statistical analysis support
- ✅ CSV persistence
- ✅ Error tracking during import

---

### 8️⃣ AccountExtensions

Extension methods for Account transactions with automatic Transaction creation.

#### **Extension Methods**
- `Deposit(this Account, Customer, double)` - Deposit with Transaction record
- `Withdraw(this Account, Customer, double)` - Withdraw with Transaction record
- `Transfer(this Account, Account, Customer, Customer, double)` - Transfer with validation

#### **Key Features**
- ✅ Automatic Transaction object creation
- ✅ Comprehensive validation logic
- ✅ Same-account transfer prevention
- ✅ Transfer permission checks (Savings blocked)
- ✅ Credit limit validation
- ✅ Balance sufficiency checks
- ✅ Returns Transaction object for recording

**Example Usage:**
```
// Deposit
Transaction depositTrans = account.Deposit(customer, 1000000);

// Withdraw
Transaction withdrawTrans = account.Withdraw(customer, 500000);

// Transfer
Transaction transferTrans = fromAccount.Transfer(toAccount, sender, receiver, 250000);
```

---

### 9️⃣ myConvert

Comprehensive type conversion and CSV handling utilities.

#### **Conversion Methods**
- `ToInt(this string)` - String to integer
- `ToDouble(this string)` - String to double
- `ToFloat(this string)` - String to float
- `ToDecimal(this string)` - String to decimal
- `ToDateMonthYear(this string)` - Parse dd/MM/yyyy or dd-MM-yyyy (with time support)
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
- ✅ DateTime formatting to "dd-MM-yyyy HH:mm:ss" on export
- ✅ Guid formatting without hyphens
- ✅ CSV escape handling for commas and quotes
- ✅ Generic type support with reflection
- ✅ Enum parsing (supports both names and values)

---

### 🔟 myString

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

### 1️⃣1️⃣ MoneyFmt (Internal Static Class)

Simple money formatting utility.

#### **Method**
- `Format(double?)` - Format amount as "X,XXX VND" (e.g., 1,000,000 VND)

---

## 🖥️ Windows Forms (UI Layer)

### 📋 FormMain

Primary data management interface with dual DataGridView (accounts + transaction history).

#### **Key Features**

**Main Grid (dgvMain):**
- ✅ Display all accounts in sortable grid
- ✅ Add/Edit/Delete operations via buttons
- ✅ Search/filter by account number, type, or customer ID
- ✅ Multi-column sorting (Account #, Balance, Interest Rate, Open Date, Type)
- ✅ Double-click to view full customer details (FormCustomer)
- ✅ Automatic refresh after data changes
- ✅ Statistics display (Total, Debit, Credit, Savings counts)
- ✅ Auto-save prompt on closing with unsaved changes
- ✅ Date formatting (dd/MM/yyyy) for OpenAt column

**Transaction History Grid (dgvSub):**
- ✅ Dynamic transaction history loading by account
- ✅ Click any account row to load its transactions
- ✅ Double-click transaction to view receipt (FormBill)
- ✅ Real-time statistics (Total, Deposit, Withdraw, Transfer counts)
- ✅ Account number display above grid
- ✅ Automatic clearing when account deleted

**Data Management:**
- ✅ Maintains `initAccountList` snapshot for change detection
- ✅ `isChanged` flag for unsaved modifications
- ✅ `IsAccountListChanged()` method for deep comparison
- ✅ Reload mechanism after FormTransaction closes

#### **Transaction Button:**
- Opens `FormTransaction` for creating deposits/withdrawals/transfers
- Automatically reloads all data after transaction completes
- Clears transaction history view after reload

---

### ➕ FormAdd

Form for creating new accounts and customers with intelligent CID lookup.

#### **Key Features**

**Dual Mode Operation:**
- ✅ Standalone mode: Direct CSV save after creation
- ✅ Called from FormMain: Pass-through mode (no auto-save)

**CID Auto-Fill System:**
- ✅ Automatically queries when 9 digits entered
- ✅ **Green background**: Customer found (fields locked)
- ✅ **Yellow background**: New customer (fields unlocked)
- ✅ Auto-populate name, DoB, gender from existing customer
- ✅ Lock/unlock fields based on customer existence

**Validation & Business Rules:**
- ✅ One account per type per customer validation
- ✅ Name verification against existing customer data
- ✅ Duplicate account type detection with detailed error message
- ✅ Gender dropdown (None, Male, Female, Other)
- ✅ Account type selection (Debit, Credit, Savings)
- ✅ Credit account: Balance locked at 0
- ✅ Initial balance validation (non-negative)
- ✅ CID validation (9 digits, optional)

**Smart Reference Management:**
- ✅ Uses shared reference when called from FormMain (no copy)
- ✅ Creates new instances in standalone mode
- ✅ Exposes `NewAccount` and `NewCustomer` properties

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
- ✅ Display full customer information (UID, CID, Name, Address, Email, Phone, DoB, Gender)
- ✅ Display linked account details
- ✅ "Edit" button opens FormEdit
- ✅ Automatic UI refresh after editing
- ✅ Change detection on form closing
- ✅ Returns DialogResult.OK if data modified

#### **Change Detection:**
- Compares original vs current state for Account and Customer
- Detects changes to balance, interest rate, or any customer field

#### **Properties**
- `SelectedAccount` - Displayed/edited account
- `SelectedCustomer` - Displayed/edited customer

---

### 💸 FormTransaction

Multi-mode transaction form (Transfer/Deposit/Withdraw) - **Referenced in FormMain**.

> **Note:** The actual `FormTransaction` class was not found in the provided files, but it is referenced in `FormMain` and `FormMenu`. Based on context, it should provide:

#### **Expected Features**
- ✅ Three transaction modes (Transfer, Deposit, Withdraw)
- ✅ Smart account lookup (5+ digits)
- ✅ Comprehensive validation (balance, limits, permissions)
- ✅ Transaction confirmation dialog
- ✅ Atomic operations with rollback on failure
- ✅ Automatic CSV save (accounts + transactions)
- ✅ Opens FormBill for receipt display
- ✅ Uses `AccountExtensions` methods for transaction logic

---

### 🧾 FormBill

Transaction receipt/invoice viewer with dynamic layout.

#### **Key Features**

**Dynamic Layout System:**
- ✅ **Deposit**: Show only receiver info (hides sender row)
- ✅ **Withdraw**: Show only sender info (hides receiver row)
- ✅ **Transfer**: Show both sender and receiver
- ✅ Automatic row hiding with `HideRow()` / `ShowRow()`
- ✅ TableLayoutPanel dynamic height adjustment

**Display Information:**
- ✅ Transaction ID and timestamp
- ✅ Sender/Receiver names and account numbers
- ✅ Amount with VND formatting
- ✅ Transaction type and status
- ✅ Optional notes/description display

**Constructor Overloads:**
- `FormBill(Transaction)` - Basic receipt
- `FormBill(Transaction, string? note)` - With custom note

**Layout Methods:**
- `ApplyModeLayout()` - Adjust UI for transaction type
- `HideRow(Panel)` - Completely hide panel and collapse row height
- `ShowRow(Panel)` - Restore panel visibility and auto-size row
- `PopulateTransaction()` - Fill in transaction details
- `HideNotes()` - Clear note section

#### **Technical Implementation:**
- Sets panel `Visible` property
- Manipulates TableLayoutPanel row styles (Absolute 0 vs AutoSize)
- Uses `SuspendLayout()` / `ResumeLayout()` for smooth rendering

---

### ⚡ FormFlash

Splash screen displayed on application startup.

#### **Key Features**
- ✅ Auto-close after timer interval (timer1_Tick)
- ✅ Returns DialogResult.OK when timer expires
- ✅ Displays branding/logo
- ✅ Sets ActiveControl to null on load (prevents focus issues)

---

### 🔲 FormMenu (MDI Container)

Main application window using MDI architecture.

#### **Key Features**

**MDI Management:**
- ✅ MDI Parent for child forms
- ✅ Menu bar with form shortcuts (tsmiMainForm, tsmiAddForm, tsmiTransactionForm)
- ✅ Window layout options (Cascade, Tile Horizontal/Vertical)
- ✅ Single instance enforcement per form type
- ✅ Coordinated form closing with unsaved data checks

**Status Bar:**
- ✅ Real-time clock display (updates every second)
- ✅ Status messages (shows which form is opened)
- ✅ Date/time format: "yyyy-MM-dd HH:mm:ss"

**Smart Form Opening:**
- ✅ `OpenChild<TForm>()` generic method
- ✅ Activates existing form if already open
- ✅ Opens new form if not exists
- ✅ Automatically opens FormMain on startup

**Icon Handling:**
- ✅ Updates menu icon when child form is maximized

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
- AccountTypeName stored as integer (0=Debit, 1=Credit, 2=Savings)
- DateTime stored as "dd-MM-yyyy"
- CustomerID stored without hyphens

**CustomerInfo.csv:**
```
UID,CID,LastName,FirstName,Address,Email,Phone,BirthDate,Gender
9cca2eb56f7644e1b0925ed0b70d30af,123456789,Nguyen,Van A,Ha Noi,test@email.com,0912345678,01-01-1990,Male
```
- Gender stored as enum name (Male, Female, Other, None)

**TransactionInfo.csv:**
```
TransactionID,FromAccountNumber,Sender,ToAccountNumber,Receiver,Amount,Type,TransactionTime
abc123-def456,10001,Nguyen Van A,10002,Tran Thi B,500000,Transfer,25-12-2024 14:30:00
```
- Type stored as integer (0=Deposit, 1=Withdraw, 2=Transfer)
- Supports both enum name and value during parsing
- DateTime with time component support

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
│   ├── AccountExtensions.cs         # Extension methods for transactions
│   ├── CustomerManagement.cs        # Customer CRUD & operations
│   ├── TransactionManagement.cs     # Transaction history & analytics
│   ├── myConvert.cs                 # Type conversion & CSV handling
│   └── myString.cs                  # String manipulation utilities
│
├── 📂 Forms/                         # Windows Forms UI
│   ├── FormMain.cs                  # Main data grid interface (dual grid)
│   ├── FormAdd.cs                   # Add account/customer (CID auto-fill)
│   ├── FormEdit.cs                  # Edit account/customer
│   ├── FormCustomer.cs              # Customer detail viewer
│   ├── FormTransaction.cs           # Transaction form (3 modes)
│   ├── FormBill.cs                  # Transaction receipt (dynamic layout)
│   ├── FormFlash.cs                 # Splash screen
│   └── FormMenu.cs                  # MDI container
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
- ✅ Extension methods for clean transaction code

### 👥 **Customer Management**
- ✅ Complete personal information with validation
- ✅ CID (9 digits), Email, Phone validation
- ✅ Age validation (minimum 15 years, maximum 150 years)
- ✅ Link multiple accounts to one customer
- ✅ Safe updates (name changes affect all accounts)
- ✅ Smart CID lookup with auto-fill

### 💰 **Transaction System**
- ✅ Three transaction types: Deposit, Withdraw, Transfer
- ✅ Comprehensive validation (balance, limits, permissions)
- ✅ Atomic operations with rollback on failure
- ✅ Complete audit trail in CSV
- ✅ Transaction receipts with dynamic layout
- ✅ Real-time transaction history per account
- ✅ Dual-list filtering system

### 🖥️ **User Interface**
- ✅ Professional WinForms interface with MDI
- ✅ Real-time data validation and feedback
- ✅ Sortable/filterable data grid
- ✅ CID auto-fill with color coding (green/yellow)
- ✅ Transaction history viewer in FormMain
- ✅ Unsaved changes detection and prompts
- ✅ Dynamic form layout based on context
- ✅ Context-sensitive help messages

### 💾 **Data Management**
- ✅ CSV-based persistent storage (UTF-8)
- ✅ Automatic import/export with error handling
- ✅ Change tracking and auto-save prompts
- ✅ Data integrity validation on load
- ✅ Line-by-line error tracking during import
- ✅ Dual-format support (enum names and values)
- ✅ List clearing for safe reloads

### 🔒 **Validation & Safety**
- ✅ Input validation at every layer
- ✅ Business rule enforcement (no transfers from Savings, etc.)
- ✅ Transaction rollback on failure
- ✅ Duplicate prevention (accounts, customers)
- ✅ Type-safe operations throughout
- ✅ Extension method validation

---

## 🚀 Quick Start

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022 (or compatible IDE)

### Running the Application

1. **Clone/Download** the repository
```
   git clone https://github.com/Datgh37/team-project-OOP-1
   cd BankManagement
```

2. **Open** `BankManagement.sln` in Visual Studio

3. **Build** the solution (Ctrl+Shift+B)

4. **Run** (F5) - Application flow:
- FormFlash (splash screen) appears
- After timer expires, FormMenu opens
- FormMain automatically opens as MDI child

### First Time Setup
- CSV files will be created automatically in `bin/Debug/net8.0/Data/`
- Initial sample data can be added via FormAdd
- Data persists across application restarts

---

## 🔧 Configuration

### Changing Data File Paths
Edit `GlobalSettings.cs` to customize CSV file locations:
```
public static readonly string AccountInfoPath = Path.Combine("Data", "AccountInfo.csv");
```

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
- ✅ Minimum age: **15 years**
- ✅ Maximum age: **150 years**
- ✅ CID is optional but must be 9 digits if provided

---

## 🐛 Error Handling

### Common Error Scenarios
1. **Duplicate Account** - "Customer already has a [Type] account! Each customer can only have one account of each type."
2. **Insufficient Balance** - Detailed breakdown of shortfall
3. **Credit Limit Exceeded** - Shows current debt and available credit
4. **Invalid Format** - CID, Email, Phone validation errors with specific messages
5. **CSV File Locked** - "Cannot write file" with suggested actions
6. **Interest Rate Out of Range** - Type-specific limit violation
7. **Name Mismatch** - Shows existing vs entered name when CID lookup fails
8. **CSV Parsing Error** - Line number tracking for debugging

### Error Recovery
- ✅ Transaction rollback on failure (atomic operations)
- ✅ Original balance restoration on error
- ✅ User-friendly error messages with suggestions
- ✅ Validation before saving (prevent invalid state)
- ✅ Detailed error context in exception messages

---

## 🎓 Learning Objectives

This project demonstrates:
- ✅ **OOP Principles**: Encapsulation, Inheritance, Polymorphism, Abstraction
- ✅ **SOLID Principles**: Single Responsibility, Open/Closed, Dependency Inversion
- ✅ **Design Patterns**: Extension Methods, Repository Pattern, MDI Pattern
- ✅ **WinForms UI**: MDI, DataGridView, Dynamic Layout, Event Handling
- ✅ **Data Validation**: Input sanitization, Business rule enforcement
- ✅ **Error Handling**: Try-catch, Exception types, Rollback mechanisms
- ✅ **File I/O**: CSV parsing, Encoding, Reflection-based serialization
- ✅ **C# Features**: Extension methods, Enums, Properties, Indexers, Tuples, Nullable types
- ✅ **State Management**: Change tracking, Dual-list patterns, Reference vs Copy

---

## 📝 Version History

### v2.1 (Current - November 2024)
- ✅ Added AccountExtensions with transaction methods
- ✅ Implemented transaction history viewer in FormMain
- ✅ Dynamic FormBill layout based on transaction type
- ✅ CID auto-fill with color coding in FormAdd
- ✅ Dual-list filtering in TransactionManagement
- ✅ Enhanced error tracking with line numbers
- ✅ Age validation for customers (15-150 years)
- ✅ ClearList methods for safe data reloading
- ✅ Improved reference management in FormAdd
- ✅ Enhanced CSV parsing with dual-format enum support

### v2.0
- ✅ Complete refactor with .NET 8
- ✅ Enhanced validation system
- ✅ Three-mode transaction form
- ✅ Improved error messages

### v1.0 (Initial)
- Basic account/customer management
- Simple transfer functionality
- CSV storage

---

## 👥 Contributors

**Team Project - OOP Course**
- Repository: https://github.com/Datgh37/team-project-OOP-1
- **Branch: BaoBeo** - Main development
- **Branch: Datgh37** - Core features
- **Branch: Raumania** - UI enhancements

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

**Last Updated**: November 2024  
**Built with**: C# 12.0, .NET 8, Windows Forms  
**Data Storage**: CSV files (UTF-8)  
**Target Framework**: .NET 8.0

---

*For detailed code documentation, see inline XML comments in source files.*