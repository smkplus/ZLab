using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class Pixel : MonoBehaviour,IPointerEnterHandler {
	public int ScreenIndex;
	public int index;
	public bool Allow = true;

private void Awake() {
		ScreenIndex = transform.parent.GetComponent<PixelCalculator>().ScreenIndex;
}
public void OnPointerEnter(PointerEventData eventData)
    { 
		if(!Allow){
			return;
		}
		if(Input.GetKey(KeyCode.Mouse0)){
		GetComponent<Image>().color = PixelManager.Instance.color[ScreenIndex];
		}
		if(Input.GetKey(KeyCode.Mouse0)){
		index++;
		GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();
		}
	 }
}
