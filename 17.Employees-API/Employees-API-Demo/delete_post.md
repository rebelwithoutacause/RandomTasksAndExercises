### DELETE Post (ID 1)
```
DELETE https://dummyjson.com/posts/1
```

Simulates a delete request. The post isn't permanently removed from the server but the response will contain:
```json
{
  "isDeleted": true,
  "deletedOn": "timestamp"
}
```
