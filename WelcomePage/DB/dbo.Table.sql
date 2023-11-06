CREATE TABLE PersonalFinance (
    TransactionID INT  PRIMARY KEY,
    Category VARCHAR(50) NOT NULL,
    Description VARCHAR(255),
    Amount DECIMAL(10, 2) NOT NULL,
    Date DATE NOT NULL,
    Notes TEXT,
    CONSTRAINT chk_amount_non_negative CHECK (Amount >= 0)
);
