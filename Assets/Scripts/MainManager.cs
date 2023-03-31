using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
	public string Food { get; set; } = "";
    private Animal animal;
	[SerializeField] private MainUIManager uiManager;

	private void Start()
	{
		SetAnimal("Cat");
	}

	// Update is called once per frame
	void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && Food.Length > 0)
		{
            uiManager.SetEventText(animal.Eat(Food));
		}
    }

	public void SetAnimal(string name)
	{
		animal = GameObject.Find(name).GetComponent<Animal>();
	}

	public void SetAnimal(Animal animal)
	{
		this.animal = animal;
	}
}
