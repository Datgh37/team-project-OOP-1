# 🏦 Bank Management

A modern **C# OOP** project simulating a basic banking system.  
It provides classes and utilities to manage customers, accounts, transactions, and data operations.

---

## 📌 Overview

### 1️⃣ Account

Represents a single bank account.

- **Properties**
  - `AccountNumber` *(string, read-only)*: Unique account number.
  - `CustomerID` *(Guid, read-only)*: Owner's customer ID.
  - `Owner` *(string, private set)*: Account owner’s name.
  - `Balance` *(double, private set)*: Current balance.
  - `InterestRate` *(double, private set)*: Current interest rate, default by account Type.
  - `OpenAt` *(DateTime, read-only)*: Date and time the account was created.
  - `Type` *(AccountType, read-only)*: Account type (rules, permissions).

- **Key Features**
  - Create accounts with initial balance and type.
  - Deposit / Withdraw with validation.
  - Apply interest to balance.
  - Support for overdraft and credit limit (via AccountType).

---

### 2️⃣ AccountType

Defines rules and permissions for an account.

- **Properties**
  - `AccType` *(string)*: Type name (e.g., Savings, Checking).
  - `CanTransfer` *(bool)*: Allow money transfer.
  - `AllowOverdraft` *(bool)*: Allow negative balance.
  - `CreditLimit` *(double)*: Maximum overdraft allowed.
  - `InterestRate` *(double)*: Interest rate for this type of account.

- **Key Features**
  - Configure account behavior and restrictions.
  - Used to validate transactions and interest application.

---

### 3️⃣ Customer

Represents a bank customer.

- **Properties**
  - `UID` *(Guid, read-only)*: Unique customer identifier.
  - `CID` *(string)*: Customer’s Citizen ID.
  - `FirstName` *(string)*: Customer’s first name.
  - `LastName` *(string)*: Customer’s last name.
  - `Email` *(string)*: Contact email.
  - `Phone` *(string)*: Contact phone.
  - `Address` *(string)*: Customer address.
  - `FullName` *(DateTime)*: Customer’s DoB.
	- 
- **Key Features**
  - Store and manage customer information.
  - Link to multiple accounts.

---

### 4️⃣ Transaction

Records a single transaction (deposit, withdrawal, transfer).

- **Properties**
  - `TransactionID` *(Guid, read-only)*: Unique transaction identifier.
  - `FromAccount` *(string)*: Source account number.
  - `ToAccount` *(string)*: Destination account number (if transfer).
  - `Amount` *(double)*: Transaction amount.
  - `Type` *(TransactionType)*: Deposit, Withdraw, or Transfer (Enum defined).
  - `TransactionTime- Timestamp` *(DateTime)*: Date and time of transaction.

- **Key Features**
  - Track all account activities.
  - Support for transaction history and auditing.

---

### 5️⃣ AccountManagement

Manages all bank accounts and transactions.

- **Properties**
  - `_accounts` *(List<Account>)*: Internal list of all accounts.
  - `_transactions` *(List<Transaction>)*: Internal list of all transactions.

- **Key Features**
  - Add, remove, and search accounts (by customer, balance, etc.).
  - Deposit, withdraw, and transfer funds with validation.
  - Apply interest to all accounts.
  - Load account data from CSV files.
  - Sort accounts by balance.
  - Transaction history management.
  - Indexer for account lookup by account number.

---

### 6️⃣ CustomerManagement

Manages all customer records.

- **Properties**
  - `_customers` *(List<Customer>)*: Internal list of all customers.

- **Key Features**
  - Add, remove, update, and search customers.
  - Link customers to accounts.
  - Load and save customer data from/to CSV files.

---

### 7️⃣ Utilities

- **myConvert**: Data conversion helpers (string ↔ number/date, CSV serialization).
- **myString**: String formatting, name parsing, and normalization.
- **MoneyFmt**: Formats numbers as currency strings.

---

## 🗂️ Project Folder Structure

