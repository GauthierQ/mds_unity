using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Tracker : MonoBehaviour {

	public Transform target;
	public Vector2 offset;
	public float trackingDistance = 1f;
	public float stiffness = 0.05f;

	void Update () {
		if (target == null) return;

		Vector3 targetPos = new Vector3 (
			(target.position.x + offset.x),
			(target.position.y + offset.y),
			this.transform.position.z
		);

		if (stiffness == 1) {
			this.transform.position = targetPos;
			return;
		}

		Vector3 moveOffset = Vector3.zero;

			if (Vector2.Distance (target.position, this.transform.position) > trackingDistance) {
				moveOffset = (targetPos - new Vector3(this.transform.position.x, this.transform.position.y, 0)) * stiffness;
		}

		this.transform.position += new Vector3(moveOffset.x, moveOffset.y, 0);
	}
}