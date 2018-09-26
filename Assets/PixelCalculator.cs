using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PixelCalculator : MonoBehaviour {
	public int ScreenIndex;
	public Transform ScreenA,ScreenB,ScreenC;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Calculate () {
		for (int x = 0; x < ScreenA.transform.childCount; x++)
		{
		int pixelA = ScreenA.GetChild(x).GetComponent<Pixel>().index;
		int pixelB = ScreenB.GetChild(x).GetComponent<Pixel>().index;

		int[] Pixels = new int[2]{pixelA,pixelB};
		print(pixelA);
		int pixelC = ScreenC.GetChild(x).GetComponent<Pixel>().index;
		if(pixelA != 0 || pixelB != 0 ){
		int Index = GetIndex(pixelA,pixelB);
		Color color = PixelManager.Instance.color[Index];
		ScreenC.GetChild(x).GetComponent<Pixel>().index = Pixels[Index];
		ScreenC.GetChild(x).GetComponentInChildren<TextMeshProUGUI>().text = Pixels[Index].ToString();
		ScreenC.GetChild(x).GetComponent<Image>().color = color;
		}
		}
		}

		int GetIndex(int pixelA,int pixelB){
			switch (PixelManager.Instance.OperatorIndex)
			{
				case 0 : return (Mathf.Max(pixelA,pixelB)) == pixelB ? 1 : 0; break;
				case 1 : return (pixelA < pixelB) ? 1 : 0; break;
				case 2 : return (pixelA > pixelB) ? 1 : 0; break;
				case 3 : return (pixelA <= pixelB) ? 1 : 0; break;
				case 4 : return (pixelA >= pixelB) ? 0 : 1; break;
				case 5 : return (pixelA == pixelB) ? 1 : 0; break;
				case 6 : return (pixelA != pixelB) ? 1 : 0; break;
				case 7 : return (Mathf.Max(pixelA,pixelB)) == pixelB ? 1 : 0; break;
			}
			return 0;
		}


	}
