using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
	private MainManager mainManager;
	[SerializeField] private MainUIManager mainUIManager;
	[SerializeField]
	private string _name;
	public string Name
	{
		get { return _name; }
		set
		{
			if (value.Length < 10)
			{
				_name = value;
			}
			else
			{
				Debug.LogError("Name too long!");
			}
		}
	}

	protected void Start()
	{
		mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
	}

	public virtual string Eat(string food)
	{
		return Name + " ate " + food;
	}

	public abstract string Pet();

	private void OnMouseDown()
	{
		mainManager.SetAnimal(this);
		mainUIManager.SetEventText(Pet());
	}
}