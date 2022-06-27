﻿using Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    public class PlayerImageRepository //: ISaveable
    {
        private const string PATH = "../../../SaveFiles/images.txt";
        private const char DELIM = '|';

        //public static List<string> playerImagesList = new List<string>();
        public static Dictionary<string, string> playerImages = new Dictionary<string, string>();

        private static string FormatForFileLine(string player, string imagePath)
            => $"{player}{DELIM}{imagePath}\n";

        public static bool IfFileExists()
        {
            if (File.Exists(PATH))
            {
                return true;
            }
            return false;       
        }

        public void LoadFromFile()
        {
            string[] lines = File.ReadAllLines(PATH);
            foreach (var l in lines)
            {
                string[] details = l.Split(DELIM);
                playerImages[details[0]] = details[1];
            }
        }

        public static string GetImage(string playerName)
            => playerImages[playerName];

        public static void SaveImgToFile()
        {
            //if (!File.Exists(PATH))
            //{
            //    File.Create(PATH).Close();
            //}

            //clears file
            File.Create(PATH).Close();

            //writes all players in file
            //File.WriteAllLines(PATH, playerImagesList);

            foreach (var item in playerImages)
            {
                File.AppendAllText(PATH, FormatForFileLine(item.Key, item.Value));
            }
        }


        public void GivePlayerImage(string playerName, string filePath)
        {
            //playerImagesList.Add(FormatForFileLine(player.Name, filePath));
            playerImages[playerName] = filePath;
        }

        public static bool PlayerHasPicture(string playerName)
        {
            if (playerImages.ContainsKey(playerName))
            {
                if (File.Exists(playerImages[playerName]))
                {
                    return true;
                }
                else
                {
                    playerImages.Remove(playerName);
                    SaveImgToFile();
                }
            }
            return false;
        }

        public void RemovePlayerImage(string playerName)
        {
            playerImages.Remove(playerName);
        }
    }
}
