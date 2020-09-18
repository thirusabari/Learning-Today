
IF DB_ID('Transactions') IS NOT NULL
BEGIN
DROP DATABASE Transactions;
CREATE DATABASE Transactions;
END

