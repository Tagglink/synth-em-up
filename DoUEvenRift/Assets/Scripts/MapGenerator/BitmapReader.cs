using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitmapReader : MonoBehaviour {
	public Texture2D tex;

	private Color[,] pixels;

	void Start () {
		if (tex != null){
			pixels = new Color[tex.width, tex.height];

			Color[] pixelTemp;
			pixelTemp = tex.GetPixels();

			for (int y = 0; y < tex.height; y++) {
				for (int x = 0; x < tex.width; x++) {
					pixels[x,y] = pixelTemp[x*(y * tex.width)];
					Debug.Log(x+(y * tex.width));
				}
			}
		}
	}

	void Update () {
		
	}
}
