﻿using System;
using UnityEditor;
using UnityEngine;

public class Connection
{
	public Node inPoint;
	public Node outPoint;
	public Action<Connection> OnClickRemoveConnection;

	public Connection(Node inPoint, Node outPoint, Action<Connection> OnClickRemoveConnection)
	{
		this.inPoint = inPoint;
		this.outPoint = outPoint;
		this.OnClickRemoveConnection = OnClickRemoveConnection;
	}

	public void Draw()
	{
		//Handles.DrawBezier(
		//	inPoint.rect.center,
		//	outPoint.rect.center,
		//	inPoint.rect.center + Vector2.left * 50f,
		//	outPoint.rect.center - Vector2.left * 50f,
		//	Color.white,
		//	null,
		//	2f
		//);

		Handles.DrawLine(inPoint.rect.center, outPoint.rect.center);

		if (Handles.Button((inPoint.rect.center + outPoint.rect.center) * 0.5f, Quaternion.identity, 4, 8, Handles.RectangleCap))
		{
			if (OnClickRemoveConnection != null)
			{
				OnClickRemoveConnection(this);
			}
		}
	}
}