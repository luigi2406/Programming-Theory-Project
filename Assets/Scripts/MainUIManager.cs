using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

	private void Start()
	{
		SetEventText("Press Spacebar to feed animal");
	}

	public void SetEventText(string eventText)
	{
		text.text = eventText;
	}


}
