using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using System.IO;
namespace Battlaria
{
	public class Map
	{
		public static int maxUpdateTile = 37500000;
		public static int numUpdateTile = 37500000;
		public static short[] updateTileX = new short[Map.maxUpdateTile];
		public static short[] updateTileY = new short[Map.maxUpdateTile];
