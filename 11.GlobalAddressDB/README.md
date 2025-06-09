# Global Address Database

This project contains a simple SQL database designed to store and query global addresses, including information about streets, towns, districts, countries, continents, and whether the town is a capital city.

---

## Database Details

- **Database Name:** `address_database`
- **Table Name:** `addresses`
- **Columns:**
  - `street_number` (INT)
  - `street_name` (VARCHAR/TEXT)
  - `area` (VARCHAR/TEXT)
  - `town` (VARCHAR/TEXT)
  - `district` (VARCHAR/TEXT)
  - `country` (VARCHAR/TEXT)
  - `continent` (VARCHAR/TEXT)
  - `isCapital` (BOOLEAN/INTEGER) — indicates if the town is a capital city (TRUE or 1 = yes, FALSE or 0 = no)

---

## Features

- Insert records for various global addresses.
- Query addresses by capital city status.
- Filter addresses by continent and capital/non-capital distinction.

---

## Usage

1. **MySQL:**
   - Create and use the database.
   - Create the `addresses` table.
   - Insert sample data.
   - Run queries to filter data as needed.

2. **SQLite (DB Browser for SQLite):**
   - Open or create a new database file.
   - Execute the adapted SQL script.
   - Queries work similarly with minor syntax changes (e.g., no `CREATE DATABASE`).

---

## Sample Queries

- Select all addresses located in capital cities:
  ```sql
  SELECT * FROM addresses WHERE isCapital = TRUE;
