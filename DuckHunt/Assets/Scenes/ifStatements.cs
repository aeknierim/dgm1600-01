using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour
{
	public float porridgeTemperature = 125.0f;
	public float hotLimitTemperature = 105.0f;
	public float coldLimitTemperature = 85.0f;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		porridgeTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest ()
	{
		if (porridgeTemperature > hotLimitTemperature)
		{
			print ("Porridge is too hot.");
		}

		else if(porridgeTemperature < coldLimitTemperature)
		{
			print ("Porridge is too cold.");
		}

		else
		{
			print ("Porridge is just right.");
		}
	}
}