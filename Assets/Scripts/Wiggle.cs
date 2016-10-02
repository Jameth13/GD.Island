using UnityEngine;
using System.Collections;

public class Wiggle : MonoBehaviour {
	
	public int speed = 100;
	public float range = 0.01f;
	private float x = 0f;
	private float y = 0f;
	private float z = 0f;
	private int xCount = 0;
	private int yCount = 33;
	private int zCount = 66;
	private Vector3 vec = new Vector3(0f,0f,0f);

	void Start () {

	}

	void Update () {

		xCount += 1;
		if (xCount % 50 == 0) x = -x;
		if (xCount % 100 == 0) x = (Random.value - 0.5f) * range;
		yCount += 1;
		if (yCount % 50 == 0) y = -y;
		if (yCount % 100 == 0) y = (Random.value - 0.5f) * range;
		zCount += 1;
		if (zCount % 50 == 0) z = -z;
		if (zCount % 100 == 0) z = (Random.value - 0.5f) * range;

		vec.Set (x, y, z);
		transform.Translate(vec);

	}
}
