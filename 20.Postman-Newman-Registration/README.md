# Postman & Newman Test - User Registration API

This repo contains a sample Postman collection that tests the registration endpoint of ReqRes API using Newman.

## ✅ What it does:
- Sends a POST request to register a new user
- Validates HTTP status code
- Checks if a token is returned

## 🔧 How to run
1. Install Newman: `npm install -g newman`
2. Run the test:
```bash
newman run user-registration.postman_collection.json
```
