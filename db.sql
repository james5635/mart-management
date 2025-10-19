-- Enable foreign key constraints
PRAGMA foreign_keys = ON;

CREATE TABLE Categories (
    CategoryID INTEGER PRIMARY KEY AUTOINCREMENT,
    CategoryName TEXT NOT NULL,
    Description TEXT
);

CREATE TABLE Products (
    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
    ProductName TEXT NOT NULL,
    CategoryID INTEGER,
    UnitPrice REAL NOT NULL,
    CostPrice REAL NOT NULL,
    Unit TEXT,
    ReorderLevel INTEGER DEFAULT 0,
    Status TEXT CHECK (Status IN ('Active', 'Inactive')) DEFAULT 'Active',
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Suppliers (
    SupplierID INTEGER PRIMARY KEY AUTOINCREMENT,
    SupplierName TEXT NOT NULL,
    ContactPerson TEXT,
    Phone TEXT,
    Email TEXT,
    Address TEXT
);

CREATE TABLE Purchases (
    PurchaseID INTEGER PRIMARY KEY AUTOINCREMENT,
    SupplierID INTEGER NOT NULL,
    PurchaseDate DATE NOT NULL,
    TotalAmount REAL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

CREATE TABLE PurchaseDetails (
    PurchaseDetailID INTEGER PRIMARY KEY AUTOINCREMENT,
    PurchaseID INTEGER NOT NULL,
    ProductID INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    UnitCost REAL NOT NULL,
    Subtotal REAL NOT NULL,
    FOREIGN KEY (PurchaseID) REFERENCES Purchases(PurchaseID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Inventory (
    ProductID INTEGER PRIMARY KEY,
    QuantityInStock INTEGER NOT NULL DEFAULT 0,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Customers (
    CustomerID INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerName TEXT NOT NULL,
    Phone TEXT,
    Email TEXT,
    Address TEXT
);

CREATE TABLE Sales (
    SaleID INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerID INTEGER,
    SaleDate DATETIME NOT NULL DEFAULT (datetime('now')),
    TotalAmount REAL,
    PaymentMethod TEXT CHECK (PaymentMethod IN ('Cash', 'Card', 'Transfer', 'Other')) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE SaleDetails (
    SaleDetailID INTEGER PRIMARY KEY AUTOINCREMENT,
    SaleID INTEGER NOT NULL,
    ProductID INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    UnitPrice REAL NOT NULL,
    Subtotal REAL NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Employees (
    EmployeeID INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName TEXT NOT NULL,
    Role TEXT CHECK (Role IN ('Admin', 'Cashier', 'Stocker')) NOT NULL,
    Phone TEXT,
    Email TEXT,
    Username TEXT UNIQUE,
    PasswordHash TEXT NOT NULL
);

CREATE TABLE Payments (
    PaymentID INTEGER PRIMARY KEY AUTOINCREMENT,
    SaleID INTEGER NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT (datetime('now')),
    AmountPaid REAL NOT NULL,
    PaymentMethod TEXT CHECK (PaymentMethod IN ('Cash', 'Card', 'Transfer', 'Other')) NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID)
);

-- Trigger: After inserting a purchase detail, update inventory
CREATE TRIGGER after_purchase_detail_insert
AFTER INSERT ON PurchaseDetails
BEGIN
    INSERT INTO Inventory (ProductID, QuantityInStock)
    VALUES (NEW.ProductID, NEW.Quantity)
    ON CONFLICT(ProductID)
    DO UPDATE SET QuantityInStock = QuantityInStock + NEW.Quantity;
END;

-- Trigger: After inserting a sale detail, decrease inventory
CREATE TRIGGER after_sale_detail_insert
AFTER INSERT ON SaleDetails
BEGIN
    UPDATE Inventory
    SET QuantityInStock = QuantityInStock - NEW.Quantity
    WHERE ProductID = NEW.ProductID;
END;

