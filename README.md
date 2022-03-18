# MMKApplication

MMKApplication is a .net core application used for message management.

## Installation & Dependencies
```
# install .net6.0 framework to run locally

# Restore every dependencies including 
- Caching service used - Inmemorycache for internal testing, Redis for external testing
- Database service used - InMemoryStorage for internal testing, PostreSQL for external testing
- ORM used - Dapper ORM v2.0.123
```

## Coding Structure

```
 Service based archictecture coupled together with dependency Injection
 - Folder Structure and Significance
    1. Model: This holds the database models as well as the client database transfer object
    2. Database: This contains all database queries interaction
    3. Service: This contains all the decoupled services 
    4. Controller: This holds the outerfacing endpoints, routes,responses and its service used
    
  N.b All dependencies injected are defined at program.cs files
 ```
 
## Testing
```
1. All parameters used are not hardcoded, hence can be varied to help with test

# testing can be done on the endpoints using the 
- baseURL + /api/inbound/sms 
- baseURL + /api/outbound/sms

```

## License
[MIT](https://choosealicense.com/licenses/mit/)
