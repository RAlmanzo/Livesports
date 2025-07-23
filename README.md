# 🛶 Live Sports Report

**Live Sports Report** is a real-time web application developed as a **school project**. It allows a **reporter** to provide live updates for a **kayak competition**, while users can **register for races** and follow the event **live** via the app.

This project was designed with a focus on real-time interaction, a user-friendly interface, and role-based functionality for **reporters** and **audience members**.

---

## 📸 Key Features

- 📝 **User registration** for races (pre-event)
- 🎤 **Live event reporting** by authenticated reporters
- 👀 **Real-time updates** for all connected users
- 👥 **Role-based interface**: Reporter vs. Audience
- 📱 **Responsive design** using Bootstrap

---

## 🧰 Tech Stack

| Layer           | Technology                               |
|-----------------|------------------------------------------|
| Frontend        | Blazor Server with Razor Pages           |
| Backend         | C# (.NET) Core library                   |
| Real-time Comm. | SignalR                                  |
| UI Styling      | HTML5, Bootstrap                         |

---

## 🧠 What I Learned

During the development of this project, I gained hands-on experience in:

- Creating **component-based** single-page applications (SPA) using **Blazor Server**
- Implementing **SignalR** for real-time communication
- Designing clean and responsive UI layouts with **Razor Pages** and **Bootstrap**
- Handling **multiple user roles** and conditional rendering in Blazor
- Managing **state** and **data flow** in a real-time environment

---

## 🗂️ Project Structure

LiveSports.Blazor/

│

├── Pages/ # Razor pages

├── Components/ # .razor components

├── Hubs/ # SignalR hubs

├── wwwroot/ # Static assets (CSS, JS, images)

└── Program.cs / Startup.cs # App startup and DI config


LiveSports.Core/

│

├── Models/ # Data models (Race, User, Message)

└── Services/ # Application services (e.g. race manager)

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ with Blazor support

### Run the project locally:
```bash
dotnet restore
dotnet run
```

---

## 💡 Possible Improvements

🔒 Add authentication & role-based authorization

📊 Include a leaderboard or scoring module

💬 Add live chat for audience interaction

🌍 Multi-language support

---

## 📬 Contact
For questions, suggestions or collaboration:

📧 Email: ralmanzo@gmail.com

💼 LinkedIn: https://www.linkedin.com/in/rosseel-almanzo-5241172ba/

🐙 GitHub: https://github.com/RAlmanzo
