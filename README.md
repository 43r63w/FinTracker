FinTracker is a personal finance management system that allows users to track income and expenses, analyze financial data, forecast future spending, and manage subscriptions.

Features

Transaction Management: Add, edit, and delete income and expenses.

Expense Categorization: Group transactions by categories.

Report Generation: Financial statistics for a selected period.

Spending Forecasting: Analysis and prediction of future expenses.

Bank Integration: Import transactions from banking APIs.

Subscriptions: Manage subscription plans and payments.

Payment Methods: Link cards, e-wallets, and other payment options.

Security: User authentication and authorization.

Architecture

The project follows Clean Architecture, which separates code into layers:

Domain (Business Logic): Contains entities and interfaces.

Application (Use Cases): Handles commands and queries.

Infrastructure (Data Access, APIs, and External Services).

Presentation (Controllers and UI): User interaction.

Technologies Used

Backend: ASP.NET Core, Entity Framework Core, PostgreSQL, RabbitMQ.

Frontend: Angular, TypeScript, Angular Material.

Authentication: JWT.

Containerization: Docker, Docker Compose.

CI/CD: GitHub Actions.

Installation and Setup

Requirements

.NET 8.0+

Node.js 18+

Docker and Docker Compose

Steps to Run

Backend

Clone the repository:

git clone https://github.com/your-repo/financial-aggregator.git
cd financial-aggregator

Build and run the backend:

cd backend
dotnet build
dotnet run

Frontend

Install dependencies:

cd frontend
npm install

Start the application:

ng serve

Running with Docker

Build and start containers:

docker-compose up --build

API will be available at http://localhost:5000

UI – at http://localhost:4200