BankManagement/
│
├── Data/
│   ├── AccountInfo.csv
│   ├── CustomerInfo.csv
│   └── TransactionInfo.csv
│
├── Models/
│   ├── Account.cs
│   ├── AccountType.cs
│   ├── Customer.cs
│   └── Transaction.cs
│
├── Utils/
│   ├── AccountManagement.cs
│   ├── CustomerManagement.cs
│   ├── myConvert.cs
│   └── myString.cs
│
├── Forms/
│   ├── FormMain.cs
│   ├── FormFlash.cs
│   ├── FormAdd.cs
│   ├── FormEdit.cs
│   ├── FormTransaction.cs
│   └── FormTransactionBill.cs
│
├── GlobalSettings.cs
├── Program.cs
├── README.md
└── UML Graph.mdj

---

## ⚡ Key Features

- **Customer & Account Management**  
  Add, remove, update, and search customers and accounts.  
  Link accounts to customers.

- **Transaction Management**  
  Deposit, withdraw, transfer funds with validation and transaction history.

- **Interest Calculation**  
  Apply interest to all accounts based on account type and global rate.

- **Data Import/Export**  
  Load and save account/customer data from/to CSV files.

- **Utilities**  
  String and data conversion helpers for robust, error-resistant operations.

---

*See source code for detailed usage, extension points, and further documentation.*

---

# 🏦 Quản Lý Ngân Hàng

Một dự án **C# OOP** hiện đại mô phỏng hệ thống ngân hàng cơ bản.  
Cung cấp các lớp và tiện ích để quản lý khách hàng, tài khoản, giao dịch và xử lý dữ liệu.

---

## 📌 Tổng Quan

### 1️⃣ Account (Tài khoản)

Đại diện cho một tài khoản ngân hàng.

- **Thuộc tính**
  - `AccountNumber` *(string, chỉ đọc)*: Số tài khoản duy nhất.
  - `CustomerID` *(Guid, chỉ đọc)*: Mã khách hàng sở hữu.
  - `Owner` *(string, private set)*: Tên chủ tài khoản.
  - `Balance` *(double, private set)*: Số dư hiện tại.
  - `InterestRate` *(double, private set)*: Lãi suất hiện tại, mặc định theo loại tài khoản.
  - `OpenAt` *(DateTime, chỉ đọc)*: Thời điểm mở tài khoản.
  - `Type` *(AccountType, chỉ đọc)*: Loại tài khoản (quy tắc, quyền hạn).

- **Chức năng chính**
  - Tạo tài khoản với số dư và loại tài khoản ban đầu.
  - Gửi tiền / Rút tiền với kiểm tra hợp lệ.
  - Tính lãi cho số dư.
  - Hỗ trợ thấu chi và hạn mức tín dụng (qua AccountType).

---

### 2️⃣ AccountType (Loại tài khoản)

Định nghĩa quy tắc và quyền hạn cho tài khoản.

- **Thuộc tính**
  - `AccType` *(string)*: Tên loại (ví dụ: Tiết kiệm, Thanh toán).
  - `CanTransfer` *(bool)*: Cho phép chuyển tiền.
  - `AllowOverdraft` *(bool)*: Cho phép số dư âm.
  - `CreditLimit` *(double)*: Hạn mức thấu chi tối đa.
  - `InterestRate` *(double)*: Lãi suất cho loại tài khoản này.

- **Chức năng chính**
  - Cấu hình hành vi và giới hạn của tài khoản.
  - Dùng để kiểm tra hợp lệ giao dịch và tính lãi.

---

### 3️⃣ Customer (Khách hàng)

Đại diện cho một khách hàng ngân hàng.

- **Thuộc tính**
  - `UID` *(Guid, chỉ đọc)*: Mã khách hàng duy nhất.
  - `CID` *(string)*: Số CMND/CCCD.
  - `FirstName` *(string)*: Tên.
  - `LastName` *(string)*: Họ.
  - `Email` *(string)*: Email liên hệ.
  - `Phone` *(string)*: Số điện thoại.
  - `Address` *(string)*: Địa chỉ.
  - `FullName` *(DateTime)*: Ngày sinh khách hàng.

- **Chức năng chính**
  - Lưu trữ và quản lý thông tin khách hàng.
  - Liên kết với nhiều tài khoản.

---

### 4️⃣ Transaction (Giao dịch)

Ghi nhận một giao dịch (gửi, rút, chuyển khoản).

