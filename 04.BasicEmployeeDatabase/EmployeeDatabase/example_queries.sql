-- 1. Select all employees
SELECT * FROM employees;

-- 2. Select name and salary of employees in Engineering
SELECT name, salary FROM employees WHERE department = 'Engineering';

-- 3. Order employees by salary (descending)
SELECT * FROM employees ORDER BY salary DESC;

-- 4. Select employees with salary > 45000
SELECT * FROM employees WHERE salary > 45000;