# 🧪 Newman API Testing – Swagger Petstore

This project contains a **Postman collection** and **Newman test setup** for the [Swagger Petstore API](https://petstore.swagger.io/).  
It's designed to test endpoints related to pet operations and verify correct responses.

---

## 📦 Project Structure

newman-petstore-test/
├── collection/
│ └── petstore_collection.json
├── environment/
│ └── petstore_environment.json
├── reports/
│ └── petstore_collection.html
└── README.md


---

## 🚀 How to Run the Tests

### 1. Install [Node.js](https://nodejs.org/) and Newman

```bash
npm install -g newman newman-reporter-html

newman run collection/petstore_collection.json -e environment/petstore_environment.json -r cli,html --reporter-html-export reports/petstore_collection.html

📄 Generated Report
After running the test, you will find a detailed HTML report in the reports/ directory:

reports/petstore_collection.html

You can open this file in a browser to see the results.

🌐 API Under Test
This collection tests endpoints from the Swagger Petstore API, including:

GET /pet/findByStatus

GET /pet/{petId}

POST /pet

DELETE /pet/{petId}

📌 Notes
Make sure the Swagger Petstore API is online before running the tests.

You can customize or expand the collection with more tests and assertions.
