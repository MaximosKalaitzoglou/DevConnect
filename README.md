# DevConnect

## Overview

DevConnect is a modern social networking web application designed to connect developers through posts, discussions, and collaborations. The platform aims to provide a clean, scalable, and modular full-stack solution built with **.NET 8** on the backend and **Angular 16** on the frontend.

The application focuses on developer-centric features such as sharing posts, commenting, user profiles, and more, with a strong emphasis on best practices in software engineering, system design, API documentation, and user experience.

---

## Current Implementation

### Backend (.NET 8)

- **API:** RESTful endpoints built with ASP.NET Core Web API
- **In-Memory Database:** Using Entity Framework Core InMemory for rapid prototyping
- **Posts Endpoint:** Basic `PostsController` serving dummy posts data
- **Swagger:** Integrated for API documentation and testing
- **Project Structure:** Clean architecture separating Domain, Application, Infrastructure, and API layers

### Frontend (Angular 16)

- **Modules:** Modularized with `FeedModule` containing `FeedListComponent`
- **Routing:** Basic routing setup including `/feed` route
- **Posts Service:** Communicates with backend API to fetch and display posts
- **UI:** Minimal but functional feed page displaying dummy posts, plus a stylized Home page

---

## Roadmap & Next Steps

1. **Backend:**
   - Design and implement full entity models (Users, Posts, Comments, Likes)
   - Replace InMemory DB with a persistent database (e.g., PostgreSQL, SQL Server)
   - Add authentication and authorization (JWT or IdentityServer)
   - Implement versioning for APIs and enhance Swagger docs
   - Add unit and integration tests

2. **Frontend:**
   - Build out UI pages: User profiles, post creation, comments, notifications
   - Implement state management (e.g., NgRx) for scalable data handling
   - Add authentication UI and guard routes
   - Improve UI styling and responsiveness
   - Connect with backend APIs fully

3. **DevOps & Documentation:**
   - Add CI/CD pipeline for automated builds and deployments
   - Dockerize backend and frontend with docker-compose
   - Improve API documentation with Swagger best practices
   - Write developer and user documentation

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js 20+](https://nodejs.org/)
- Angular CLI
- Docker (optional, for containerized development)

### Running the Project

#### Backend

