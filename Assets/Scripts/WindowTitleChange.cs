using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WindowTitleChange : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowText")]
    public static extern bool SetWindowText(System.IntPtr hwnd, System.String lpString);
    [DllImport("user32.dll", EntryPoint = "FindWindow")]
    public static extern System.IntPtr FindWindow(System.String className, System.String windowName);

    //This method only works on Windows 10
    public static void ChangeWindowTitleAtStart(string newTitle)
    {
        //Get the window handle.
        var windowPtr = FindWindow(null, "itzangiiee_animations");
        //Set the title text using the window handle.
        SetWindowText(windowPtr, newTitle);
    }
    public static void ChangeWindowTitleAtEnd(string newTitle)
    {
        //Get the window handle.
        var windowPtr = FindWindow(null, "Itz Angiiee");
        //Set the title text using the window handle.
        SetWindowText(windowPtr, newTitle);
    }
}
