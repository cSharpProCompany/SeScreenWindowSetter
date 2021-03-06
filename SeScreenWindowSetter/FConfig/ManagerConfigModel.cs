﻿using System;
using System.Collections.Generic;

namespace SeScreenWindowSetter.FConfig
{
    public class ManagerConfigModel
    {
        public List<Screen> Screens { get; set; }
    }

    public class Screen
    {
        public int ScreenNumber { get; set; }
        public List<GridType> GridTypes { get; set; }
    }

    public class GridType
    {
        public string TypeTitle { get; set; }
        public List<Position> Positions { get; set; }
    }

    public class Position
    {
        public int Column { get; set; }
        public int Raw { get; set; }
        public List<Process> Processes { get; set; }
    }

    public class Process
    {
        public string ProcessName { get; set; }
        public IntPtr ProcessHandle { get; set; }
    }
}
