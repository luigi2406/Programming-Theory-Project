using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public string CatName { get; set; } = "";
	public string DogName { get; set; } = "";

	public static MenuManager Instance { get; private set; }

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void StartGame()
	{
		if (CatName.Length > 0 && DogName.Length > 0)
		{
			SceneManager.LoadScene(1);
		}

	}
}
