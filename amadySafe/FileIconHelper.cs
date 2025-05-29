using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class FileIconHelper
{
    [DllImport("Shell32.dll")]
    private static extern IntPtr SHGetFileInfo(
        string pszPath,
        uint dwFileAttributes,
        ref SHFILEINFO psfi,
        uint cbFileInfo,
        uint uFlags
    );

    private const uint SHGFI_ICON = 0x100;
    private const uint SHGFI_USEFILEATTRIBUTES = 0x10;
    private const uint FILE_ATTRIBUTE_NORMAL = 0x80;
    private const uint SHGFI_SMALLICON = 0x1;

    [StructLayout(LayoutKind.Sequential)]
    private struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    public static Icon GetIconByExtension(string extension, bool smallIcon = true)
    {
        SHFILEINFO shinfo = new SHFILEINFO();

        SHGetFileInfo(
            extension,
            FILE_ATTRIBUTE_NORMAL,
            ref shinfo,
            (uint)Marshal.SizeOf(shinfo),
            SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | (smallIcon ? SHGFI_SMALLICON : 0)
        );

        Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
        DestroyIcon(shinfo.hIcon); // Cleanup native icon handle

        return icon;
    }

    [DllImport("User32.dll")]
    private static extern int DestroyIcon(IntPtr hIcon);
}
