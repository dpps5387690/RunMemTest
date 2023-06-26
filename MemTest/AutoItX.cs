// Type: AutoIt.AutoItX
// Assembly: AutoItX3.Assembly, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a646454c8d475470
// MVID: 3B36B09F-01C6-4061-950D-CAC7C5DE3D4B
// Assembly location: c:\Program Files (x86)\AutoIt3\AutoItX\AutoItX3.Assembly.dll

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace MemTest
{
  /// <summary>
  /// The AutoItX DLL wrapper class for the native AutoItX3.dll.
  /// 
  /// </summary>
  internal static class AutoItX
  {
    /// <summary>
    /// Default value for _some_ int parameters (largest negative number).
    /// 
    /// </summary>
    public const int INTDEFAULT = -2147483647;
    /// <summary/>
    public const int SW_HIDE = 0;
    /// <summary/>
    public const int SW_SHOWNORMAL = 1;
    /// <summary/>
    public const int SW_NORMAL = 1;
    /// <summary/>
    public const int SW_SHOWMINIMIZED = 2;
    /// <summary/>
    public const int SW_SHOWMAXIMIZED = 3;
    /// <summary/>
    public const int SW_MAXIMIZE = 3;
    /// <summary/>
    public const int SW_SHOWNOACTIVATE = 4;
    /// <summary/>
    public const int SW_SHOW = 5;
    /// <summary/>
    public const int SW_MINIMIZE = 6;
    /// <summary/>
    public const int SW_SHOWMINNOACTIVE = 7;
    /// <summary/>
    public const int SW_SHOWNA = 8;
    /// <summary/>
    public const int SW_RESTORE = 9;
    /// <summary/>
    public const int SW_SHOWDEFAULT = 10;
    /// <summary/>
    public const int SW_FORCEMINIMIZE = 11;
    private const int StringSizePath = 260;
    private const int StringSizeSmall = 1024;
    private const int StringSizeMedium = 65535;
    private const int StringSizeLarge = 1048576;

    /// <summary>
    /// Checks if currently running in 64bit.
    /// 
    /// </summary>
    public static void Init()
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_Init64();
      else
        AutoItX_DLLImport.AU3_Init32();
    }

    /// <summary>
    /// Returns the last error code.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    public static int ErrorCode()
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_error64();
      else
        return AutoItX_DLLImport.AU3_error32();
    }

    //NAUTOIT
          public static int CDTray(string strDrive, string strAction)
        {
        	  if (AutoItX.Is64Bit())
                return AutoItX_DLLImport.AU3_CDTray64(strDrive, strAction);
        	  else 
        	  	return AutoItX_DLLImport.AU3_CDTray32(strDrive, strAction);
        }
          
       public static int RegDeleteKey(string strKeyname)
        {
       	    if (AutoItX.Is64Bit())
                return AutoItX_DLLImport.AU3_RegDeleteKey64(strKeyname);
        	  else 
        	  	return AutoItX_DLLImport.AU3_RegDeleteKey32(strKeyname);

        }

        public static int RegDeleteVal(string strKeyname, string strValuename)
        {
        	 if (AutoItX.Is64Bit())
                return AutoItX_DLLImport.AU3_RegDeleteVal64(strKeyname,strValuename);
        	  else 
        	  	return AutoItX_DLLImport.AU3_RegDeleteVal32(strKeyname,strValuename);
        }

            public static void BlockInput(int nFlag)
        {
       	 if (AutoItX.Is64Bit())
                AutoItX_DLLImport.AU3_BlockInput64(nFlag);
        	  else 
        	    AutoItX_DLLImport.AU3_BlockInput32(nFlag);
        }
    
    //NAUTOIT
    
    /// <summary>
    /// Changes the operation of various AutoIt functions/parameters.
    /// 
    /// </summary>
    /// <param name="option"/><param name="optionValue"/>
    /// <returns/>
    public static int AutoItSetOption(string option, int optionValue)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_AutoItSetOption64(option, optionValue);
      else
        return AutoItX_DLLImport.AU3_AutoItSetOption32(option, optionValue);
    }

    /// <summary>
    /// Changes the operation of various AutoIt functions/parameters.
    /// 
    /// </summary>
    /// <param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ClipGet(int maxLen = 1048576)
    {
      StringBuilder clip = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ClipGet64(clip, clip.Capacity);
      else
        AutoItX_DLLImport.AU3_ClipGet32(clip, clip.Capacity);
      return ((object) clip).ToString();
    }

    /// <summary>
    /// Changes the operation of various AutoIt functions/parameters.
    /// 
    /// </summary>
    /// <param name="text"/>
    public static void ClipPut(string text)
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ClipPut64(text);
      else
        AutoItX_DLLImport.AU3_ClipPut32(text);
    }

    /// <summary/>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="button"/><param name="numClicks"/><param name="x"/><param name="y"/>
    /// <returns/>
    public static int ControlClick(string title, string text, string control, string button = "left", int numClicks = 1, int x = -2147483647, int y = -2147483647)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlClick64(title, text, control, button, numClicks, x, y);
      else
        return AutoItX_DLLImport.AU3_ControlClick32(title, text, control, button, numClicks, x, y);
    }

    /// <summary>
    /// Changes the operation of various AutoIt functions/parameters.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="button"/><param name="numClicks"/><param name="x"/><param name="y"/>
    /// <returns/>
    public static int ControlClick(IntPtr winHandle, IntPtr controlHandle, string button = "left", int numClicks = 1, int x = -2147483647, int y = -2147483647)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlClickByHandle64(winHandle, controlHandle, button, numClicks, x, y);
      else
        return AutoItX_DLLImport.AU3_ControlClickByHandle32(winHandle, controlHandle, button, numClicks, x, y);
    }

    /// <summary>
    /// Sends a command to a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="command"/><param name="extra"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlCommand(string title, string text, string control, string command, string extra, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlCommand64(title, text, control, command, extra, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlCommand32(title, text, control, command, extra, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Sends a command to a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="command"/><param name="extra"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlCommand(IntPtr winHandle, IntPtr controlHandle, string command, string extra, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlCommandByHandle64(winHandle, controlHandle, command, extra, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlCommandByHandle32(winHandle, controlHandle, command, extra, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Sends a command to a ListView32 control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="command"/><param name="extra1"/><param name="extra2"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlListView(string title, string text, string control, string command, string extra1, string extra2, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlListView64(title, text, control, command, extra1, extra2, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlListView32(title, text, control, command, extra1, extra2, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Sends a command to a ListView32 control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="command"/><param name="extra1"/><param name="extra2"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlListView(IntPtr winHandle, IntPtr controlHandle, string command, string extra1, string extra2, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlListViewByHandle64(winHandle, controlHandle, command, extra1, extra2, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlListViewByHandle32(winHandle, controlHandle, command, extra1, extra2, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Disables or "grays-out" a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static int ControlDisable(string title, string text, string control)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlDisable64(title, text, control);
      else
        return AutoItX_DLLImport.AU3_ControlDisable32(title, text, control);
    }

    /// <summary>
    /// Disables or "grays-out" a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static int ControlDisable(IntPtr winHandle, IntPtr controlHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlDisableByHandle64(winHandle, controlHandle);
      else
        return AutoItX_DLLImport.AU3_ControlDisableByHandle32(winHandle, controlHandle);
    }

    /// <summary>
    /// Enables a "grayed-out" control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static int ControlEnable(string title, string text, string control)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlEnable64(title, text, control);
      else
        return AutoItX_DLLImport.AU3_ControlEnable32(title, text, control);
    }

    /// <summary>
    /// Enables a "grayed-out" control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static int ControlEnable(IntPtr winHandle, IntPtr controlHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlEnableByHandle64(winHandle, controlHandle);
      else
        return AutoItX_DLLImport.AU3_ControlEnableByHandle32(winHandle, controlHandle);
    }

    /// <summary>
    /// Sets input focus to a given control on a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static int ControlFocus(string title, string text, string control)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlFocus64(title, text, control);
      else
        return AutoItX_DLLImport.AU3_ControlFocus32(title, text, control);
    }

    /// <summary>
    /// Sets input focus to a given control on a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static int ControlFocus(IntPtr winHandle, IntPtr controlHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlFocusByHandle64(winHandle, controlHandle);
      else
        return AutoItX_DLLImport.AU3_ControlFocusByHandle32(winHandle, controlHandle);
    }

    /// <summary>
    /// Returns the ControlRef# of the control that has keyboard focus within a specified window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlGetFocus(string title = "", string text = "", int maxLen = 65535)
    {
      StringBuilder controlWithFocus = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetFocus64(title, text, controlWithFocus, controlWithFocus.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlGetFocus32(title, text, controlWithFocus, controlWithFocus.Capacity);
      return ((object) controlWithFocus).ToString();
    }

    /// <summary>
    /// Returns the ControlRef# of the control that has keyboard focus within a specified window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlGetFocus(IntPtr winHandle, int maxLen = 65535)
    {
      StringBuilder controlWithFocus = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetFocusByHandle64(winHandle, controlWithFocus, controlWithFocus.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlGetFocusByHandle32(winHandle, controlWithFocus, controlWithFocus.Capacity);
      return ((object) controlWithFocus).ToString();
    }

    /// <summary>
    /// Retrieves the internal handle of a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static IntPtr ControlGetHandle(IntPtr winHandle, string control = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlGetHandle64(winHandle, control);
      else
        return AutoItX_DLLImport.AU3_ControlGetHandle32(winHandle, control);
    }

    /// <summary>
    /// Retrieves the internal handle of a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlGetHandleAsText(string title = "", string text = "", string control = "", int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetHandleAsText64(title, text, control, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlGetHandleAsText32(title, text, control, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the position and size of a control relative to it's window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static Rectangle ControlGetPos(string title = "", string text = "", string control = "")
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetPos64(title, text, control, ref rect);
      else
        AutoItX_DLLImport.AU3_ControlGetPos32(title, text, control, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves the position and size of a control relative to it's window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static Rectangle ControlGetPos(IntPtr winHandle, IntPtr controlHandle)
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetPosByHandle64(winHandle, controlHandle, ref rect);
      else
        AutoItX_DLLImport.AU3_ControlGetPosByHandle32(winHandle, controlHandle, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves text from a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlGetText(string title, string text, string control, int maxLen = 65535)
    {
      StringBuilder controlText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetText64(title, text, control, controlText, controlText.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlGetText32(title, text, control, controlText, controlText.Capacity);
      return ((object) controlText).ToString();
    }

    /// <summary>
    /// Retrieves text from a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlGetText(IntPtr winHandle, IntPtr controlHandle, int maxLen = 65535)
    {
      StringBuilder controlText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlGetTextByHandle64(winHandle, controlHandle, controlText, controlText.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlGetTextByHandle32(winHandle, controlHandle, controlText, controlText.Capacity);
      return ((object) controlText).ToString();
    }

    /// <summary>
    /// Hides a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static int ControlHide(string title, string text, string control)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlHide64(title, text, control);
      else
        return AutoItX_DLLImport.AU3_ControlHide32(title, text, control);
    }

    /// <summary>
    /// Hides a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static int ControlHide(IntPtr winHandle, IntPtr controlHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlHideByHandle64(winHandle, controlHandle);
      else
        return AutoItX_DLLImport.AU3_ControlHideByHandle32(winHandle, controlHandle);
    }

    /// <summary>
    /// Moves a control within a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="x"/><param name="y"/><param name="width"/><param name="height"/>
    /// <returns/>
    public static int ControlMove(string title, string text, string control, int x, int y, int width = -1, int height = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlMove64(title, text, control, x, y, width, height);
      else
        return AutoItX_DLLImport.AU3_ControlMove32(title, text, control, x, y, width, height);
    }

    /// <summary>
    /// Moves a control within a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="x"/><param name="y"/><param name="width"/><param name="height"/>
    /// <returns/>
    public static int ControlMove(IntPtr winHandle, IntPtr controlHandle, int x, int y, int width = -1, int height = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlMoveByHandle64(winHandle, controlHandle, x, y, width, height);
      else
        return AutoItX_DLLImport.AU3_ControlMoveByHandle32(winHandle, controlHandle, x, y, width, height);
    }

    /// <summary>
    /// Sends a string of characters to a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="sendText"/><param name="mode"/>
    /// <returns/>
    public static int ControlSend(string title, string text, string control, string sendText, int mode = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlSend64(title, text, control, sendText, mode);
      else
        return AutoItX_DLLImport.AU3_ControlSend32(title, text, control, sendText, mode);
    }

    /// <summary>
    /// Sends a string of characters to a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="sendText"/><param name="mode"/>
    /// <returns/>
    public static int ControlSend(IntPtr winHandle, IntPtr controlHandle, string sendText, int mode = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlSendByHandle64(winHandle, controlHandle, sendText, mode);
      else
        return AutoItX_DLLImport.AU3_ControlSendByHandle32(winHandle, controlHandle, sendText, mode);
    }

    /// <summary>
    /// Sets text of a control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="controlText"/>
    /// <returns/>
    public static int ControlSetText(string title, string text, string control, string controlText)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlSetText64(title, text, control, controlText);
      else
        return AutoItX_DLLImport.AU3_ControlSetText32(title, text, control, controlText);
    }

    /// <summary>
    /// Sets text of a control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="controlText"/>
    /// <returns/>
    public static int ControlSetText(IntPtr winHandle, IntPtr controlHandle, string controlText)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlSetTextByHandle64(winHandle, controlHandle, controlText);
      else
        return AutoItX_DLLImport.AU3_ControlSetTextByHandle32(winHandle, controlHandle, controlText);
    }

    /// <summary>
    /// Shows a control that was hidden.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param>
    /// <returns/>
    public static int ControlShow(string title, string text, string control)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlShow64(title, text, control);
      else
        return AutoItX_DLLImport.AU3_ControlShow32(title, text, control);
    }

    /// <summary>
    /// Shows a control that was hidden.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param>
    /// <returns/>
    public static int ControlShow(IntPtr winHandle, IntPtr controlHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ControlShowByHandle64(winHandle, controlHandle);
      else
        return AutoItX_DLLImport.AU3_ControlShowByHandle32(winHandle, controlHandle);
    }

    /// <summary>
    /// Sends a command to a TreeView32 control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="control">The control to search for.</param><param name="command"/><param name="extra1"/><param name="extra2"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlTreeView(string title, string text, string control, string command, string extra1, string extra2, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlTreeView64(title, text, control, command, extra1, extra2, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlTreeView32(title, text, control, command, extra1, extra2, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Sends a command to a TreeView32 control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="controlHandle">The control handle to search for.</param><param name="command"/><param name="extra1"/><param name="extra2"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string ControlTreeView(IntPtr winHandle, IntPtr controlHandle, string command, string extra1, string extra2, int maxLen = 65535)
    {
      StringBuilder result = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ControlTreeViewByHandle64(winHandle, controlHandle, command, extra1, extra2, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_ControlTreeViewByHandle32(winHandle, controlHandle, command, extra1, extra2, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Maps a network drive.
    /// 
    /// </summary>
    /// <param name="device"/><param name="share"/><param name="flags"/><param name="user"/><param name="password"/>
    /// <returns/>
    public static string DriveMapAdd(string device, string share, int flags = 0, string user = "", string password = "")
    {
      StringBuilder result = new StringBuilder(4);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_DriveMapAdd64(device, share, flags, user, password, result, result.Capacity);
      else
        AutoItX_DLLImport.AU3_DriveMapAdd32(device, share, flags, user, password, result, result.Capacity);
      return ((object) result).ToString();
    }

    /// <summary>
    /// Disconnects a network drive.
    /// 
    /// </summary>
    /// <param name="device"/>
    /// <returns/>
    public static int DriveMapDel(string device)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_DriveMapDel64(device);
      else
        return AutoItX_DLLImport.AU3_DriveMapDel32(device);
    }

    /// <summary>
    /// Retreives the details of a mapped drive.
    /// 
    /// </summary>
    /// <param name="device"/>
    /// <returns/>
    public static string DriveMapGet(string device)
    {
      StringBuilder mapping = new StringBuilder(260);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_DriveMapGet64(device, mapping, mapping.Capacity);
      else
        AutoItX_DLLImport.AU3_DriveMapGet32(device, mapping, mapping.Capacity);
      return ((object) mapping).ToString();
    }

    /// <summary>
    /// Checks if the current user has administrator privileges.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    public static int IsAdmin()
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_IsAdmin64();
      else
        return AutoItX_DLLImport.AU3_IsAdmin32();
    }

    /// <summary>
    /// Perform a mouse click operation.
    /// 
    /// </summary>
    /// <param name="button"/><param name="x"/><param name="y"/><param name="numClicks"/><param name="speed"/>
    /// <returns/>
    public static int MouseClick(string button = "LEFT", int x = -2147483647, int y = -2147483647, int numClicks = 1, int speed = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_MouseClick64(button, x, y, numClicks, speed);
      else
        return AutoItX_DLLImport.AU3_MouseClick32(button, x, y, numClicks, speed);
    }

    /// <summary>
    /// Perform a mouse click and drag operation.
    /// 
    /// </summary>
    /// <param name="button"/><param name="x1"/><param name="y1"/><param name="x2"/><param name="y2"/><param name="speed"/>
    /// <returns/>
    public static int MouseClickDrag(string button, int x1, int y1, int x2, int y2, int speed = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_MouseClickDrag64(button, x1, y1, x2, y2, speed);
      else
        return AutoItX_DLLImport.AU3_MouseClickDrag32(button, x1, y1, x2, y2, speed);
    }

    /// <summary>
    /// Perform a mouse down event at the current mouse position.
    /// 
    /// </summary>
    /// <param name="button"/>
    public static void MouseDown(string button = "LEFT")
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_MouseDown64(button);
      else
        AutoItX_DLLImport.AU3_MouseDown32(button);
    }

    /// <summary>
    /// Returns a cursor ID Number of the current Mouse Cursor.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    public static int MouseGetCursor()
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_MouseGetCursor64();
      else
        return AutoItX_DLLImport.AU3_MouseGetCursor32();
    }

    /// <summary>
    /// Retrieves the current position of the mouse cursor.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    public static Point MouseGetPos()
    {
      AutoItX_DLLImport.POINT pt = new AutoItX_DLLImport.POINT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_MouseGetPos64(ref pt);
      else
        AutoItX_DLLImport.AU3_MouseGetPos32(ref pt);
      return new Point(pt.x, pt.y);
    }

    /// <summary>
    /// Moves the mouse pointer.
    /// 
    /// </summary>
    /// <param name="x"/><param name="y"/><param name="speed"/>
    /// <returns/>
    public static int MouseMove(int x, int y, int speed = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_MouseMove64(x, y, speed);
      else
        return AutoItX_DLLImport.AU3_MouseMove32(x, y, speed);
    }

    /// <summary>
    /// Perform a mouse up event at the current mouse position.
    /// 
    /// </summary>
    /// <param name="button"/>
    public static void MouseUp(string button = "LEFT")
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_MouseUp64(button);
      else
        AutoItX_DLLImport.AU3_MouseUp32(button);
    }

    /// <summary/>
    /// <param name="direction"/><param name="numClicks"/>
    public static void MouseWheel(string direction, int numClicks)
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_MouseWheel64(direction, numClicks);
      else
        AutoItX_DLLImport.AU3_MouseWheel32(direction, numClicks);
    }

    /// <summary>
    /// Moves the mouse wheel up or down.
    /// 
    /// </summary>
    /// <param name="rect"/><param name="step"/>
    /// <returns/>
    public static uint PixelChecksum(Rectangle rect, int step = 1)
    {
      AutoItX_DLLImport.RECT rect1;
      rect1.left = rect.Left;
      rect1.top = rect.Top;
      rect1.right = rect.Right;
      rect1.bottom = rect.Bottom;
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_PixelChecksum64(ref rect1, step);
      else
        return AutoItX_DLLImport.AU3_PixelChecksum32(ref rect1, step);
    }

    /// <summary>
    /// Returns a pixel color according to x,y pixel coordinates.
    /// 
    /// </summary>
    /// <param name="x"/><param name="y"/>
    /// <returns/>
    public static int PixelGetColor(int x, int y)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_PixelGetColor64(x, y);
      else
        return AutoItX_DLLImport.AU3_PixelGetColor32(x, y);
    }

    /// <summary>
    /// Searches a rectangle of pixels for the pixel color provided.
    /// 
    /// </summary>
    /// <param name="rect"/><param name="color"/><param name="shade"/><param name="step"/>
    /// <returns/>
    public static Point PixelSearch(Rectangle rect, int color, int shade = 0, int step = 1)
    {
      AutoItX_DLLImport.RECT rect1;
      rect1.left = rect.Left;
      rect1.top = rect.Top;
      rect1.right = rect.Right;
      rect1.bottom = rect.Bottom;
      AutoItX_DLLImport.POINT winPoint = new AutoItX_DLLImport.POINT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_PixelSearch64(ref rect1, color, shade, step, ref winPoint);
      else
        AutoItX_DLLImport.AU3_PixelSearch32(ref rect1, color, shade, step, ref winPoint);
      return new Point(winPoint.x, winPoint.y);
    }

    /// <summary>
    /// Terminates a named process.
    /// 
    /// </summary>
    /// <param name="process"/>
    /// <returns/>
    public static int ProcessClose(string process)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ProcessClose64(process);
      else
        return AutoItX_DLLImport.AU3_ProcessClose32(process);
    }

    /// <summary>
    /// Checks to see if a specified process exists.
    /// 
    /// </summary>
    /// <param name="process"/>
    /// <returns/>
    public static int ProcessExists(string process)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ProcessExists64(process);
      else
        return AutoItX_DLLImport.AU3_ProcessExists32(process);
    }

    /// <summary>
    /// Changes the priority of a process.
    /// 
    /// </summary>
    /// <param name="process"/><param name="priority"/>
    /// <returns/>
    public static int ProcessSetPriority(string process, int priority)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ProcessSetPriority64(process, priority);
      else
        return AutoItX_DLLImport.AU3_ProcessSetPriority32(process, priority);
    }

    /// <summary>
    /// Pauses script execution until a given process exists.
    /// 
    /// </summary>
    /// <param name="process"/><param name="timeout"/>
    /// <returns/>
    public static int ProcessWait(string process, int timeout)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ProcessWait64(process, timeout);
      else
        return AutoItX_DLLImport.AU3_ProcessWait32(process, timeout);
    }

    /// <summary>
    /// Pauses script execution until a given process does not exist.
    /// 
    /// </summary>
    /// <param name="process"/><param name="timeout"/>
    /// <returns/>
    public static int ProcessWaitClose(string process, int timeout)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_ProcessWaitClose64(process, timeout);
      else
        return AutoItX_DLLImport.AU3_ProcessWaitClose32(process, timeout);
    }

    /// <summary>
    /// Runs an external program.
    /// 
    /// </summary>
    /// <param name="program">The program to run.</param><param name="dir">The working directory to use.</param><param name="showFlag"/>
    /// <returns/>
    public static int Run(string program, string dir, int showFlag = 1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_Run64(program, dir, showFlag);
      else
        return AutoItX_DLLImport.AU3_Run32(program, dir, showFlag);
    }

    /// <summary>
    /// Runs an external program as a specified user.
    /// 
    /// </summary>
    /// <param name="user"/><param name="domain"/><param name="password"/><param name="logonFlag"/><param name="program">The program to run.</param><param name="dir">The working directory to use.</param><param name="showFlag"/>
    /// <returns/>
    public static int RunAs(string user, string domain, string password, int logonFlag, string program, string dir, int showFlag = 1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_RunAs64(user, domain, password, logonFlag, program, dir, showFlag);
      else
        return AutoItX_DLLImport.AU3_RunAs32(user, domain, password, logonFlag, program, dir, showFlag);
    }

    /// <summary>
    /// Runs an external program as a specified user and wait for it to close.
    /// 
    /// </summary>
    /// <param name="user"/><param name="domain"/><param name="password"/><param name="logonFlag"/><param name="program">The program to run.</param><param name="dir">The working directory to use.</param><param name="showFlag"/>
    /// <returns/>
    public static int RunAsWait(string user, string domain, string password, int logonFlag, string program, string dir, int showFlag = 1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_RunAsWait64(user, domain, password, logonFlag, program, dir, showFlag);
      else
        return AutoItX_DLLImport.AU3_RunAsWait32(user, domain, password, logonFlag, program, dir, showFlag);
    }

    /// <summary>
    /// Runs an external program and wait for it to close.
    /// 
    /// </summary>
    /// <param name="program">The program to run.</param><param name="dir">The working directory to use.</param><param name="showFlag"/>
    /// <returns/>
    public static int RunWait(string program, string dir, int showFlag = 1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_RunWait64(program, dir, showFlag);
      else
        return AutoItX_DLLImport.AU3_RunWait32(program, dir, showFlag);
    }

    /// <summary>
    /// Sends simulated keystrokes to the active window.
    /// 
    /// </summary>
    /// <param name="sendText"/><param name="mode"/>
    public static void Send(string sendText, int mode = 0)
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_Send64(sendText, mode);
      else
        AutoItX_DLLImport.AU3_Send32(sendText, mode);
    }

    /// <summary>
    /// Shut down the system.
    /// 
    /// </summary>
    /// <param name="flag"/>
    /// <returns/>
    public static int Shutdown(int flag)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_Shutdown64(flag);
      else
        return AutoItX_DLLImport.AU3_Shutdown32(flag);
    }

    /// <summary>
    /// Pause for specified number of milliseconds.
    /// 
    /// </summary>
    /// <param name="milliseconds"/>
    public static void Sleep(int milliseconds)
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_Sleep64(milliseconds);
      else
        AutoItX_DLLImport.AU3_Sleep32(milliseconds);
    }

    /// <summary>
    /// Retrieves the text from a standard status bar control.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="part"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string StatusBarGetText(string title = "", string text = "", int part = 1, int maxLen = 65535)
    {
      StringBuilder statusText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_StatusbarGetText64(title, text, part, statusText, statusText.Capacity);
      else
        AutoItX_DLLImport.AU3_StatusbarGetText32(title, text, part, statusText, statusText.Capacity);
      return ((object) statusText).ToString();
    }

    /// <summary>
    /// Retrieves the text from a standard status bar control.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="part"/><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string StatusBarGetText(IntPtr winHandle, int part = 1, int maxLen = 65535)
    {
      StringBuilder statusText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_StatusbarGetTextByHandle64(winHandle, part, statusText, statusText.Capacity);
      else
        AutoItX_DLLImport.AU3_StatusbarGetTextByHandle32(winHandle, part, statusText, statusText.Capacity);
      return ((object) statusText).ToString();
    }

    /// <summary>
    /// Retrieves the text from a standard status bar control.
    /// 
    /// </summary>
    /// <param name="tip"/><param name="x"/><param name="y"/>
    public static void ToolTip(string tip, int x = -2147483647, int y = -2147483647)
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_ToolTip64(tip, x, y);
      else
        AutoItX_DLLImport.AU3_ToolTip32(tip, x, y);
    }

    /// <summary>
    /// Activates (gives focus to) a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinActivate(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinActivate64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinActivate32(title, text);
    }

    /// <summary>
    /// Activates (gives focus to) a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinActivate(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinActivateByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinActivateByHandle32(winHandle);
    }

    /// <summary>
    /// Checks to see if a specified window exists and is currently active.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinActive(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinActive64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinActive32(title, text);
    }

    /// <summary>
    /// Checks to see if a specified window exists and is currently active.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinActive(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinActiveByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinActiveByHandle32(winHandle);
    }

    /// <summary>
    /// Checks to see if a specified window exists.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinExists(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinExists64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinExists32(title, text);
    }

    /// <summary>
    /// Checks to see if a specified window exists.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinExists(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinExistsByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinExistsByHandle32(winHandle);
    }

    /// <summary>
    /// Closes a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinClose(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinClose64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinClose32(title, text);
    }

    /// <summary>
    /// Closes a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinClose(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinCloseByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinCloseByHandle32(winHandle);
    }

    /// <summary>
    /// Returns the coordinates of the caret in the foreground window.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    public static Point WinGetCaretPos()
    {
      AutoItX_DLLImport.POINT pt;
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetCaretPos64(out pt);
      else
        AutoItX_DLLImport.AU3_WinGetCaretPos32(out pt);
      return new Point(pt.x, pt.y);
    }

    /// <summary>
    /// Retrieves the classes from a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetClassList(string title = "", string text = "", int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetClassList64(title, text, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetClassList32(title, text, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the classes from a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetClassList(IntPtr winHandle, int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetClassListByHandle64(winHandle, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetClassListByHandle32(winHandle, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the size of a given window's client area.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static Rectangle WinGetClientSize(string title = "", string text = "")
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetClientSize64(title, text, ref rect);
      else
        AutoItX_DLLImport.AU3_WinGetClientSize32(title, text, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves the size of a given window's client area.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static Rectangle WinGetClientSize(IntPtr winHandle)
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetClientSizeByHandle64(winHandle, ref rect);
      else
        AutoItX_DLLImport.AU3_WinGetClientSizeByHandle32(winHandle, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves the internal handle of a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static IntPtr WinGetHandle(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinGetHandle64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinGetHandle32(title, text);
    }

    /// <summary>
    /// Retrieves the internal handle of a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetHandleAsText(string title = "", string text = "", int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetHandleAsText64(title, text, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetHandleAsText32(title, text, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the position and size of a given window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static Rectangle WinGetPos(string title = "", string text = "")
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetPos64(title, text, ref rect);
      else
        AutoItX_DLLImport.AU3_WinGetPos32(title, text, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves the position and size of a given window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static Rectangle WinGetPos(IntPtr winHandle)
    {
      AutoItX_DLLImport.RECT rect = new AutoItX_DLLImport.RECT();
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetPosByHandle64(winHandle, ref rect);
      else
        AutoItX_DLLImport.AU3_WinGetPosByHandle32(winHandle, ref rect);
      return new Rectangle()
      {
        X = rect.left,
        Y = rect.top,
        Width = rect.right - rect.left,
        Height = rect.bottom - rect.top
      };
    }

    /// <summary>
    /// Retrieves the Process ID (PID) associated with a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static uint WinGetProcess(string title = "", string text = "", int maxLen = 65535)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinGetProcess64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinGetProcess32(title, text);
    }

    /// <summary>
    /// Retrieves the Process ID (PID) associated with a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static uint WinGetProcess(IntPtr winHandle, int maxLen = 65535)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinGetProcessByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinGetProcessByHandle32(winHandle);
    }

    /// <summary>
    /// Retrieves the state of a given window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinGetState(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinGetState64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinGetState32(title, text);
    }

    /// <summary>
    /// Retrieves the state of a given window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinGetState(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinGetStateByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinGetStateByHandle32(winHandle);
    }

    /// <summary>
    /// Retrieves the text from a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetText(string title = "", string text = "", int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetText64(title, text, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetText32(title, text, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the text from a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetText(IntPtr winHandle, int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetTextByHandle64(winHandle, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetTextByHandle32(winHandle, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the full title from a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetTitle(string title = "", string text = "", int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetTitle64(title, text, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetTitle32(title, text, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Retrieves the full title from a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="maxLen">The maximum number of characters to return.</param>
    /// <returns/>
    public static string WinGetTitle(IntPtr winHandle, int maxLen = 65535)
    {
      StringBuilder retText = new StringBuilder(maxLen);
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinGetTitleByHandle64(winHandle, retText, retText.Capacity);
      else
        AutoItX_DLLImport.AU3_WinGetTitleByHandle32(winHandle, retText, retText.Capacity);
      return ((object) retText).ToString();
    }

    /// <summary>
    /// Forces a window to close.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param>
    /// <returns/>
    public static int WinKill(string title = "", string text = "")
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinKill64(title, text);
      else
        return AutoItX_DLLImport.AU3_WinKill32(title, text);
    }

    /// <summary>
    /// Forces a window to close.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param>
    /// <returns/>
    public static int WinKill(IntPtr winHandle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinKillByHandle64(winHandle);
      else
        return AutoItX_DLLImport.AU3_WinKillByHandle32(winHandle);
    }

    /// <summary>
    /// Minimizes all windows.
    /// 
    /// </summary>
    public static void WinMinimizeAll()
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinMinimizeAll64();
      else
        AutoItX_DLLImport.AU3_WinMinimizeAll32();
    }

    /// <summary>
    /// Undoes a previous WinMinimizeAll function.
    /// 
    /// </summary>
    public static void WinMinimizeAllUndo()
    {
      if (AutoItX.Is64Bit())
        AutoItX_DLLImport.AU3_WinMinimizeAllUndo64();
      else
        AutoItX_DLLImport.AU3_WinMinimizeAllUndo32();
    }

    /// <summary>
    /// Moves and/or resizes a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="x"/><param name="y"/><param name="width"/><param name="height"/>
    /// <returns/>
    public static int WinMove(string title, string text, int x, int y, int width = -1, int height = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinMove64(title, text, x, y, width, height);
      else
        return AutoItX_DLLImport.AU3_WinMove32(title, text, x, y, width, height);
    }

    /// <summary>
    /// Moves and/or resizes a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="x"/><param name="y"/><param name="width"/><param name="height"/>
    /// <returns/>
    public static int WinMove(IntPtr winHandle, int x, int y, int width = -1, int height = -1)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinMoveByHandle64(winHandle, x, y, width, height);
      else
        return AutoItX_DLLImport.AU3_WinMoveByHandle32(winHandle, x, y, width, height);
    }

    /// <summary>
    /// Change a window's "Always On Top" attribute.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="flag"/>
    /// <returns/>
    public static int WinSetOnTop(string title, string text, int flag)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetOnTop64(title, text, flag);
      else
        return AutoItX_DLLImport.AU3_WinSetOnTop32(title, text, flag);
    }

    /// <summary>
    /// Change a window's "Always On Top" attribute.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="flag"/>
    /// <returns/>
    public static int WinSetOnTop(IntPtr winHandle, int flag)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetOnTopByHandle64(winHandle, flag);
      else
        return AutoItX_DLLImport.AU3_WinSetOnTopByHandle32(winHandle, flag);
    }

    /// <summary>
    /// Shows, hides, minimizes, maximizes, or restores a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="flags"/>
    /// <returns/>
    public static int WinSetState(string title, string text, int flags)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetState64(title, text, flags);
      else
        return AutoItX_DLLImport.AU3_WinSetState32(title, text, flags);
    }

    /// <summary>
    /// Shows, hides, minimizes, maximizes, or restores a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="flags"/>
    /// <returns/>
    public static int WinSetState(IntPtr winHandle, int flags)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetStateByHandle64(winHandle, flags);
      else
        return AutoItX_DLLImport.AU3_WinSetStateByHandle32(winHandle, flags);
    }

    /// <summary>
    /// Changes the title of a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="newTitle"/>
    /// <returns/>
    public static int WinSetTitle(string title, string text, string newTitle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetTitle64(title, text, newTitle);
      else
        return AutoItX_DLLImport.AU3_WinSetTitle32(title, text, newTitle);
    }

    /// <summary>
    /// Changes the title of a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="newTitle"/>
    /// <returns/>
    public static int WinSetTitle(IntPtr winHandle, string newTitle)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetTitleByHandle64(winHandle, newTitle);
      else
        return AutoItX_DLLImport.AU3_WinSetTitleByHandle32(winHandle, newTitle);
    }

    /// <summary>
    /// Sets the transparency of a window.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="trans"/>
    /// <returns/>
    public static int WinSetTrans(string title, string text, int trans)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetTrans64(title, text, trans);
      else
        return AutoItX_DLLImport.AU3_WinSetTrans32(title, text, trans);
    }

    /// <summary>
    /// Sets the transparency of a window.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="trans"/>
    /// <returns/>
    public static int WinSetTrans(IntPtr winHandle, int trans)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinSetTransByHandle64(winHandle, trans);
      else
        return AutoItX_DLLImport.AU3_WinSetTransByHandle32(winHandle, trans);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window exists.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWait(string title = "", string text = "", int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWait64(title, text, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWait32(title, text, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window exists.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWait(IntPtr winHandle, int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitByHandle64(winHandle, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitByHandle32(winHandle, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window is active.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitActive(string title = "", string text = "", int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitActive64(title, text, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitActive32(title, text, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window is active.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitActive(IntPtr winHandle, int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitActiveByHandle64(winHandle, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitActiveByHandle32(winHandle, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window does not exist.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitClose(string title = "", string text = "", int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitClose64(title, text, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitClose32(title, text, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window does not exist.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitClose(IntPtr winHandle, int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitCloseByHandle64(winHandle, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitCloseByHandle32(winHandle, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window is not active.
    /// 
    /// </summary>
    /// <param name="title">The window title to search for.</param><param name="text">The window text to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitNotActive(string title = "", string text = "", int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitNotActive64(title, text, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitNotActive32(title, text, timeout);
    }

    /// <summary>
    /// Pauses execution of the script until the requested window is not active.
    /// 
    /// </summary>
    /// <param name="winHandle">The window handle to search for.</param><param name="timeout"/>
    /// <returns/>
    public static int WinWaitNotActive(IntPtr winHandle, int timeout = 0)
    {
      if (AutoItX.Is64Bit())
        return AutoItX_DLLImport.AU3_WinWaitNotActiveByHandle64(winHandle, timeout);
      else
        return AutoItX_DLLImport.AU3_WinWaitNotActiveByHandle32(winHandle, timeout);
    }

    private static bool Is64Bit()
    {
      return Marshal.SizeOf((object) IntPtr.Zero) != 4;
    }
  }
}
