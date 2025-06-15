# Employees API Task using DummyJSON

This task demonstrates the use of the DummyJSON API to send different types of requests (GET, POST, PUT, DELETE) using Postman.

---

## 🔗 Base URL
```
https://dummyjson.com/
```

---

## 📬 Endpoints & Actions

### 1. GET All Posts
```
GET https://dummyjson.com/posts
```

### 2. GET Single Post (e.g., ID 1)
```
GET https://dummyjson.com/posts/1
```

### 3. POST New Post
You can use a user ID from: https://dummyjson.com/users

Sample body:
```json
{
  "title": "Postman Practice Post",
  "body": "This is a test post created for educational purposes.",
  "userId": 5,
  "tags": ["test", "postman", "dummy"],
  "reactions": {
    "likes": 10,
    "dislikes": 1
  }
}
```

### 4. PUT Update Post (ID 1)
```
PUT https://dummyjson.com/posts/1
```

Sample update body:
```json
{
  "title": "Updated Title",
  "body": "This post content was updated via Postman."
}
```

### 5. DELETE Post (ID 1)
```
DELETE https://dummyjson.com/posts/1
```

Response will contain:
```json
{
  "isDeleted": true,
  "deletedOn": "timestamp"
}
```

---

## 📁 Included Files
- `get_all_posts.md`
- `get_single_post.md`
- `post_new_post.json`
- `put_update_post.json`
- `delete_post.md`
