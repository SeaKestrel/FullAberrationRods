using System;
using UnityEngine;
using Winch.Core;

namespace FullAberrationRods
{
	public class FullAberrationRods : MonoBehaviour
	{

		public static FullAberrationRods Instance { get; private set; }
		public void Awake()
        {
			Instance = this;

			GameManager.Instance.OnGameStarted += GameStarted; // Add handler to OnGameStarted event

            WinchCore.Log.Debug($"{nameof(FullAberrationRods)} has loaded!");
        }

		// Update function
        public void Update()
		{
			if (Instance == null) return;


        }

		// GameStarted handler
		public void GameStarted()
		{
			WinchCore.Log.Info("Game started");
        }
    }
}
