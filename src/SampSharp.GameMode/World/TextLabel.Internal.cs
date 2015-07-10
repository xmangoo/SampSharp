﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode.Natives;

namespace SampSharp.GameMode.World
{
    public partial class TextLabel
    {
        private static class Internal
        {
            public delegate bool Attach3DTextLabelToPlayerImpl(
                int id, int playerid, float offsetX, float offsetY, float offsetZ);

            public delegate bool Attach3DTextLabelToVehicleImpl(
                int id, int vehicleid, float offsetX, float offsetY, float offsetZ);

            public delegate int Create3DTextLabelImpl(
                string text, int color, float x, float y, float z, float drawDistance, int virtualWorld, bool testLOS);

            public delegate bool Update3DTextLabelTextImpl(int id, int color, string text);

            public delegate bool Delete3DTextLabelImpl(int id);

            [Native("Create3DTextLabel")]
            public static readonly Create3DTextLabelImpl Create3DTextLabel = null;
            [Native("Delete3DTextLabel")]
            public static readonly Delete3DTextLabelImpl Delete3DTextLabel = null;

            [Native("Attach3DTextLabelToPlayer")]
            public static readonly Attach3DTextLabelToPlayerImpl
                Attach3DTextLabelToPlayer = null;

            [Native("Attach3DTextLabelToVehicle")]
            public static readonly Attach3DTextLabelToVehicleImpl
                Attach3DTextLabelToVehicle = null;

            [Native("Update3DTextLabelText")]
            public static readonly Update3DTextLabelTextImpl Update3DTextLabelText = null;
        }
    }
}