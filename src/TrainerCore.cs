```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PCGamingAutoClicker
{
    public class ProcessMemory
    {
        private Process _process;
        private IntPtr _processHandle;

        public ProcessMemory(string processName)
        {
            AttachToProcess(processName);
        }

        public void AttachToProcess(string processName)
        {
            _process = Process.GetProcessesByName(processName)[0];
            _processHandle = OpenProcess(ProcessAccessFlags.All, false, _process.Id);
        }

        public bool IsGameRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Length > 0;
        }

        public float ReadFloat(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(_processHandle, address, buffer, buffer.Length, out _);
            return BitConverter.ToSingle(buffer, 0);
        }

        public void WriteFloat(IntPtr address, float value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            WriteProcessMemory(_processHandle, address, buffer, buffer.Length, out _);
        }

        public int ReadInt(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(_processHandle, address, buffer, buffer.Length, out _);
            return BitConverter.ToInt32(buffer, 0);
        }

        public void WriteInt(IntPtr address, int value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            WriteProcessMemory(_processHandle, address, buffer, buffer.Length, out _);
        }

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

        [Flags]
        private enum ProcessAccessFlags
        {
            All = 0x1F0FFF,
            VirtualMemoryRead = 0x0010,
            VirtualMemoryWrite = 0x0020,
            VirtualMemoryOperation = 0x0008
        }
    }

    public static class TrainerCore
    {
        public static readonly IntPtr PlayerHealthAddress = new IntPtr(0x00AABBCC);
        public static readonly IntPtr ClickSpeedAddress = new IntPtr(0x00DDEEFF);

        // Example methods for modifying game values
        public static void SetPlayerHealth(ProcessMemory pm, float health)
        {
            pm.WriteFloat