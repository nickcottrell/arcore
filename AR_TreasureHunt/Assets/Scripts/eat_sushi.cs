using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat_sushi : MonoBehaviour {

	public GameObject edibleObject;

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject == edibleObject)
		{
			Destroy(edibleObject);
		}
	}
}
