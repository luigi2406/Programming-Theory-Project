using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UINameHandler : MonoBehaviour
{
    private Animal animal;
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        animal = GetComponentInParent<Animal>();
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateAnimalNameUI()
	{
        //text.text = animal.Name;
    }
}