- **Thuộc tính**
  - `TransactionID` *(Guid, chỉ đọc)*: Mã giao dịch duy nhất.
  - `FromAccount` *(string)*: Số tài khoản nguồn.
  - `ToAccount` *(string)*: Số tài khoản đích (nếu chuyển khoản).
  - `Amount` *(double)*: Số tiền giao dịch.
  - `Type` *(TransactionType)*: Loại giao dịch (Gửi, Rút, Chuyển khoản - Enum).
  - `TransactionTime- Timestamp` *(DateTime)*: Thời điểm giao dịch.

- **Chức năng chính**
  - Theo dõi mọi hoạt động tài khoản.
  - Hỗ trợ lịch sử và kiểm tra giao dịch.

---

### 5️⃣ AccountManagement (Quản lý tài khoản)

Quản lý tất cả tài khoản và giao dịch.

- **Thuộc tính**
  - `_accounts` *(List<Account>)*: Danh sách tài khoản nội bộ.
  - `_transactions` *(List<Transaction>)*: Danh sách giao dịch nội bộ.

- **Chức năng chính**
  - Thêm, xóa, tìm kiếm tài khoản (theo khách hàng, số dư, ...).
  - Gửi, rút, chuyển tiền với kiểm tra hợp lệ.
  - Tính lãi cho toàn bộ tài khoản.
  - Đọc dữ liệu tài khoản từ file CSV.
  - Sắp xếp tài khoản theo số dư.
  - Quản lý lịch sử giao dịch.
  - Truy xuất tài khoản qua số tài khoản (indexer).

---

### 6️⃣ CustomerManagement (Quản lý khách hàng)

Quản lý toàn bộ khách hàng.

- **Thuộc tính**
  - `_customers` *(List<Customer>)*: Danh sách khách hàng nội bộ.

- **Chức năng chính**
  - Thêm, xóa, cập nhật, tìm kiếm khách hàng.
  - Liên kết khách hàng với tài khoản.
  - Đọc/ghi dữ liệu khách hàng từ/ra file CSV.

---

### 7️⃣ Utilities (Tiện ích)

- **myConvert**: Hỗ trợ chuyển đổi dữ liệu (chuỗi ↔ số/ngày, xuất CSV).
- **myString**: Chuẩn hóa, tách tên, xử lý chuỗi.
- **MoneyFmt**: Định dạng số thành chuỗi tiền tệ.

---

## 🗂️ Cấu trúc thư mục dự án

BankManagement/
│
├── Data/
│   ├── AccountInfo.csv
│   ├── CustomerInfo.csv
│   └── TransactionInfo.csv
│
├── Models/
│   ├── Account.cs
│   ├── AccountType.cs
│   ├── Customer.cs
│   └── Transaction.cs
│
├── Utils/
│   ├── AccountManagement.cs
│   ├── CustomerManagement.cs
│   ├── myConvert.cs
│   └── myString.cs
│
├── Forms/
│   ├── FormMain.cs
│   ├── FormFlash.cs
│   ├── FormAdd.cs
│   ├── FormEdit.cs
│   ├── FormTransaction.cs
│   └── FormTransactionBill.cs
│
├── GlobalSettings.cs
├── Program.cs
├── README.md
└── UML Graph.mdj

---

## ⚡ Tính năng nổi bật

- **Quản lý khách hàng & tài khoản**  
  Thêm, xóa, cập nhật, tìm kiếm khách hàng và tài khoản.  
  Liên kết tài khoản với khách hàng.

- **Quản lý giao dịch**  
  Gửi, rút, chuyển tiền với kiểm tra hợp lệ và lưu lịch sử giao dịch.

- **Tính lãi suất**  
  Tính lãi cho toàn bộ tài khoản dựa trên loại tài khoản và lãi suất hệ thống.

- **Nhập/Xuất dữ liệu**  
  Đọc và lưu dữ liệu khách hàng/tài khoản từ/ra file CSV.

- **Tiện ích**  
  Hỗ trợ chuyển đổi dữ liệu, xử lý chuỗi, định dạng tiền tệ an toàn và hiệu quả.

---

*Xem mã nguồn để biết chi tiết cách sử dụng, mở rộng và tài liệu bổ sung.*