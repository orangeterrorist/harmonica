﻿// Decompiled with JetBrains decompiler
// Type: OldAPIs.Activities
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class Activities
  {
    public class Charades
    {
      public static string words()
      {
        Console.WriteLine("[API][Charades] Grabbing words. ");
        return JsonConvert.SerializeObject((object) new List<Activities.Charades.word>()
        {
          new Activities.Charades.word()
          {
            EN_US = "Rec Room",
            Difficulty = 0
          },
          new Activities.Charades.word()
          {
            EN_US = "Imposter",
            Difficulty = 0
          },
          new Activities.Charades.word()
          {
            EN_US = "Steve",
            Difficulty = 0
          },
          new Activities.Charades.word()
          {
            EN_US = "Vault",
            Difficulty = 0
          },
          new Activities.Charades.word()
          {
            EN_US = "ur a noob",
            Difficulty = 0
          },
          new Activities.Charades.word()
          {
            EN_US = "get rec'd",
            Difficulty = 0
          }
        });
      }

      public class word
      {
        public string EN_US { get; set; }

        public int Difficulty { get; set; }
      }
    }
  }
}
