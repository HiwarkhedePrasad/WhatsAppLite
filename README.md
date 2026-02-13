# WhatsApp Lite - for Windows

![License](https://img.shields.io/badge/license-MIT-blue.svg) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg) ![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)

A lightweight, high-performance desktop client for WhatsApp Web, built with **.NET 8 (WPF)** and **WebView2**.

This project aims to provide a native-feeling Windows experience without the bloat of Electron-based apps. It uses the system's Edge WebView2 runtime to render WhatsApp Web while wrapping it in a custom, resource-efficient WPF shell.

## 🚀 Features

- **Ultra Lightweight**: Consumes significantly less RAM (~120MB) compared to the official Electron app or browser tabs.
- **Native Experience**: Borderless window with custom dark title bar, native Snap Layouts support using `WindowChrome`.
- **Persistent Login**: Scan QR code once, and your session is saved locally.
- **Privacy Focused**: Sandbox environment with disabled telemetry and autofill.
- **Instant Startup**: No splash screens or long loading times.
- **System Tray Support**: (Coming Soon) Minimized to tray for background notifications.

## 🛠️ Prerequisites

To run or build this application, you need:

- **Windows 10 or 11** (x64 architecture).
- **.NET Desktop Runtime 8.0** ([Download Here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)).
- **WebView2 Runtime** (Pre-installed on Win10/11, or [Download Here](https://developer.microsoft.com/en-us/microsoft-edge/webview2/)).

## 🆚 Comparison

| Feature | WhatsApp Lite (This App) | Official WhatsApp Desktop |
| :--- | :--- | :--- |
| **Technology** | Native .NET 8 + WebView2 | Electron / UWP |
| **RAM Usage** | **~120 MB** (Efficient) | **400 MB+** (Heavy) |
| **Startup Time** | **Instant** (< 1s) | Slow (Splash Screen) |
| **Privacy** | **Sandboxed** (No Telemetry) | Telemetry & Tracking |
| **Storage** | **< 20 MB** (Exe size) | **150 MB+** (Installer) |
| **Window Style** | Minimal & Borderless | Standard Window |


## 📥 Installation

1.  Download the latest release from the [Releases](../../releases) page.
2.  Extract the zip file.
3.  Run `WhatsAppLite.exe`.

## 🏗️ Building from Source

If you want to modify the code or build it yourself, follow these steps.

### Option 1: Using Visual Studio 2022

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/HiwarkhedePrasad/WhatsAppLite.git
    ```
2.  Open `WhatsAppLite.csproj` or the folder in **Visual Studio 2022**.
3.  Ensure you have the **.NET Desktop Development** workload installed.
4.  Press `F5` or click **Start** to build and run the application.

### Option 2: Using .NET CLI

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/HiwarkhedePrasad/WhatsAppLite.git
    cd WhatsAppLite
    ```
2.  **Build the project**:
    ```bash
    dotnet build
    ```
3.  **Run the application**:
    ```bash
    dotnet run
    ```

### Creating a Release Build

To create a standalone executable for distribution:

```bash
dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
```

The output file will be in `bin/Release/net8.0-windows/win-x64/publish/`.

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

## Acknowledgments

- Built with [Microsoft.Web.WebView2](https://developer.microsoft.com/en-us/microsoft-edge/webview2/).
- Icon provided by WhatsApp (Meta).
