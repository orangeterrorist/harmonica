﻿// Decompiled with JetBrains decompiler
// Type: RecNet.ReportCategory
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace RecNet
{
  public enum ReportCategory
  {
    Moderator = -1, // 0xFFFFFFFF
    Unknown = 0,
    DEPRECATED_MicrophoneAbuse = 1,
    Harassment = 2,
    Cheating = 3,
    DEPRECATED_ImmatureBehavior = 4,
    AFK = 5,
    Misc = 6,
    Underage = 7,
    VoteKick = 10, // 0x0000000A
    CoC_Underage = 100, // 0x00000064
    CoC_Sexual = 101, // 0x00000065
    CoC_Discrimination = 102, // 0x00000066
    CoC_Trolling = 103, // 0x00000067
    CoC_NameOrProfile = 104, // 0x00000068
    IssuingInaccurateReports = 1000, // 0x000003E8
  }
}
