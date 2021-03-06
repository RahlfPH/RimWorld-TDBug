﻿using Verse;
using HarmonyLib;

namespace TDBug
{
	[HarmonyPatch(typeof(Log), "ReachedMaxMessagesLimit", MethodType.Getter)]
	class NoLogLimit
	{
		public static void Postfix(ref bool __result) => __result = false;
	}
}
