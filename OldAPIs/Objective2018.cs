﻿// Decompiled with JetBrains decompiler
// Type: OldAPIs.Objective2018
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System.Collections.Generic;

namespace OldAPIs
{
  public class Objective2018
  {
    public List<Objective2018Entry> Objectives { get; set; }

    public List<Objective2018Group> ObjectiveGroups { get; set; }

    public Objective2018()
    {
      this.Objectives = new List<Objective2018Entry>()
      {
        new Objective2018Entry()
        {
          Index = 2,
          Group = 0,
          Progress = 0.0f,
          VisualProgress = 0.0f,
          IsCompleted = false,
          IsRewarded = false
        },
        new Objective2018Entry()
        {
          Index = 1,
          Group = 0,
          Progress = 0.0f,
          VisualProgress = 0.0f,
          IsCompleted = false,
          IsRewarded = false
        },
        new Objective2018Entry()
        {
          Index = 0,
          Group = 0,
          Progress = 0.0f,
          VisualProgress = 0.0f,
          IsCompleted = false,
          IsRewarded = false
        }
      };
      this.ObjectiveGroups = new List<Objective2018Group>()
      {
        new Objective2018Group()
        {
          Group = 0,
          IsCompleted = false,
          ClearedAt = "2021-04-18T01:59:14.8642558Z"
        }
      };
    }
  }
}
