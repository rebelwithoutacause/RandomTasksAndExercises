# 💡 Idea Center API Tests

This repository contains a Postman collection for testing the **Idea Center** web application's RESTful API. The application allows users to register, authenticate, and manage innovative ideas.

## 🔗 Base URLs

- **Web App UI**:  
  `http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:83`

- **API Base URL**:  
  `http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:84/api`

- **API Docs (Swagger)**:  
  `http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:84/swagger/index.html`

---

## 📦 What's Included

This collection includes the following requests:

1. **Create User**
   - `POST /api/User/Create`
   - Registers a new user with required fields.

2. **Get Token**
   - `POST /api/User/Authentication`
   - Logs in the user and retrieves a JWT `accessToken`.

3. **Create Idea**
   - `POST /api/Idea/Create`
   - Submits a new idea. Requires Bearer Token.

4. **Get All Ideas**
   - `GET /api/Idea/All`
   - Retrieves all submitted ideas. Requires Bearer Token.

5. **Edit Idea**
   - `PUT /api/Idea/Edit?ideaId={id}`
   - Edits an existing idea. Requires Bearer Token.

6. **Remove Idea**
   - `DELETE /api/Idea/Delete?ideaId={id}`
   - Deletes a specified idea. Requires Bearer Token.

---

## 🔐 Authorization

All **Idea-related** endpoints require Bearer Token authentication.  
Use the access token obtained from the **Get Token** request and set it in Postman's Authorization tab as a **Bearer Token**.

Example:

```
Authorization: Bearer <accessToken>
```

---

## 🧪 How to Run the Tests

### 🔸 In Postman:
1. Import the collection (`Idea Center API Tests.postman_collection.json`)
2. Register a new user using the `Create User` request
3. Authenticate with `Get Token` and copy the `accessToken`
4. Set the token as the bearer auth in the **Authorization tab** or as an **environment variable**
5. Run requests manually or as a collection

### 🔸 With Newman (CLI):
```bash
newman run "Idea Center API Tests.postman_collection.json"
```

---

## ✅ Tips for Use

- Make sure to update your `accessToken` if it expires
- Update `ideaId` parameters in Edit/Delete manually based on responses
- Customize the body of Create/Edit requests to test different data

---

## 👤 Author

Created by **Teodor Kostov** as part of the QA Automation Training at SoftUni.
