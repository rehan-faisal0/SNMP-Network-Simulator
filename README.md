# SNMP Network Simulator

A Windows Forms desktop application built in C# that simulates an SNMP (Simple Network Management Protocol) network topology. Users can dynamically add network devices, connect them to an SNMP Manager, drag them across the canvas, and query their status — all in real time.

---

## Features

- **Dynamic Device Management** — Add Routers, Thermometers, Computers, and CCTV cameras at runtime via a dropdown menu
- **Live Network Topology** — Devices are visually connected to the SNMP Manager with lines that update as you drag devices around the canvas
- **Drag and Drop Canvas** — Every device is draggable; the network diagram redraws automatically on move
- **SNMP Manager Polling** — Click the SNMP Manager to poll all connected devices and display their name, IP address, and status
- **Device Click Events** — Click any individual device to see its trap/send data output in the log panel
- **Auto IP Assignment** — Each new device is automatically assigned a unique IP address
- **Random Device Status** — Devices are assigned On/Off status on creation to simulate a live network
- **Activity Log** — A scrollable rich text box logs all SNMP events, device responses, and status updates
- **Clear Log** — One-click button to clear the activity log

---

## OOP Concepts Used

| Concept | Where Applied |
|---|---|
| Inheritance | `Router`, `Thermometer`, `Computer`, `Cctv` all extend `NetworkDevice` |
| Polymorphism | `SendData()` is overridden in each subclass |
| Encapsulation | Device properties (`IPAddress`, `DeviceStatus`) are encapsulated in `NetworkDevice` |
| Static Members | `TotalRouters`, `TotalThermometer`, etc. track instance counts per class |
| Event Handling | `LocationChanged`, `Click` events wired per device dynamically |

---

## Screenshots

> Add screenshots here after running the application.

| Main Window | Device Added | SNMP Poll |
|---|---|---|
| `screenshots/main.png` | `screenshots/device_added.png` | `screenshots/snmp_poll.png` |

To add screenshots: create a `screenshots/` folder in the repo root and drop your images there, then update the paths above.

---

## Requirements

- Windows 10 or later
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
- Visual Studio 2019 or later (Community edition is fine)

---

## Setup & Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/snmp-network-simulator.git
   cd snmp-network-simulator
   ```

2. **Open the solution**
   - Double-click `OOP_Project.sln` in Visual Studio

3. **Add images to output folder**
   - Place the following image files in the project root (they will be copied to `bin\Debug\` on build):
     - `images.jpg` — SNMP Manager icon
     - `wifi-router.png` — Router icon
     - `thermometer.png` — Thermometer icon
     - `computer.png` — Computer icon
     - `cctv_icon_135799.png` — CCTV icon
   - In Solution Explorer, select each image → Properties → set **Copy to Output Directory** to `Copy if newer`

4. **Build and Run**
   ```
   Build → Rebuild Solution
   Press F5
   ```

---

## Usage

1. Select a device type from the dropdown (Router, Thermometer, Computer, Cctv)
2. Click **Add Device** — the device appears on the canvas connected to the SNMP Manager
3. **Drag** any device to reposition it on the canvas
4. **Click** any device to see its data output in the log
5. **Click the SNMP Manager** to poll all connected devices and view their status
6. Click **Clear** to reset the activity log

---

## Project Structure

```
OOP_Project/
├── NetworkDevices.cs       # All network device classes (NetworkDevice, Router, etc.)
├── MainForm.cs             # Main form logic and event handlers
├── MainForm.Designer.cs    # Auto-generated designer file
├── Program.cs              # Entry point
├── App.config              # Runtime configuration (.NET 4.7.2)
├── images.jpg              # SNMP Manager icon
├── wifi-router.png
├── thermometer.png
├── computer.png
└── cctv_icon_135799.png
```

---

## Author

**Rehan Faisal**  
BS Cybersecurity — Air University, Islamabad
