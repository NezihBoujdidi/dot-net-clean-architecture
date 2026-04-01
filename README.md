# 🚀 Clean Architecture .NET Template

A production-ready **Clean Architecture template for .NET Web API** projects.
Generate a fully structured solution in seconds using the `dotnet new` CLI.

---

## ✨ Features

* 🧱 Clean Architecture (Domain, Application, Infrastructure, API)
* ⚡ Ready-to-use Web API project
* 🔌 Dependency Injection setup
* 📦 Scalable and maintainable structure
* 🧼 Minimal and clean starting point

---

## 🏗️ Project Structure

```
src/
 ├── YourProject.Api              → Presentation layer (controllers, endpoints)
 ├── YourProject.Application      → Business logic (use cases, interfaces)
 ├── YourProject.Domain           → Core domain (entities, value objects)
 ├── YourProject.Infrastructure   → External concerns (DB, services)
```

---

## 🚀 Getting Started

### 1. Install the template

```bash
dotnet new install https://github.com/NezihBoujdidi/dot-net-clean-architecture.git
```

---

### 2. Create a new project

```bash
dotnet new cleanapi -n YourProjectName
```

---

## 🧠 What is Clean Architecture?

Clean Architecture helps you build systems that are:

* Independent of frameworks
* Easily testable
* Maintainable and scalable
* Organized around business logic

---

## 🛠️ Customization

You can extend this template with:

* Authentication (JWT, Identity)
* Database providers (SQL Server, PostgreSQL)
* Docker support
* Logging & monitoring

---

## 📌 Requirements

* .NET 8 SDK or later

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

---

## 📄 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

Created by **Nezih Boujdidi**
