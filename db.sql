CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY AUTO_INCREMENT,
    CategoryName VARCHAR(100) NOT NULL,
    Description TEXT
);
CREATE TABLE Products (
    ProductID INT PRIMARY KEY AUTO_INCREMENT,
    ProductName VARCHAR(150) NOT NULL,
    CategoryID INT,
    UnitPrice DECIMAL(10,2) NOT NULL,
    CostPrice DECIMAL(10,2) NOT NULL,
    Unit VARCHAR(50), -- e.g., 'piece', 'kg', 'pack'
    ReorderLevel INT DEFAULT 0,
    Status ENUM('Active', 'Inactive') DEFAULT 'Active',
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY AUTO_INCREMENT,
    SupplierName VARCHAR(150) NOT NULL,
    ContactPerson VARCHAR(100),
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address TEXT
);
CREATE TABLE Purchases (
    PurchaseID INT PRIMARY KEY AUTO_INCREMENT,
    SupplierID INT NOT NULL,
    PurchaseDate DATE NOT NULL,
    TotalAmount DECIMAL(12,2),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

CREATE TABLE PurchaseDetails (
    PurchaseDetailID INT PRIMARY KEY AUTO_INCREMENT,
    PurchaseID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitCost DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(12,2) NOT NULL,
    FOREIGN KEY (PurchaseID) REFERENCES Purchases(PurchaseID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Inventory (
    ProductID INT PRIMARY KEY,
    QuantityInStock INT NOT NULL DEFAULT 0,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerName VARCHAR(150) NOT NULL,
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address TEXT
);
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT,
    SaleDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TotalAmount DECIMAL(12,2),
    PaymentMethod ENUM('Cash', 'Card', 'Transfer', 'Other') NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE TABLE SaleDetails (
    SaleDetailID INT PRIMARY KEY AUTO_INCREMENT,
    SaleID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(12,2) NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT,
    FullName VARCHAR(150) NOT NULL,
    Role ENUM('Admin', 'Cashier', 'Stocker') NOT NULL,
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL
);
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY AUTO_INCREMENT,
    SaleID INT NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    AmountPaid DECIMAL(12,2) NOT NULL,
    PaymentMethod ENUM('Cash', 'Card', 'Transfer', 'Other') NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID)
);


-- Example trigger after purchase
CREATE TRIGGER after_purchase_detail_insert
AFTER INSERT ON PurchaseDetails
FOR EACH ROW
BEGIN
    INSERT INTO Inventory (ProductID, QuantityInStock)
    VALUES (NEW.ProductID, NEW.Quantity)
    ON DUPLICATE KEY UPDATE QuantityInStock = QuantityInStock + NEW.Quantity;
END;


-- Example trigger after sale
CREATE TRIGGER after_sale_detail_insert
AFTER INSERT ON SaleDetails
FOR EACH ROW
BEGIN
    UPDATE Inventory
    SET QuantityInStock = QuantityInStock - NEW.Quantity
    WHERE ProductID = NEW.ProductID;
END;
