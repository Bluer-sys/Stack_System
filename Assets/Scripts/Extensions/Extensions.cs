namespace Extensions
{
	using UnityEngine;

	public static class Extensions
	{
		public static Vector3 x0y(this Vector2 v)	=> new Vector3( v.x, 0, v.y );
	}
}