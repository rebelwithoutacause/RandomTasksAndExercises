# Phonebook POST Requests in Postman

This task demonstrates how to send POST requests using Postman to add new phonebook entries. The endpoint used is a local server running at `http://localhost:3030/jsonstore/phonebook`.

---

## 🧪 Endpoint
```
POST http://localhost:3030/jsonstore/phonebook
```

## 📬 Payload Format
Each request body must contain:
```json
{
  "person": "<person>",
  "phone": "<phone>"
}
```

---

## 📁 Included Files
- `request1.json`: Sample POST body for the first person.
- `request2.json`: Sample POST body for the second person.
- `request_details.md`: Explanation of each request.
