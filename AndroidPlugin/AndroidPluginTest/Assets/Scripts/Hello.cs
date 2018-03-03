using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.InteropServices;

public class Hello : MonoBehaviour {

	//[DllImport ("myfirstlib-debug")]

	// Use this for initialization
	void Start () {
		AndroidJavaClass jc = new AndroidJavaClass("xyz.peke2.myfirstlibrary.Hello");
		Debug.Log("java say()=>"+jc.CallStatic<string>("say").ToString());
		Debug.Log("Java add()=>"+jc.CallStatic<int>("add", new object[]{3,7}).ToString());

		AndroidJavaClass jparam = new AndroidJavaClass("xyz.peke2.myfirstlib.HelloParam");
		jparam.Set("name", "引数テスト");
		jparam.Set("values", new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

		int total = jc.CallStatic<int>("sum", jparam);
		Debug.Log("total=" + total.ToString());

	}

	
	// Update is called once per frame
	void Update () {
		transform.Rotate(1, 0, 1);
	}
}
