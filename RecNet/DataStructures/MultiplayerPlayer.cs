﻿// Decompiled with JetBrains decompiler
// Type: RecNet.DataStructures.MultiplayerPlayer
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System.Collections.Generic;

namespace RecNet.DataStructures
{
  public class MultiplayerPlayer
  {
    public MultiplayerPlayer.PlayerData m_PlayerData;

    public MultiplayerPlayer(
      AccountCache account,
      Avatar avatar,
      List<MultiplayerPlayer.AvatarItem> items)
    {
      this.m_PlayerData = new MultiplayerPlayer.PlayerData();
      this.m_PlayerData.Account = account;
      this.m_PlayerData.Avatar = avatar;
      this.m_PlayerData.AvatarItems = items;
    }

    public class PlayerData
    {
      public AccountCache Account;
      public Avatar Avatar;
      public List<MultiplayerPlayer.AvatarItem> AvatarItems;
    }

    public class AvatarItem
    {
      public string AvatarItemDesc { get; set; }

      public int? AvatarItemType { get; set; }

      public int PlatformMask { get; set; }

      public string FriendlyName { get; set; }

      public string Tooltip { get; set; }

      public int Rarity { get; set; }
    }
  }
}
