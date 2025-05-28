# SQLite Basic Example

This project demonstrates very basic usage of SQLite using a simple `employees` table.

## 📦 What's Inside

- `employees.db`: SQLite database file.
- `example_queries.sql`: SQL commands to show `SELECT`, `WHERE`, `ORDER BY`, etc.

## 💡 Sample Queries

```sql
SELECT * FROM employees;
SELECT name, salary FROM employees WHERE department = 'Engineering';
SELECT * FROM employees ORDER BY salary DESC;
SELECT * FROM employees WHERE salary > 45000;
```

## 🛠 How to Open

You can open the `.db` file using tools like:

- [DB Browser for SQLite](https://sqlitebrowser.org/)
- Python (`sqlite3` module)
- VS Code with SQLite extension