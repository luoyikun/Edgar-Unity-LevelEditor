﻿namespace Assets.Scripts.Utils
{
	using System.Collections.Generic;
	using GeneralAlgorithms.DataStructures.Common;
	using UnityEngine;

	public static class Extensions
	{
		public static IntVector2 ToCustomIntVector2(this Vector2Int vector)
		{
			return new IntVector2(vector.x, vector.y);
		}

		public static IntVector2 ToCustomIntVector2(this Vector3Int vector)
		{
			return new IntVector2(vector.x, vector.y);
		}

		public static Vector3Int ToUnityIntVector3(this IntVector2 vector)
		{
			return new Vector3Int(vector.X, vector.Y, 0);
		}

		// TODO: not nice
		public static Vector3Int RotateAroundCenter(this Vector3Int vector, int degrees)
		{
			return vector.ToCustomIntVector2().RotateAroundCenter(degrees).ToUnityIntVector3();
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer = null)
		{
			return new HashSet<T>(source, comparer);
		}
	}
}