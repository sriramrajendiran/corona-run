using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameToTitle : MonoBehaviour {

	public Text title;


	void OnMouseEnter()
	{
		switch(name)
		{
		case "Pac-Man":
			title.color = Color.yellow;
			title.text = "Hooman";
			break;

		case "Blinky":
			title.color = Color.red;
			title.text = "Corona Z";
			break;

		case "Pinky":
			title.color = new Color(254f/255f, 152f/255f, 203f/255f);
			title.text = "Corona X";
			break;

		case "Inky":
			title.color = Color.cyan;
			title.text = "Corona Y";
			break;

		case "Clyde":
			title.color = new Color(254f/255f, 203f/255f, 51f/255f);
			title.text = "Corona V";
			break;
		}
	}

	void OnMouseExit()
	{
		title.text = "Pac-Man Clone";
		title.text = "CORONA-RUN";
		title.color = Color.white;
	}
}
