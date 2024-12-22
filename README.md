# SurvivorProject API

## Overview
This project provides a RESTful API for managing **Competitors** and **Categories**, supporting basic CRUD operations.

---

## CompetitorController Endpoints

- **GET /api/competitors**  
  Retrieves a list of all competitors.  
  ✅ Successfully listed all competitors.

- **GET /api/competitors/{id}**  
  Retrieves a specific competitor by ID.  
  ✅ Successfully retrieved a specific competitor.

- **GET /api/competitors/categories/{CategoryId}**  
  Retrieves competitors by category ID.  
  ✅ Successfully retrieved competitors by category ID.

- **POST /api/competitors**  
  Adds a new competitor.  
  ✅ Successfully created a new competitor.

- **PUT /api/competitors/{id}**  
  Updates an existing competitor by ID.  
  ✅ Successfully updated a specific competitor.

- **DELETE /api/competitors/{id}**  
  Deletes a specific competitor by ID.  
  ✅ Successfully deleted a specific competitor.

---

## CategoryController Endpoints

- **GET /api/categories**  
  Retrieves a list of all categories.  
  ✅ Successfully listed all categories.

- **GET /api/categories/{id}**  
  Retrieves a specific category by ID.  
  ✅ Successfully retrieved a specific category.

- **POST /api/categories**  
  Adds a new category.  
  ✅ Successfully created a new category.

- **PUT /api/categories/{id}**  
  Updates an existing category by ID.  
  ✅ Successfully updated a specific category.

- **DELETE /api/categories/{id}**  
  Deletes a specific category by ID.  
  ✅ Successfully deleted a specific category.

---

## API Testing
- All CRUD operations have been successfully tested using **Postman** and **Swagger**.  
- Data creation, updates, retrieval, and deletion have been verified as functioning correctly.

---

## How to Use
1. Clone the project to your local machine.
2. Open the project in Visual Studio.
3. Run the project to launch the API.
4. Use **Postman** or **Swagger** to interact with the endpoints.

---  
API is ready for use! 🎉
