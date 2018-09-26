using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PixelManager : Singleton<PixelManager> {
	public Color[] color = new Color[2];
	public int OperatorIndex;
	public Dropdown dropdown;


	public void SelectOperator(){
		OperatorIndex = dropdown.value;
		print(OperatorIndex);
	}
}
