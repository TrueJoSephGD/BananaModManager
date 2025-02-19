﻿using System.Collections.Generic;

namespace BananaModManager;

public class ManagerConfig
{
        public string GetGameDirectory() => GameDirectories[CurrentProfileIndex];

        /// <summary>
        /// List of directories of the games
        /// </summary>
        public List<string> GameDirectories { get; set; } = new() { "" };

        /// <summary>
        /// Current game
        /// </summary>
        public int CurrentProfileIndex { get; set; } = 0;

        ///<summary>
        ///     Enables One-Click support on GameBanana. Adding "bananamodmanager:" before any valid mod URL will also prompt the One-Click installation.
        /// </summary>
        public bool OneClick { get; set; } = false;

        /// <summary>
        /// Determines which theme to use. 2 is the system default
        /// </summary>
        public int Theme { get; set; } = 2;

        /// <summary>
        /// Modifies the layout to look a bit more like the original mod manager
        /// </summary>
        public bool LegacyLayout { get; set; } = false;

        /// <summary>
        /// Allows for multiple profiles to be created - they save to BananaModManager.json on save/save and play.
        /// </summary>
        public string ProfileName {  get; set; } = string.Empty;
}
