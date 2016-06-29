﻿using System;

namespace SareenaRacing
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MainGame())
                game.Run();
        }
    }
#endif
}
