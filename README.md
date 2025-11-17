# 🐾 PetCareManagementSystemV2  
**A C# WinForms Desktop Application for Managing Owners, Pets, Appointments, and Vaccination Records**

This project is part of the **Software Development Attestation – Secure Desktop, Mobile and Web Applications** program at **Vanier College**.  
It is a fully functional **desktop management system** designed for veterinary clinics and pet care service providers.

---

## 🚀 Features

### 🧾 Owner Management
- Add / Edit / Delete owner information  
- Store contact details & unique Owner ID  

### 🐶 Pet Management
- Register new pets  
- Link pets to owners  
- Track species, breed, age, medical info  

### 📅 Appointment Scheduling
- Create & manage appointments  
- Associate appointments with pet + owner  
- Date, time, reason, and status  

### 💉 Vaccination Records
- Add vaccination history  
- Track vaccine name, date, follow-up dates  
- Quick lookup by pet ID  

### 🖥️ Modern WinForms UI
- Clean, intuitive interface  
- Organized CRUD screens  
- Responsive layout for desktop use  

---

## 🏗️ System Architecture

This project uses a clear **Layered Architecture** for maintainability and scalability:

```
📁 PetCareManagementSystemV2
│
├── Presentation Layer (WinForms)
│   ├── OwnerForm.cs
│   ├── PetForm.cs
│   ├── AppointmentForm.cs
│   ├── VaccinationForm.cs
│   └── MainForm.cs
│
├── Data Layer
│   ├── OwnerRepository.cs
│   ├── PetRepository.cs
│   ├── AppointmentRepository.cs
│   └── VaccinationRepository.cs
│
├── Models
│   ├── Owner.cs
│   ├── Pet.cs
│   ├── Appointment.cs
│   └── VaccinationRecord.cs
│
└── Database Connection
    └── DbConnection.cs
```

> ✔️ Note: Only **source code** is included in GitHub.  
> ❌ Build folders (`bin/`, `obj/`, `.vs/`) are excluded via `.gitignore`.

---

## 📁 Project Structure

```
PetCareManagementSystemV2/
│
├── docs/                                   # SDLC Report
│   └── PetCareManagementSystem.docx
│
├── src/                                    # Application Source Code
│   ├── PetCareManagementSystemV2.sln       # Visual Studio Solution
│   │
│   └── PetCareManagementSystemV2/          # Main Project
│       ├── Program.cs
│       ├── OwnerForm.cs
│       ├── OwnerForm.Designer.cs
│       ├── PetForm.cs
│       ├── AppointmentForm.cs
│       ├── VaccinationForm.cs
│       ├── Models/
│       ├── Repositories/
│       └── Properties/
│
└── .gitignore                              # Ignore build artifacts
```

---

## 🛠️ Technologies Used

| Category | Technology |
|---------|------------|
| Language | **C#** |
| Framework | **.NET 6 / .NET 7 / .NET 8 / .NET 9 (depending on your project settings)** |
| UI | **Windows Forms (WinForms)** |
| Data Handling | Collections / In-memory repositories |
| IDE | Visual Studio 2022 |

---

## ▶️ How to Run the Project

### 1. Clone the repository
```bash
git clone https://github.com/YourUserName/PetCareManagementSystemV2.git
```

### 2. Open the solution in Visual Studio
```
src/PetCareManagementSystemV2.sln
```

### 3. Restore dependencies (if required)
Visual Studio will automatically install missing packages.

### 4. Build & Run
Press **F5** or click **Start Debugging**.

---

## 📄 SDLC Documentation

A detailed **System Development Life Cycle Report** is included:

- System Planning  
- System Analysis  
- System Design  
- Use Case Diagram  
- Class Diagram  
- ERD  
- Sequence Diagram  
- FDD / DFD  
- Implementation  
- Testing & Validation  

📍 Located in:

```
/docs/PetCareManagementSystem.docx
```

---

## 👨‍🎓 Author

**Xiaobo Zhan**  
Software Development Attestation – Secure Desktop, Mobile and Web Applications  
Vanier College, Montreal  

---

## ⭐ Future Enhancements

- Migrate data layer to SQL Server  
- Add login & authentication module  
- Export reports to PDF  
- Add search filtering UI  
- Add dashboard with statistics  

---

## 🤝 Contributions

Pull requests are welcome.  
For major changes, please open an issue first to discuss the update.

---

## 📜 License

This project is for educational purposes.  
Commercial use is not permitted without permission.
