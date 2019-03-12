﻿using UnityEngine;
using System.Collections;

public class MapMovementController : MonoBehaviour {

	public Map map;
	public Vector2 tileSize;
	public int currentTile;

	private int tmpIndex;
	private int tmpX;
	private int tmpY;

	public void MoveTo(int index){

		currentTile = index;

		PosUtil.CalculatePos (index, map.columns, out tmpX, out tmpY);

		tmpX *= (int)tileSize.x;
		tmpY *= -(int)tileSize.y;

		transform.position = new Vector3 (tmpX, tmpY, 0);
	}

	public void MoveInDirection(Vector2 dir){
		PosUtil.CalculatePos (currentTile, map.columns, out tmpX, out tmpY);

		tmpX += (int)dir.x;
		tmpY += (int)dir.y;

		PosUtil.CalculateIndex (tmpX, tmpY, map.columns, out tmpIndex);

		Debug.Log ("Move to tile " + tmpIndex);
	}
}
