#if (UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN) && !DISABLE_WINDOWS_CURSOR
using System;
using System.Runtime.InteropServices;
#endif

namespace JD.WindowsCursor
{
    public enum WindowsCursors
    {
        StandardArrowAndSmallHourglass = 32650,
        StandardArrow = 32512,
        Crosshair = 32515,
        Hand = 32649,
        ArrowAndQuestionMark = 32651,
        IBeam = 32513,
        //Icon = 32641, // Obsolete for applications marked version 4.0 or later. 
        SlashedCircle = 32648,
        //Size = 32640,  // Obsolete for applications marked version 4.0 or later. Use FourPointedArrowPointingNorthSouthEastAndWest
        FourPointedArrowPointingNorthSouthEastAndWest = 32646,
        DoublePointedArrowPointingNortheastAndSouthwest = 32643,
        DoublePointedArrowPointingNorthAndSouth = 32645,
        DoublePointedArrowPointingNorthwestAndSoutheast = 32642,
        DoublePointedArrowPointingWestAndEast = 32644,
        VerticalArrow = 32516,
        Hourglass = 32514
    }
    
    public static class WindowsCursor
    {
#if (UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN) && !DISABLE_WINDOWS_CURSOR
        private static WindowsCursors _lastCursor;
        
        [DllImport("user32.dll", EntryPoint = "SetCursor")]
        private static extern IntPtr _setCursor(IntPtr hCursor);
 
        [DllImport("user32.dll", EntryPoint = "LoadCursor")]
        private static extern IntPtr _loadCursor(IntPtr hInstance, int lpCursorName);
        
        public static void Change(WindowsCursors cursor)
        {
            _lastCursor = cursor;
            _setCursor(_loadCursor(IntPtr.Zero, (int) _lastCursor));
        }

        public static void Update()
        {
            if (_lastCursor == WindowsCursors.StandardArrow) return;
            Change(_lastCursor);
        }
#else
        public static void Change(WindowsCursors cursor)
        {
            
        }

        public static void Update()
        {
            
        }
#endif
    }
}
