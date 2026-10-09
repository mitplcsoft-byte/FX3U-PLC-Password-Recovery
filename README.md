# FX3U-PLC-Password-Recovery

This repository contains a Windows 10-compatible serial diagnostic application for Mitsubishi FX3U PLC communication over RS-232.

Important:
- This project is a legitimate engineering diagnostic tool only.
- It is not intended to bypass, recover, or extract PLC passwords.
- Use only on equipment you own, operate, or are explicitly authorized to test.

The application provides:
- COM port selection
- RS-232 configuration (baud, parity, data bits, stop bits)
- raw command transmission in text or hex
- live receive log for PLC diagnostics
- examples for communication troubleshooting

## Project structure

- `FX3UDiagnosticApp/` - Windows Forms application source
- `README.md` - usage documentation
- `.gitignore` - standard Visual Studio exclusions

## Requirements

- Windows 10 or later
- .NET 8 SDK
- Visual Studio 2022 or later (recommended)

## Build

Open a terminal in the repository root and run:

```bash
dotnet build FX3UDiagnosticApp/FX3UDiagnosticApp.csproj
```

## Run

```bash
dotnet run --project FX3UDiagnosticApp/FX3UDiagnosticApp.csproj
```

## Notes

This tool is designed for protocol debugging and communication verification. For production PLC access or password handling, use factory-authorized Mitsubishi tools and authorized engineering procedures.