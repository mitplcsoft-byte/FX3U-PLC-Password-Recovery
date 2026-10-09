using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace FX3UDiagnosticApp
{
    public static class MitsubishiFx3uProtocol
    {
        public static string GetExampleCommandSet()
        {
            return "Examples:\n" +
                   "- Text command: READ STATUS\n" +
                   "- Hex command: 50 00 00 00 00 00\n\n" +
                   "This application is for serial protocol debugging and PLC communication checks only.\n" +
                   "It is not intended for password recovery or bypass.\n" +
                   "For password handling, follow Mitsubishi authorized engineering procedures.";
        }

        public static byte[] BuildReadDeviceStatusRequest(int stationNumber)
        {
            // Placeholder example for protocol debugging.
            // Replace with a device-specific command once the PLC protocol and firmware details are confirmed.
            var bytes = new List<byte>
            {
                0x50,
                (byte)stationNumber,
                0x00,
                0x00,
                0x00,
                0x00
            };

            return bytes.ToArray();
        }

        public static string FormatAsciiResponse(byte[] data)
        {
            return Encoding.ASCII.GetString(data);
        }

        public static string FormatHexResponse(byte[] data)
        {
            return HexUtilities.FormatHex(data);
        }
    }
}
