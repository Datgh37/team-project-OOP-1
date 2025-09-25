# 🏦 Bank Management

A simple **C# OOP** project simulating a basic **banking system**.  
It provides classes to manage bank accounts, handle transactions, and apply interest rates.

---

## 📌 Overview

### 1️⃣ Account Class
Represents a single bank account with:
- **Properties**
  - `Number` *(string, read-only)*: Unique account number (auto-generated).
  - `Owner` *(string, private set)*: Account owner’s name.
  - `Balance` *(double, private set)*: Current balance, protected from external direct changes.
  - `OpenAt` *(DateTime, read-only)*: Date and time the account was created.
  - `InterestRate` *(static double)*: Global interest rate for all accounts (default **0.2%**).

- **Key Features**
  - Create accounts with optional initial balance or owner.
  - Deposit / Withdraw with validation.
  - Transfer money between accounts.
  - Apply interest to balance.
  - Change global interest rate (0–10%).

### 2️⃣ Bank Class
Represents a collection of multiple `Account` objects with:
- **Account Management (CRUD)**
  - `AddAccount` / `RemoveAccount` (by object or account number).
- **Search & Filter**
  - Find by `Owner`.
  - Find by exact or ranged `Balance`.
- **Indexer**
  - Access an account directly using `bank[accountNumber]`.
- **Sorting**
  - `SortByBalance()` (ascending) / `SortDescByBalance()` (descending).
- **Transactions**
  - Deposit / Withdraw by account number.
  - Apply interest to **all** accounts.

### 3️⃣ MoneyFmt Utility
Static helper class:
- `Format(double amount)`: Returns a formatted money string, e.g.  
# 🏦 Quản Lý Ngân Hàng

Dự án **C# OOP** mô phỏng hệ thống **quản lý tài khoản ngân hàng** đơn giản.  
Bao gồm các lớp để tạo tài khoản, quản lý giao dịch và tính lãi suất.

---

## 📌 Tổng Quan

### 1️⃣ Lớp Account
Đại diện cho **một tài khoản ngân hàng** với:
- **Thuộc tính**
  - `Number` *(string, chỉ đọc)*: Số tài khoản tự sinh, duy nhất.
  - `Owner` *(string, private set)*: Tên chủ tài khoản.
  - `Balance` *(double, private set)*: Số dư hiện tại, không thể chỉnh trực tiếp từ bên ngoài.
  - `OpenAt` *(DateTime, chỉ đọc)*: Thời điểm mở tài khoản.
  - `InterestRate` *(static double)*: Lãi suất chung cho mọi tài khoản (mặc định **0.2%**).

- **Chức năng chính**
  - Khởi tạo tài khoản với tên chủ và/hoặc số dư ban đầu.
  - Gửi tiền / Rút tiền với kiểm tra hợp lệ.
  - Chuyển khoản giữa các tài khoản.
  - Tính lãi dựa trên lãi suất hiện tại.
  - Thay đổi lãi suất toàn hệ thống (giới hạn 0–10%).

### 2️⃣ Lớp Bank
Đại diện cho **tập hợp nhiều tài khoản** (`Account`):
- **Quản lý tài khoản (CRUD)**
  - `AddAccount` / `RemoveAccount` (xóa bằng đối tượng hoặc số tài khoản).
- **Tìm kiếm & Lọc**
  - Tìm theo `Owner`.
  - Tìm theo số dư chính xác hoặc theo khoảng.
- **Indexer**
  - Truy cập trực tiếp tài khoản bằng cú pháp `bank[accountNumber]`.
- **Sắp xếp**
  - `SortByBalance()` (tăng dần) / `SortDescByBalance()` (giảm dần).
- **Giao dịch**
  - Gửi tiền / Rút tiền qua số tài khoản.
  - Áp dụng lãi suất cho **toàn bộ** tài khoản.

### 3️⃣ Lớp MoneyFmt
Tiện ích định dạng tiền:
- `Format(double amount)`: Trả về chuỗi tiền tệ dạng  
