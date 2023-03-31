using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
	public override string Pet()
	{
		return "Meow";
	}

	public override string Eat(string food)
	{
		return Name + " munches on " + food;
	}
}
