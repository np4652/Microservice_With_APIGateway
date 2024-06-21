# Microservice Pattern with API Gateway using Ocelot and Authentication

## Overview

This project demonstrates the implementation of the microservice architecture pattern using .NET Core 8.0. It utilizes the Ocelot library to set up an API Gateway and includes a robust authentication mechanism. The project showcases how to structure microservices, configure an API Gateway, and secure the services using authentication.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Authentication](#authentication)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Microservice Architecture**: Demonstrates a simple microservice setup.
- **API Gateway**: Configured using the Ocelot library for routing and aggregation.
- **Authentication**: Secure services using JWT (JSON Web Token) authentication.
- **.NET Core 8.0**: Built with the latest version of .NET Core for enhanced performance and features.

## Prerequisites

- [.NET Core SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop) (optional, for containerization)
- [Postman](https://www.postman.com/downloads/) (optional, for API testing)

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/microservice-pattern-api-gateway-ocelot.git
   cd microservice-pattern-api-gateway-ocelot
   ```

2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```

3. **Build the project:**

   ```bash
   dotnet build
   ```

4. **Run the microservices and API Gateway:**

   ```bash
   dotnet run --project src/ApiGateway
   ```

## Usage

1. **Start the services:**

   Ensure all microservices and the API Gateway are running.

2. **Access the API Gateway:**

   The API Gateway will be accessible at `http://localhost:5000`.

3. **Test endpoints:**

   Use Postman or any other API testing tool to test the endpoints exposed by the API Gateway.

## Project Structure

```plaintext
├── src
│   ├── ApiGateway
│   │   ├── ocelot.json
│   │   ├── Program.cs
│   ├── Auth
│   │   ├── Controllers
│   │   ├── Program.cs
│   ├── Shoe
│   │   ├── Controllers
│   │   ├── Program.cs
├── docker-compose.yml
├── README.md
└── .gitignore
```





## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Create a new Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
