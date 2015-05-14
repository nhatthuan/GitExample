using UnityEngine;
using UnityEditor;
using System.Collections;
 
public class SetPosToZero : ScriptableObject {
			
	[MenuItem ("Window/local position to 0,0,0 %w")]
	static void MenuSetPosToZero() {
		foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {t.localPosition = Vector3.zero;}
	}
	
}
