using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
public abstract class Animal : MonoBehaviour
{
	private MainManager mainManager;
	private TextMeshProUGUI nameUI;
	[SerializeField]
	private MainUIManager mainUIManager;
	[SerializeField]
	private string _name;
	public string Name // ENCAPSULATION
	{
		get { return _name; }
		set
		{
			if (value.Length < 10)
			{
				_name = value;
				nameUI.text = value;
			}
			else
			{
				Debug.LogError("Name too long!");
			}
		}
	}

	protected void Awake()
	{
		mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
		nameUI = GetComponentInChildren<TextMeshProUGUI>();
		nameUI.text = _name;
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
