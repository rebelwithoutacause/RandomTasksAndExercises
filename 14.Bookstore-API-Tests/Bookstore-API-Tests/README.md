# Bookstore API Testing Project

This project includes a Postman collection to test a mock Bookstore RESTful API.

## Tools Used
- Postman
- Newman
- Newman HTML Reporter

## How to Run Tests

1. Install Newman:
   ```bash
   npm install -g newman
   ```

2. Install HTML Reporter (optional for HTML reports):
   ```bash
   npm install -g newman-reporter-html
   ```

3. Run the tests:
   ```bash
   newman run postman_collection.json -r cli,html --reporter-html-export ./test-results/newman-report.html
   ```
