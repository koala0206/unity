using System.Collections;
using System.Collections.Generic;
using UnityEngine;

partial class ButtonClickTest :MonoBehaviour{
	public Button m_btn;
	public Text m_txt;
	void Start(){
		if (m_btn != null) {
			m_btn.onClock.AddListener (() => {
				UnityEngine.Debug.Log ("OnClickButton");
				m_txt.texe = "已经点击";
				m_txt.fontSize = 60;
			});
		}
	}
	void Update(){
	}
}
 