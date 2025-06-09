# First Database: User Management Example

This project demonstrates basic SQL operations including database creation, table setup, data insertion, and a simple query to retrieve filtered user information.
It is intended for educational or practice purposes.

## 🧱 Database Structure

- **Database Name:** `first_database`
- **Table:** `users`

### Table Columns:
| Column Name | Data Type     | Description                  |
|-------------|---------------|------------------------------|
| `id`        | INT (AUTO_INCREMENT) | Unique user ID (Primary Key) |
| `first_name`| VARCHAR(50)   | User's first name            |
| `last_name` | VARCHAR(50)   | User's last name             |
| `job_title` | VARCHAR(35)   | User's job title             |
| `salary`    | INT           | User's monthly salary        |

## 🧪 Sample Data

The table is populated with 9 user entries, covering various job roles such as Manager, Waiter, Executive Chef, etc.

## 🔍 Query Example

This query retrieves all users earning **more than 1200**:

```sql
SELECT first_name, last_name, job_title, salary
FROM users
WHERE salary > 1200;
