﻿using HarmonyLib;
using UnityEngine;

namespace FullAberrationRods
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(FullAberrationRods));
			gameObject.AddComponent<FullAberrationRods>();
            GameObject.DontDestroyOnLoad(gameObject);
            new Harmony("com.dredge.fullaberrationrods").PatchAll();
        }
	}
}