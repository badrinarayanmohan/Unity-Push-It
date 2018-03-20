using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickupTest : MonoBehaviour {
	public Text YcountScore;
	public Text BcountScore;
	public TextMeshProUGUI winText;
	private int Ycount=0;
	private int Bcount=0;

	void Start ()
	{		
		SetYCountScore (); 
		SetBCountScore ();
		winText.text = "";
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag =="Yellow Ball")
		{
			Ycount = Ycount + 1;
			SetYCountScore ();  
		}

		if (other.gameObject.tag =="Blue Ball")
		{
			Bcount = Bcount + 1;
			SetBCountScore ();  
		}

	}
	void SetYCountScore ()
	{
		YcountScore.text = "" + Ycount.ToString ();
		if(Ycount == 5)
		{
			winText.text = "Yellow Team Wins!";
		}

	}
	void SetBCountScore ()
	{
		BcountScore.text = "" + Bcount.ToString ();
		if(Bcount == 5)
		{
			winText.text = "Blue Team Wins!";
		}
	}

}
