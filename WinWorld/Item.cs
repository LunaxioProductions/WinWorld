using Microsoft.Xna.Framework;
using System;
namespace Battlaria
{
	public class Item
	{
public static int potionDelay = 3600;
		public static int[] headType = new int[112];
		public static int[] bodyType = new int[75];
		public static int[] legType = new int[64];
		public bool flame;
		public bool mech;
		public bool wet;
		public bool honeyWet;
		public byte wetCount;
		public bool lavaWet;
		public Vector2 position;
		public Vector2 velocity;
		public int width;
		public int height;
		public bool active;
		public int noGrabDelay;
		public bool beingGrabbed;
		public int spawnTime;
		public int tileWand = -1;
		public bool wornArmor;
		public byte dye;
		public byte paint;
		public int ownIgnore = -1;
		public int ownTime;
		public int keepTime;
		public int type;
		public string name;
		public int holdStyle;
		public int useStyle;
		public bool channel;
		public bool accessory;
		public int useAnimation;
		public int useTime;
		public int stack;
		public int maxStack;
		public int pick;
		public int axe;
		public int hammer;
		public int tileBoost;
		public int createTile = -1;
		public int createWall = -1;
		public int placeStyle;
		public int damage;
		public float knockBack;
		public int healLife;
		public int healMana;
		public bool potion;
		public bool consumable;
		public bool autoReuse;
		public bool useTurn;
		public Color color;
		public int alpha;
		public float scale = 1f;
		public int useSound;
		public int defense;
		public int headSlot = -1;
		public int bodySlot = -1;
		public int legSlot = -1;
		public string toolTip;
		public string toolTip2;
		public int owner = 255;
		public int rare;
		public int shoot;
		public float shootSpeed;
		public int ammo;
		public bool notAmmo;
		public int useAmmo;
		public int lifeRegen;
		public int manaIncrease;
		public bool buyOnce;
		public int mana;
		public bool noUseGraphic;
		public bool noMelee;
		public int release;
		public int value;
		public bool buy;
		public bool social;
		public bool vanity;
		public bool material;
		public bool noWet;
		public int buffType;
		public int buffTime;
		public int netID;
		public int crit;
		public byte prefix;
		public bool melee;
		public bool magic;
		public bool ranged;
		public bool summon;
		public bool rogue;
		public bool aura;
		public bool classless;
		public int reuseDelay;
		public bool Prefix(int pre)
		{
			if (pre == 0 || this.type == 0)
			{
				return false;
			}
			int num = pre;
			float num2 = 1f;
			float num3 = 1f;
			float num4 = 1f;
			float num5 = 1f;
			float num6 = 1f;
			float num7 = 1f;
			int num8 = 0;
			bool flag = true;
			while (flag)
			{
				num2 = 1f;
				num3 = 1f;
				num4 = 1f;
				num5 = 1f;
				num6 = 1f;
				num7 = 1f;
				num8 = 0;
				flag = false;
				if (num == -1 && Main.rand.Next(4) == 0)
				{
					num = 0;
				}
				if (pre < -1)
				{
					num = -1;
				}
				if (num == -1 || num == -2 || num == -3)
				{
					if (this.type == 1 || this.type == 4 || this.type == 6 || this.type == 7 || this.type == 10 || this.type == 24 || this.type == 45 || this.type == 46 || this.type == 103 || this.type == 104 || this.type == 121 || this.type == 122 || this.type == 155 || this.type == 190 || this.type == 196 || this.type == 198 || this.type == 199 || this.type == 200 || this.type == 201 || this.type == 202 || this.type == 203 || this.type == 204 || this.type == 213 || this.type == 217 || this.type == 273 || this.type == 367 || this.type == 368 || this.type == 426 || this.type == 482 || this.type == 483 || this.type == 484 || this.type == 653 || this.type == 654 || this.type == 656 || this.type == 657 || this.type == 659 || this.type == 660 || this.type == 671 || this.type == 672 || this.type == 674 || this.type == 675 || this.type == 676 || this.type == 723 || this.type == 724 || this.type == 757 || this.type == 776 || this.type == 777 || this.type == 778 || this.type == 787 || this.type == 795 || this.type == 797 || this.type == 798 || this.type == 799 || this.type == 881 || this.type == 882 || this.type == 921 || this.type == 922 || this.type == 989 || this.type == 990 || this.type == 991 || this.type == 992 || this.type == 993 || this.type == 1123 || this.type == 1166 || this.type == 1185 || this.type == 1188 || this.type == 1192 || this.type == 1195 || this.type == 1199 || this.type == 1202 || this.type == 1222 || this.type == 1223 || this.type == 1224 || this.type == 1226 || this.type == 1227 || this.type == 1230 || this.type == 1233 || this.type == 1234 || this.type == 1294 || this.type == 1304 || this.type == 1305 || this.type == 1306 || this.type == 1320 || this.type == 1327 || this.type == 1506 || this.type == 1507)
					{
						int num9 = Main.rand.Next(40);
						if (num9 == 0)
						{
							num = 1;
						}
						if (num9 == 1)
						{
							num = 2;
						}
						if (num9 == 2)
						{
							num = 3;
						}
						if (num9 == 3)
						{
							num = 4;
						}
						if (num9 == 4)
						{
							num = 5;
						}
						if (num9 == 5)
						{
							num = 6;
						}
						if (num9 == 6)
						{
							num = 7;
						}
						if (num9 == 7)
						{
							num = 8;
						}
						if (num9 == 8)
						{
							num = 9;
						}
						if (num9 == 9)
						{
							num = 10;
						}
						if (num9 == 10)
						{
							num = 11;
						}
						if (num9 == 11)
						{
							num = 12;
						}
						if (num9 == 12)
						{
							num = 13;
						}
						if (num9 == 13)
						{
							num = 14;
						}
						if (num9 == 14)
						{
							num = 15;
						}
						if (num9 == 15)
						{
							num = 36;
						}
						if (num9 == 16)
						{
							num = 37;
						}
						if (num9 == 17)
						{
							num = 38;
						}
						if (num9 == 18)
						{
							num = 53;
						}
						if (num9 == 19)
						{
							num = 54;
						}
						if (num9 == 20)
						{
							num = 55;
						}
						if (num9 == 21)
						{
							num = 39;
						}
						if (num9 == 22)
						{
							num = 40;
						}
						if (num9 == 23)
						{
							num = 56;
						}
						if (num9 == 24)
						{
							num = 41;
						}
						if (num9 == 25)
						{
							num = 57;
						}
						if (num9 == 26)
						{
							num = 42;
						}
						if (num9 == 27)
						{
							num = 43;
						}
						if (num9 == 28)
						{
							num = 44;
						}
						if (num9 == 29)
						{
							num = 45;
						}
						if (num9 == 30)
						{
							num = 46;
						}
						if (num9 == 31)
						{
							num = 47;
						}
						if (num9 == 32)
						{
							num = 48;
						}
						if (num9 == 33)
						{
							num = 49;
						}
						if (num9 == 34)
						{
							num = 50;
						}
						if (num9 == 35)
						{
							num = 51;
						}
						if (num9 == 36)
						{
							num = 59;
						}
						if (num9 == 37)
						{
							num = 60;
						}
						if (num9 == 38)
						{
							num = 61;
						}
						if (num9 == 39)
						{
							num = 81;
						}
					}
					else
					{
						if (this.type == 162 || this.type == 160 || this.type == 163 || this.type == 220 || this.type == 274 || this.type == 277 || this.type == 280 || this.type == 383 || this.type == 384 || this.type == 385 || this.type == 386 || this.type == 387 || this.type == 388 || this.type == 389 || this.type == 390 || this.type == 406 || this.type == 537 || this.type == 550 || this.type == 579 || this.type == 756 || this.type == 759 || this.type == 801 || this.type == 802 || this.type == 1186 || this.type == 1189 || this.type == 1190 || this.type == 1193 || this.type == 1196 || this.type == 1197 || this.type == 1200 || this.type == 1203 || this.type == 1204 || this.type == 1228 || this.type == 1231 || this.type == 1232 || this.type == 1259 || this.type == 1262 || this.type == 1297 || this.type == 1314 || this.type == 1325)
						{
							int num10 = Main.rand.Next(14);
							if (num10 == 0)
							{
								num = 36;
							}
							if (num10 == 1)
							{
								num = 37;
							}
							if (num10 == 2)
							{
								num = 38;
							}
							if (num10 == 3)
							{
								num = 53;
							}
							if (num10 == 4)
							{
								num = 54;
							}
							if (num10 == 5)
							{
								num = 55;
							}
							if (num10 == 6)
							{
								num = 39;
							}
							if (num10 == 7)
							{
								num = 40;
							}
							if (num10 == 8)
							{
								num = 56;
							}
							if (num10 == 9)
							{
								num = 41;
							}
							if (num10 == 10)
							{
								num = 57;
							}
							if (num10 == 11)
							{
								num = 59;
							}
							if (num10 == 12)
							{
								num = 60;
							}
							if (num10 == 13)
							{
								num = 61;
							}
						}
						else
						{
							if (this.type == 39 || this.type == 44 || this.type == 95 || this.type == 96 || this.type == 98 || this.type == 99 || this.type == 120 || this.type == 164 || this.type == 197 || this.type == 219 || this.type == 266 || this.type == 281 || this.type == 434 || this.type == 435 || this.type == 436 || this.type == 481 || this.type == 506 || this.type == 533 || this.type == 534 || this.type == 578 || this.type == 655 || this.type == 658 || this.type == 661 || this.type == 679 || this.type == 682 || this.type == 725 || this.type == 758 || this.type == 759 || this.type == 760 || this.type == 796 || this.type == 800 || this.type == 905 || this.type == 964 || this.type == 986 || this.type == 1156 || this.type == 1187 || this.type == 1194 || this.type == 1201 || this.type == 1229 || this.type == 1254 || this.type == 1255 || this.type == 1258 || this.type == 1265 || this.type == 1319 || this.type == 1553)
							{
								int num11 = Main.rand.Next(36);
								if (num11 == 0)
								{
									num = 16;
								}
								if (num11 == 1)
								{
									num = 17;
								}
								if (num11 == 2)
								{
									num = 18;
								}
								if (num11 == 3)
								{
									num = 19;
								}
								if (num11 == 4)
								{
									num = 20;
								}
								if (num11 == 5)
								{
									num = 21;
								}
								if (num11 == 6)
								{
									num = 22;
								}
								if (num11 == 7)
								{
									num = 23;
								}
								if (num11 == 8)
								{
									num = 24;
								}
								if (num11 == 9)
								{
									num = 25;
								}
								if (num11 == 10)
								{
									num = 58;
								}
								if (num11 == 11)
								{
									num = 36;
								}
								if (num11 == 12)
								{
									num = 37;
								}
								if (num11 == 13)
								{
									num = 38;
								}
								if (num11 == 14)
								{
									num = 53;
								}
								if (num11 == 15)
								{
									num = 54;
								}
								if (num11 == 16)
								{
									num = 55;
								}
								if (num11 == 17)
								{
									num = 39;
								}
								if (num11 == 18)
								{
									num = 40;
								}
								if (num11 == 19)
								{
									num = 56;
								}
								if (num11 == 20)
								{
									num = 41;
								}
								if (num11 == 21)
								{
									num = 57;
								}
								if (num11 == 22)
								{
									num = 42;
								}
								if (num11 == 23)
								{
									num = 43;
								}
								if (num11 == 24)
								{
									num = 44;
								}
								if (num11 == 25)
								{
									num = 45;
								}
								if (num11 == 26)
								{
									num = 46;
								}
								if (num11 == 27)
								{
									num = 47;
								}
								if (num11 == 28)
								{
									num = 48;
								}
								if (num11 == 29)
								{
									num = 49;
								}
								if (num11 == 30)
								{
									num = 50;
								}
								if (num11 == 31)
								{
									num = 51;
								}
								if (num11 == 32)
								{
									num = 59;
								}
								if (num11 == 33)
								{
									num = 60;
								}
								if (num11 == 34)
								{
									num = 61;
								}
								if (num11 == 35)
								{
									num = 82;
								}
							}
							else
							{
								if (this.type == 64 || this.type == 65 || this.type == 112 || this.type == 113 || this.type == 127 || this.type == 157 || this.type == 165 || this.type == 218 || this.type == 272 || this.type == 494 || this.type == 495 || this.type == 496 || this.type == 514 || this.type == 517 || this.type == 518 || this.type == 519 || this.type == 683 || this.type == 726 || this.type == 739 || this.type == 740 || this.type == 741 || this.type == 742 || this.type == 743 || this.type == 744 || this.type == 788 || this.type == 1121 || this.type == 1155 || this.type == 1157 || this.type == 1178 || this.type == 1244 || this.type == 1256 || this.type == 1260 || this.type == 1264 || this.type == 1266 || this.type == 1295 || this.type == 1296 || this.type == 1308 || this.type == 1309 || this.type == 1313 || this.type == 1336 || this.type == 1444 || this.type == 1445 || this.type == 1446 || this.type == 1572)
								{
									int num12 = Main.rand.Next(36);
									if (num12 == 0)
									{
										num = 26;
									}
									if (num12 == 1)
									{
										num = 27;
									}
									if (num12 == 2)
									{
										num = 28;
									}
									if (num12 == 3)
									{
										num = 29;
									}
									if (num12 == 4)
									{
										num = 30;
									}
									if (num12 == 5)
									{
										num = 31;
									}
									if (num12 == 6)
									{
										num = 32;
									}
									if (num12 == 7)
									{
										num = 33;
									}
									if (num12 == 8)
									{
										num = 34;
									}
									if (num12 == 9)
									{
										num = 35;
									}
									if (num12 == 10)
									{
										num = 52;
									}
									if (num12 == 11)
									{
										num = 36;
									}
									if (num12 == 12)
									{
										num = 37;
									}
									if (num12 == 13)
									{
										num = 38;
									}
									if (num12 == 14)
									{
										num = 53;
									}
									if (num12 == 15)
									{
										num = 54;
									}
									if (num12 == 16)
									{
										num = 55;
									}
									if (num12 == 17)
									{
										num = 39;
									}
									if (num12 == 18)
									{
										num = 40;
									}
									if (num12 == 19)
									{
										num = 56;
									}
									if (num12 == 20)
									{
										num = 41;
									}
									if (num12 == 21)
									{
										num = 57;
									}
									if (num12 == 22)
									{
										num = 42;
									}
									if (num12 == 23)
									{
										num = 43;
									}
									if (num12 == 24)
									{
										num = 44;
									}
									if (num12 == 25)
									{
										num = 45;
									}
									if (num12 == 26)
									{
										num = 46;
									}
									if (num12 == 27)
									{
										num = 47;
									}
									if (num12 == 28)
									{
										num = 48;
									}
									if (num12 == 29)
									{
										num = 49;
									}
									if (num12 == 30)
									{
										num = 50;
									}
									if (num12 == 31)
									{
										num = 51;
									}
									if (num12 == 32)
									{
										num = 59;
									}
									if (num12 == 33)
									{
										num = 60;
									}
									if (num12 == 34)
									{
										num = 61;
									}
									if (num12 == 35)
									{
										num = 83;
									}
								}
								else
								{
									if (this.type == 55 || this.type == 119 || this.type == 191 || this.type == 284 || this.type == 670 || this.type == 1122 || this.type == 1513 || this.type == 1569 || this.type == 1571)
									{
										int num13 = Main.rand.Next(14);
										if (num13 == 0)
										{
											num = 36;
										}
										if (num13 == 1)
										{
											num = 37;
										}
										if (num13 == 2)
										{
											num = 38;
										}
										if (num13 == 3)
										{
											num = 53;
										}
										if (num13 == 4)
										{
											num = 54;
										}
										if (num13 == 5)
										{
											num = 55;
										}
										if (num13 == 6)
										{
											num = 39;
										}
										if (num13 == 7)
										{
											num = 40;
										}
										if (num13 == 8)
										{
											num = 56;
										}
										if (num13 == 9)
										{
											num = 41;
										}
										if (num13 == 10)
										{
											num = 57;
										}
										if (num13 == 11)
										{
											num = 59;
										}
										if (num13 == 12)
										{
											num = 60;
										}
										if (num13 == 13)
										{
											num = 61;
										}
									}
									else
									{
										if (!this.accessory || this.type == 267 || this.type == 562 || this.type == 563 || this.type == 564 || this.type == 565 || this.type == 566 || this.type == 567 || this.type == 568 || this.type == 569 || this.type == 570 || this.type == 571 || this.type == 572 || this.type == 573 || this.type == 574 || this.type == 576 || this.type == 1307)
										{
											return false;
										}
										num = Main.rand.Next(62, 81);
									}
								}
							}
						}
					}
				}
				if (pre == -3)
				{
					return true;
				}
				if (pre == -1 && (num == 7 || num == 8 || num == 9 || num == 10 || num == 11 || num == 22 || num == 23 || num == 24 || num == 29 || num == 30 || num == 31 || num == 39 || num == 40 || num == 56 || num == 41 || num == 47 || num == 48 || num == 49) && Main.rand.Next(3) != 0)
				{
					num = 0;
				}
				if (num == 1)
				{
					num5 = 1.12f;
				}
				else
				{
					if (num == 2)
					{
						num5 = 1.18f;
					}
					else
					{
						if (num == 3)
						{
							num2 = 1.05f;
							num8 = 2;
							num5 = 1.05f;
						}
						else
						{
							if (num == 4)
							{
								num2 = 1.1f;
								num5 = 1.1f;
								num3 = 1.1f;
							}
							else
							{
								if (num == 5)
								{
									num2 = 1.15f;
								}
								else
								{
									if (num == 6)
									{
										num2 = 1.1f;
									}
									else
									{
										if (num == 81)
										{
											num3 = 1.15f;
											num2 = 1.15f;
											num8 = 5;
											num4 = 0.9f;
											num5 = 1.1f;
										}
										else
										{
											if (num == 7)
											{
												num5 = 0.82f;
											}
											else
											{
												if (num == 8)
												{
													num3 = 0.85f;
													num2 = 0.85f;
													num5 = 0.87f;
												}
												else
												{
													if (num == 9)
													{
														num5 = 0.9f;
													}
													else
													{
														if (num == 10)
														{
															num2 = 0.85f;
														}
														else
														{
															if (num == 11)
															{
																num4 = 1.1f;
																num3 = 0.9f;
																num5 = 0.9f;
															}
															else
															{
																if (num == 12)
																{
																	num3 = 1.1f;
																	num2 = 1.05f;
																	num5 = 1.1f;
																	num4 = 1.15f;
																}
																else
																{
																	if (num == 13)
																	{
																		num3 = 0.8f;
																		num2 = 0.9f;
																		num5 = 1.1f;
																	}
																	else
																	{
																		if (num == 14)
																		{
																			num3 = 1.15f;
																			num4 = 1.1f;
																		}
																		else
																		{
																			if (num == 15)
																			{
																				num3 = 0.9f;
																				num4 = 0.85f;
																			}
																			else
																			{
																				if (num == 16)
																				{
																					num2 = 1.1f;
																					num8 = 3;
																				}
																				else
																				{
																					if (num == 17)
																					{
																						num4 = 0.85f;
																						num6 = 1.1f;
																					}
																					else
																					{
																						if (num == 18)
																						{
																							num4 = 0.9f;
																							num6 = 1.15f;
																						}
																						else
																						{
																							if (num == 19)
																							{
																								num3 = 1.15f;
																								num6 = 1.05f;
																							}
																							else
																							{
																								if (num == 20)
																								{
																									num3 = 1.05f;
																									num6 = 1.05f;
																									num2 = 1.1f;
																									num4 = 0.95f;
																									num8 = 2;
																								}
																								else
																								{
																									if (num == 21)
																									{
																										num3 = 1.15f;
																										num2 = 1.1f;
																									}
																									else
																									{
																										if (num == 82)
																										{
																											num3 = 1.15f;
																											num2 = 1.15f;
																											num8 = 5;
																											num4 = 0.9f;
																											num6 = 1.1f;
																										}
																										else
																										{
																											if (num == 22)
																											{
																												num3 = 0.9f;
																												num6 = 0.9f;
																												num2 = 0.85f;
																											}
																											else
																											{
																												if (num == 23)
																												{
																													num4 = 1.15f;
																													num6 = 0.9f;
																												}
																												else
																												{
																													if (num == 24)
																													{
																														num4 = 1.1f;
																														num3 = 0.8f;
																													}
																													else
																													{
																														if (num == 25)
																														{
																															num4 = 1.1f;
																															num2 = 1.15f;
																															num8 = 1;
																														}
																														else
																														{
																															if (num == 58)
																															{
																																num4 = 0.85f;
																																num2 = 0.85f;
																															}
																															else
																															{
																																if (num == 26)
																																{
																																	num7 = 0.85f;
																																	num2 = 1.1f;
																																}
																																else
																																{
																																	if (num == 27)
																																	{
																																		num7 = 0.85f;
																																	}
																																	else
																																	{
																																		if (num == 28)
																																		{
																																			num7 = 0.85f;
																																			num2 = 1.15f;
																																			num3 = 1.05f;
																																		}
																																		else
																																		{
																																			if (num == 83)
																																			{
																																				num3 = 1.15f;
																																				num2 = 1.15f;
																																				num8 = 5;
																																				num4 = 0.9f;
																																				num7 = 0.9f;
																																			}
																																			else
																																			{
																																				if (num == 29)
																																				{
																																					num7 = 1.1f;
																																				}
																																				else
																																				{
																																					if (num == 30)
																																					{
																																						num7 = 1.2f;
																																						num2 = 0.9f;
																																					}
																																					else
																																					{
																																						if (num == 31)
																																						{
																																							num3 = 0.9f;
																																							num2 = 0.9f;
																																						}
																																						else
																																						{
																																							if (num == 32)
																																							{
																																								num7 = 1.15f;
																																								num2 = 1.1f;
																																							}
																																							else
																																							{
																																								if (num == 33)
																																								{
																																									num7 = 1.1f;
																																									num3 = 1.1f;
																																									num4 = 0.9f;
																																								}
																																								else
																																								{
																																									if (num == 34)
																																									{
																																										num7 = 0.9f;
																																										num3 = 1.1f;
																																										num4 = 1.1f;
																																										num2 = 1.1f;
																																									}
																																									else
																																									{
																																										if (num == 35)
																																										{
																																											num7 = 1.2f;
																																											num2 = 1.15f;
																																											num3 = 1.15f;
																																										}
																																										else
																																										{
																																											if (num == 52)
																																											{
																																												num7 = 0.9f;
																																												num2 = 0.9f;
																																												num4 = 0.9f;
																																											}
																																											else
																																											{
																																												if (num == 36)
																																												{
																																													num8 = 3;
																																												}
																																												else
																																												{
																																													if (num == 37)
																																													{
																																														num2 = 1.1f;
																																														num8 = 3;
																																														num3 = 1.1f;
																																													}
																																													else
																																													{
																																														if (num == 38)
																																														{
																																															num3 = 1.15f;
																																														}
																																														else
																																														{
																																															if (num == 53)
																																															{
																																																num2 = 1.1f;
																																															}
																																															else
																																															{
																																																if (num == 54)
																																																{
																																																	num3 = 1.15f;
																																																}
																																																else
																																																{
																																																	if (num == 55)
																																																	{
																																																		num3 = 1.15f;
																																																		num2 = 1.05f;
																																																	}
																																																	else
																																																	{
																																																		if (num == 59)
																																																		{
																																																			num3 = 1.15f;
																																																			num2 = 1.15f;
																																																			num8 = 5;
																																																		}
																																																		else
																																																		{
																																																			if (num == 60)
																																																			{
																																																				num2 = 1.15f;
																																																				num8 = 5;
																																																			}
																																																			else
																																																			{
																																																				if (num == 61)
																																																				{
																																																					num8 = 5;
																																																				}
																																																				else
																																																				{
																																																					if (num == 39)
																																																					{
																																																						num2 = 0.7f;
																																																						num3 = 0.8f;
																																																					}
																																																					else
																																																					{
																																																						if (num == 40)
																																																						{
																																																							num2 = 0.85f;
																																																						}
																																																						else
																																																						{
																																																							if (num == 56)
																																																							{
																																																								num3 = 0.8f;
																																																							}
																																																							else
																																																							{
																																																								if (num == 41)
																																																								{
																																																									num3 = 0.85f;
																																																									num2 = 0.9f;
																																																								}
																																																								else
																																																								{
																																																									if (num == 57)
																																																									{
																																																										num3 = 0.9f;
																																																										num2 = 1.18f;
																																																									}
																																																									else
																																																									{
																																																										if (num == 42)
																																																										{
																																																											num4 = 0.9f;
																																																										}
																																																										else
																																																										{
																																																											if (num == 43)
																																																											{
																																																												num2 = 1.1f;
																																																												num4 = 0.9f;
																																																											}
																																																											else
																																																											{
																																																												if (num == 44)
																																																												{
																																																													num4 = 0.9f;
																																																													num8 = 3;
																																																												}
																																																												else
																																																												{
																																																													if (num == 45)
																																																													{
																																																														num4 = 0.95f;
																																																													}
																																																													else
																																																													{
																																																														if (num == 46)
																																																														{
																																																															num8 = 3;
																																																															num4 = 0.94f;
																																																															num2 = 1.07f;
																																																														}
																																																														else
																																																														{
																																																															if (num == 47)
																																																															{
																																																																num4 = 1.15f;
																																																															}
																																																															else
																																																															{
																																																																if (num == 48)
																																																																{
																																																																	num4 = 1.2f;
																																																																}
																																																																else
																																																																{
																																																																	if (num == 49)
																																																																	{
																																																																		num4 = 1.08f;
																																																																	}
																																																																	else
																																																																	{
																																																																		if (num == 50)
																																																																		{
																																																																			num2 = 0.8f;
																																																																			num4 = 1.15f;
																																																																		}
																																																																		else
																																																																		{
																																																																			if (num == 51)
																																																																			{
																																																																				num3 = 0.9f;
																																																																				num4 = 0.9f;
																																																																				num2 = 1.05f;
																																																																				num8 = 2;
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if (num2 != 1f && Math.Round((double)((float)this.damage * num2)) == (double)this.damage)
				{
					flag = true;
					num = -1;
				}
				if (num4 != 1f && Math.Round((double)((float)this.useAnimation * num4)) == (double)this.useAnimation)
				{
					flag = true;
					num = -1;
				}
				if (num7 != 1f && Math.Round((double)((float)this.mana * num7)) == (double)this.mana)
				{
					flag = true;
					num = -1;
				}
				if (num3 != 1f && this.knockBack == 0f)
				{
					flag = true;
					num = -1;
				}
				if (pre == -2 && num == 0)
				{
					num = -1;
					flag = true;
				}
			}
			this.damage = (int)Math.Round((double)((float)this.damage * num2));
			this.useAnimation = (int)Math.Round((double)((float)this.useAnimation * num4));
			this.useTime = (int)Math.Round((double)((float)this.useTime * num4));
			this.reuseDelay = (int)Math.Round((double)((float)this.reuseDelay * num4));
			this.mana = (int)Math.Round((double)((float)this.mana * num7));
			this.knockBack *= num3;
			this.scale *= num5;
			this.shootSpeed *= num6;
			this.crit += num8;
			float num14 = 1f * num2 * (2f - num4) * (2f - num7) * num5 * num3 * num6 * (1f + (float)this.crit * 0.02f);
			if (num == 62 || num == 69 || num == 73 || num == 77)
			{
				num14 *= 1.05f;
			}
			if (num == 63 || num == 70 || num == 74 || num == 78 || num == 67)
			{
				num14 *= 1.1f;
			}
			if (num == 64 || num == 71 || num == 75 || num == 79 || num == 66)
			{
				num14 *= 1.15f;
			}
			if (num == 65 || num == 72 || num == 76 || num == 80 || num == 68)
			{
				num14 *= 1.2f;
			}
			if ((double)num14 >= 1.2)
			{
				this.rare += 2;
			}
			else
			{
				if ((double)num14 >= 1.05)
				{
					this.rare++;
				}
				else
				{
					if ((double)num14 <= 0.8)
					{
						this.rare -= 2;
					}
					else
					{
						if ((double)num14 <= 0.95)
						{
							this.rare--;
						}
					}
				}
			}
			if (this.rare < -1)
			{
				this.rare = -1;
			}
			if (this.rare > 9)
			{
				this.rare = 9;
			}
			num14 *= num14;
			this.value = (int)((float)this.value * num14);
			this.prefix = (byte)num;
			return true;
		}
		public string AffixName()
		{
			string text = "";
			if (Lang.lang <= 1)
			{
				if (this.prefix == 1)
				{
					text = "Large";
				}
				if (this.prefix == 2)
				{
					text = "Massive";
				}
				if (this.prefix == 3)
				{
					text = "Dangerous";
				}
				if (this.prefix == 4)
				{
					text = "Savage";
				}
				if (this.prefix == 5)
				{
					text = "Sharp";
				}
				if (this.prefix == 6)
				{
					text = "Pointy";
				}
				if (this.prefix == 7)
				{
					text = "Tiny";
				}
				if (this.prefix == 8)
				{
					text = "Terrible";
				}
				if (this.prefix == 9)
				{
					text = "Small";
				}
				if (this.prefix == 10)
				{
					text = "Dull";
				}
				if (this.prefix == 11)
				{
					text = "Unhappy";
				}
				if (this.prefix == 12)
				{
					text = "Bulky";
				}
				if (this.prefix == 13)
				{
					text = "Shameful";
				}
				if (this.prefix == 14)
				{
					text = "Heavy";
				}
				if (this.prefix == 15)
				{
					text = "Light";
				}
				if (this.prefix == 16)
				{
					text = "Sighted";
				}
				if (this.prefix == 17)
				{
					text = "Rapid";
				}
				if (this.prefix == 18)
				{
					text = "Hasty";
				}
				if (this.prefix == 19)
				{
					text = "Intimidating";
				}
				if (this.prefix == 20)
				{
					text = "Deadly";
				}
				if (this.prefix == 21)
				{
					text = "Staunch";
				}
				if (this.prefix == 22)
				{
					text = "Awful";
				}
				if (this.prefix == 23)
				{
					text = "Lethargic";
				}
				if (this.prefix == 24)
				{
					text = "Awkward";
				}
				if (this.prefix == 25)
				{
					text = "Powerful";
				}
				if (this.prefix == 58)
				{
					text = "Frenzying";
				}
				if (this.prefix == 26)
				{
					text = "Mystic";
				}
				if (this.prefix == 27)
				{
					text = "Adept";
				}
				if (this.prefix == 28)
				{
					text = "Masterful";
				}
				if (this.prefix == 29)
				{
					text = "Inept";
				}
				if (this.prefix == 30)
				{
					text = "Ignorant";
				}
				if (this.prefix == 31)
				{
					text = "Deranged";
				}
				if (this.prefix == 32)
				{
					text = "Intense";
				}
				if (this.prefix == 33)
				{
					text = "Taboo";
				}
				if (this.prefix == 34)
				{
					text = "Celestial";
				}
				if (this.prefix == 35)
				{
					text = "Furious";
				}
				if (this.prefix == 52)
				{
					text = "Manic";
				}
				if (this.prefix == 36)
				{
					text = "Keen";
				}
				if (this.prefix == 37)
				{
					text = "Superior";
				}
				if (this.prefix == 38)
				{
					text = "Forceful";
				}
				if (this.prefix == 53)
				{
					text = "Hurtful";
				}
				if (this.prefix == 54)
				{
					text = "Strong";
				}
				if (this.prefix == 55)
				{
					text = "Unpleasant";
				}
				if (this.prefix == 39)
				{
					text = "Broken";
				}
				if (this.prefix == 40)
				{
					text = "Damaged";
				}
				if (this.prefix == 56)
				{
					text = "Weak";
				}
				if (this.prefix == 41)
				{
					text = "Shoddy";
				}
				if (this.prefix == 57)
				{
					text = "Ruthless";
				}
				if (this.prefix == 42)
				{
					text = "Quick";
				}
				if (this.prefix == 43)
				{
					text = "Deadly";
				}
				if (this.prefix == 44)
				{
					text = "Agile";
				}
				if (this.prefix == 45)
				{
					text = "Nimble";
				}
				if (this.prefix == 46)
				{
					text = "Murderous";
				}
				if (this.prefix == 47)
				{
					text = "Slow";
				}
				if (this.prefix == 48)
				{
					text = "Sluggish";
				}
				if (this.prefix == 49)
				{
					text = "Lazy";
				}
				if (this.prefix == 50)
				{
					text = "Annoying";
				}
				if (this.prefix == 51)
				{
					text = "Nasty";
				}
				if (this.prefix == 59)
				{
					text = "Godly";
				}
				if (this.prefix == 60)
				{
					text = "Demonic";
				}
				if (this.prefix == 61)
				{
					text = "Zealous";
				}
				if (this.prefix == 62)
				{
					text = "Hard";
				}
				if (this.prefix == 63)
				{
					text = "Guarding";
				}
				if (this.prefix == 64)
				{
					text = "Armored";
				}
				if (this.prefix == 65)
				{
					text = "Warding";
				}
				if (this.prefix == 66)
				{
					text = "Arcane";
				}
				if (this.prefix == 67)
				{
					text = "Precise";
				}
				if (this.prefix == 68)
				{
					text = "Lucky";
				}
				if (this.prefix == 69)
				{
					text = "Jagged";
				}
				if (this.prefix == 70)
				{
					text = "Spiked";
				}
				if (this.prefix == 71)
				{
					text = "Angry";
				}
				if (this.prefix == 72)
				{
					text = "Menacing";
				}
				if (this.prefix == 73)
				{
					text = "Brisk";
				}
				if (this.prefix == 74)
				{
					text = "Fleeting";
				}
				if (this.prefix == 75)
				{
					text = "Hasty";
				}
				if (this.prefix == 76)
				{
					text = "Quick";
				}
				if (this.prefix == 77)
				{
					text = "Wild";
				}
				if (this.prefix == 78)
				{
					text = "Rash";
				}
				if (this.prefix == 79)
				{
					text = "Intrepid";
				}
				if (this.prefix == 80)
				{
					text = "Violent";
				}
				if (this.prefix == 81)
				{
					text = "Legendary";
				}
				if (this.prefix == 82)
				{
					text = "Unreal";
				}
				if (this.prefix == 83)
				{
					text = "Mythical";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					if (this.prefix == 1)
					{
						text = "大";
					}
					if (this.prefix == 2)
					{
						text = "大規模";
					}
					if (this.prefix == 3)
					{
						text = "危険な";
					}
					if (this.prefix == 4)
					{
						text = "野蛮人";
					}
					if (this.prefix == 5)
					{
						text = "シャープ";
					}
					if (this.prefix == 6)
					{
						text = "Spitze";
					}
					if (this.prefix == 7)
					{
						text = "Winzig";
					}
					if (this.prefix == 8)
					{
						text = "Schrecklicher";
					}
					if (this.prefix == 9)
					{
						text = "Klein";
					}
					if (this.prefix == 10)
					{
						text = "Stumpf";
					}
					if (this.prefix == 11)
					{
						text = "Unglücklich";
					}
					if (this.prefix == 12)
					{
						text = "Sperrig";
					}
					if (this.prefix == 13)
					{
						text = "Beschämend";
					}
					if (this.prefix == 14)
					{
						text = "Schwer";
					}
					if (this.prefix == 15)
					{
						text = "Locker";
					}
					if (this.prefix == 16)
					{
						text = "Gesichtet";
					}
					if (this.prefix == 17)
					{
						text = "Schnell";
					}
					if (this.prefix == 18)
					{
						text = "Hastig";
					}
					if (this.prefix == 19)
					{
						text = "Einschüchternd";
					}
					if (this.prefix == 20)
					{
						text = "Tödlich";
					}
					if (this.prefix == 21)
					{
						text = "Stillen";
					}
					if (this.prefix == 22)
					{
						text = "Schrecklich";
					}
					if (this.prefix == 23)
					{
						text = "Lethargisch";
					}
					if (this.prefix == 24)
					{
						text = "Unbeholfen";
					}
					if (this.prefix == 25)
					{
						text = "Mächtig";
					}
					if (this.prefix == 26)
					{
						text = "Mystisch";
					}
					if (this.prefix == 27)
					{
						text = "Geschickt";
					}
					if (this.prefix == 28)
					{
						text = "Meisterhaft";
					}
					if (this.prefix == 29)
					{
						text = "Ungeschickt";
					}
					if (this.prefix == 30)
					{
						text = "Unwissend";
					}
					if (this.prefix == 31)
					{
						text = "Gestört";
					}
					if (this.prefix == 32)
					{
						text = "Intensiv";
					}
					if (this.prefix == 33)
					{
						text = "Tabu";
					}
					if (this.prefix == 34)
					{
						text = "Himmlisch";
					}
					if (this.prefix == 35)
					{
						text = "Wütend";
					}
					if (this.prefix == 36)
					{
						text = "Scharf";
					}
					if (this.prefix == 37)
					{
						text = "Überlegen";
					}
					if (this.prefix == 38)
					{
						text = "Kraftvoll";
					}
					if (this.prefix == 39)
					{
						text = "Gebrochen";
					}
					if (this.prefix == 40)
					{
						text = "Beschädigt";
					}
					if (this.prefix == 41)
					{
						text = "Schäbig";
					}
					if (this.prefix == 42)
					{
						text = "Rasch";
					}
					if (this.prefix == 43)
					{
						text = "Tödlich";
					}
					if (this.prefix == 44)
					{
						text = "Agil";
					}
					if (this.prefix == 45)
					{
						text = "Wendig";
					}
					if (this.prefix == 46)
					{
						text = "Mörderisch";
					}
					if (this.prefix == 47)
					{
						text = "Langsam";
					}
					if (this.prefix == 48)
					{
						text = "Träge";
					}
					if (this.prefix == 49)
					{
						text = "Faul";
					}
					if (this.prefix == 50)
					{
						text = "Lästig";
					}
					if (this.prefix == 51)
					{
						text = "Böse";
					}
					if (this.prefix == 52)
					{
						text = "Manisch";
					}
					if (this.prefix == 53)
					{
						text = "Verletzend";
					}
					if (this.prefix == 54)
					{
						text = "Stark";
					}
					if (this.prefix == 55)
					{
						text = "Unangenehm";
					}
					if (this.prefix == 56)
					{
						text = "Schwach";
					}
					if (this.prefix == 57)
					{
						text = "Rücksichtslos";
					}
					if (this.prefix == 58)
					{
						text = "Rasend";
					}
					if (this.prefix == 59)
					{
						text = "Fromm";
					}
					if (this.prefix == 60)
					{
						text = "Dämonisch";
					}
					if (this.prefix == 61)
					{
						text = "Eifrig";
					}
					if (this.prefix == 62)
					{
						text = "Schwer";
					}
					if (this.prefix == 63)
					{
						text = "Schutz-";
					}
					if (this.prefix == 64)
					{
						text = "Gepanzert";
					}
					if (this.prefix == 65)
					{
						text = "Defensiv";
					}
					if (this.prefix == 66)
					{
						text = "Geheimnisvoll";
					}
					if (this.prefix == 67)
					{
						text = "Präzise";
					}
					if (this.prefix == 68)
					{
						text = "Glücklich";
					}
					if (this.prefix == 69)
					{
						text = "Gezackt";
					}
					if (this.prefix == 70)
					{
						text = "Spike";
					}
					if (this.prefix == 71)
					{
						text = "Wütend";
					}
					if (this.prefix == 72)
					{
						text = "Bedrohlich";
					}
					if (this.prefix == 73)
					{
						text = "Rege";
					}
					if (this.prefix == 74)
					{
						text = "Flüchtig";
					}
					if (this.prefix == 75)
					{
						text = "Hastig";
					}
					if (this.prefix == 76)
					{
						text = "Rasch";
					}
					if (this.prefix == 77)
					{
						text = "Wild";
					}
					if (this.prefix == 78)
					{
						text = "Voreilig";
					}
					if (this.prefix == 79)
					{
						text = "Unerschrocken";
					}
					if (this.prefix == 80)
					{
						text = "Gewalttätig";
					}
					if (this.prefix == 81)
					{
						text = "Legendär";
					}
					if (this.prefix == 82)
					{
						text = "Unwirklich";
					}
					if (this.prefix == 83)
					{
						text = "Mythisch";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						if (this.prefix == 1)
						{
							text = "Grande";
						}
						if (this.prefix == 2)
						{
							text = "Massiccio";
						}
						if (this.prefix == 3)
						{
							text = "Pericoloso";
						}
						if (this.prefix == 4)
						{
							text = "Selvaggio";
						}
						if (this.prefix == 5)
						{
							text = "Appuntito";
						}
						if (this.prefix == 6)
						{
							text = "Tagliente";
						}
						if (this.prefix == 7)
						{
							text = "Minuto";
						}
						if (this.prefix == 8)
						{
							text = "Terribile";
						}
						if (this.prefix == 9)
						{
							text = "Piccolo";
						}
						if (this.prefix == 10)
						{
							text = "Opaco";
						}
						if (this.prefix == 11)
						{
							text = "Infelice";
						}
						if (this.prefix == 12)
						{
							text = "Ingombrante";
						}
						if (this.prefix == 13)
						{
							text = "Vergognoso";
						}
						if (this.prefix == 14)
						{
							text = "Pesante";
						}
						if (this.prefix == 15)
						{
							text = "Luce";
						}
						if (this.prefix == 16)
						{
							text = "Avvistato";
						}
						if (this.prefix == 17)
						{
							text = "Rapido";
						}
						if (this.prefix == 18)
						{
							text = "Frettoloso";
						}
						if (this.prefix == 19)
						{
							text = "Intimidatorio";
						}
						if (this.prefix == 20)
						{
							text = "Mortale";
						}
						if (this.prefix == 21)
						{
							text = "Convinto";
						}
						if (this.prefix == 22)
						{
							text = "Orribile";
						}
						if (this.prefix == 23)
						{
							text = "Letargico";
						}
						if (this.prefix == 24)
						{
							text = "Scomodo";
						}
						if (this.prefix == 25)
						{
							text = "Potente";
						}
						if (this.prefix == 26)
						{
							text = "Mistico";
						}
						if (this.prefix == 27)
						{
							text = "Esperto";
						}
						if (this.prefix == 28)
						{
							text = "Magistrale";
						}
						if (this.prefix == 29)
						{
							text = "Inetto";
						}
						if (this.prefix == 30)
						{
							text = "Ignorante";
						}
						if (this.prefix == 31)
						{
							text = "Squilibrato";
						}
						if (this.prefix == 32)
						{
							text = "Intenso";
						}
						if (this.prefix == 33)
						{
							text = "Tabù";
						}
						if (this.prefix == 34)
						{
							text = "Celeste";
						}
						if (this.prefix == 35)
						{
							text = "Furioso";
						}
						if (this.prefix == 36)
						{
							text = "Appassionato";
						}
						if (this.prefix == 37)
						{
							text = "Superiore";
						}
						if (this.prefix == 38)
						{
							text = "Forte";
						}
						if (this.prefix == 39)
						{
							text = "Rotto";
						}
						if (this.prefix == 40)
						{
							text = "Danneggiato";
						}
						if (this.prefix == 41)
						{
							text = "Scadente";
						}
						if (this.prefix == 42)
						{
							text = "Veloce";
						}
						if (this.prefix == 43)
						{
							text = "Mortale";
						}
						if (this.prefix == 44)
						{
							text = "Agile";
						}
						if (this.prefix == 45)
						{
							text = "Lesto";
						}
						if (this.prefix == 46)
						{
							text = "Omicida";
						}
						if (this.prefix == 47)
						{
							text = "Lento";
						}
						if (this.prefix == 48)
						{
							text = "Pigro";
						}
						if (this.prefix == 49)
						{
							text = "Indolente";
						}
						if (this.prefix == 50)
						{
							text = "Fastidioso";
						}
						if (this.prefix == 51)
						{
							text = "Brutto";
						}
						if (this.prefix == 52)
						{
							text = "Maniaco";
						}
						if (this.prefix == 53)
						{
							text = "Offensivo";
						}
						if (this.prefix == 54)
						{
							text = "Robusto";
						}
						if (this.prefix == 55)
						{
							text = "Sgradevole";
						}
						if (this.prefix == 56)
						{
							text = "Debole";
						}
						if (this.prefix == 57)
						{
							text = "Spietato";
						}
						if (this.prefix == 58)
						{
							text = "Frenetico";
						}
						if (this.prefix == 59)
						{
							text = "Devoto";
						}
						if (this.prefix == 60)
						{
							text = "Demonico";
						}
						if (this.prefix == 61)
						{
							text = "Zelante";
						}
						if (this.prefix == 62)
						{
							text = "Duro";
						}
						if (this.prefix == 63)
						{
							text = "Protettivo";
						}
						if (this.prefix == 64)
						{
							text = "Corazzato";
						}
						if (this.prefix == 65)
						{
							text = "Difensivo";
						}
						if (this.prefix == 66)
						{
							text = "Arcano";
						}
						if (this.prefix == 67)
						{
							text = "Preciso";
						}
						if (this.prefix == 68)
						{
							text = "Fortunato";
						}
						if (this.prefix == 69)
						{
							text = "Frastagliato";
						}
						if (this.prefix == 70)
						{
							text = "Spillo";
						}
						if (this.prefix == 71)
						{
							text = "Arrabbiato";
						}
						if (this.prefix == 72)
						{
							text = "Minaccioso";
						}
						if (this.prefix == 73)
						{
							text = "Vivace";
						}
						if (this.prefix == 74)
						{
							text = "Fugace";
						}
						if (this.prefix == 75)
						{
							text = "Frettoloso";
						}
						if (this.prefix == 76)
						{
							text = "Veloce";
						}
						if (this.prefix == 77)
						{
							text = "Selvaggio";
						}
						if (this.prefix == 78)
						{
							text = "Temerario";
						}
						if (this.prefix == 79)
						{
							text = "Intrepido";
						}
						if (this.prefix == 80)
						{
							text = "Violento";
						}
						if (this.prefix == 81)
						{
							text = "Leggendario";
						}
						if (this.prefix == 82)
						{
							text = "Irreale";
						}
						if (this.prefix == 83)
						{
							text = "Mitico";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							if (this.prefix == 1)
							{
								text = "Grand";
							}
							if (this.prefix == 2)
							{
								text = "Massif";
							}
							if (this.prefix == 3)
							{
								text = "Dangereuses";
							}
							if (this.prefix == 4)
							{
								text = "Sauvages";
							}
							if (this.prefix == 5)
							{
								text = "Coupante";
							}
							if (this.prefix == 6)
							{
								text = "Pointues";
							}
							if (this.prefix == 7)
							{
								text = "Minuscules";
							}
							if (this.prefix == 8)
							{
								text = "Terrible";
							}
							if (this.prefix == 9)
							{
								text = "Petit";
							}
							if (this.prefix == 10)
							{
								text = "Terne";
							}
							if (this.prefix == 11)
							{
								text = "Malheureux";
							}
							if (this.prefix == 12)
							{
								text = "Volumineux";
							}
							if (this.prefix == 13)
							{
								text = "Honteux";
							}
							if (this.prefix == 14)
							{
								text = "Lourds";
							}
							if (this.prefix == 15)
							{
								text = "Léger";
							}
							if (this.prefix == 16)
							{
								text = "Voyants";
							}
							if (this.prefix == 17)
							{
								text = "Rapide";
							}
							if (this.prefix == 18)
							{
								text = "Hâtif";
							}
							if (this.prefix == 19)
							{
								text = "Intimidant";
							}
							if (this.prefix == 20)
							{
								text = "Mortelle";
							}
							if (this.prefix == 21)
							{
								text = "Dévoué";
							}
							if (this.prefix == 22)
							{
								text = "Affreux";
							}
							if (this.prefix == 23)
							{
								text = "Léthargique";
							}
							if (this.prefix == 24)
							{
								text = "Scomodo";
							}
							if (this.prefix == 25)
							{
								text = "Puissante";
							}
							if (this.prefix == 26)
							{
								text = "Mystique";
							}
							if (this.prefix == 27)
							{
								text = "Expert";
							}
							if (this.prefix == 28)
							{
								text = "Magistrale";
							}
							if (this.prefix == 29)
							{
								text = "Inepte";
							}
							if (this.prefix == 30)
							{
								text = "Ignorants";
							}
							if (this.prefix == 31)
							{
								text = "Dérangé";
							}
							if (this.prefix == 32)
							{
								text = "Intenses";
							}
							if (this.prefix == 33)
							{
								text = "Tabou";
							}
							if (this.prefix == 34)
							{
								text = "Célestes";
							}
							if (this.prefix == 35)
							{
								text = "Furieux";
							}
							if (this.prefix == 36)
							{
								text = "Vif";
							}
							if (this.prefix == 37)
							{
								text = "Supérieure";
							}
							if (this.prefix == 38)
							{
								text = "Énergique";
							}
							if (this.prefix == 39)
							{
								text = "Rompu";
							}
							if (this.prefix == 40)
							{
								text = "Endommagés";
							}
							if (this.prefix == 41)
							{
								text = "Mesquin";
							}
							if (this.prefix == 42)
							{
								text = "Prompt";
							}
							if (this.prefix == 43)
							{
								text = "Mortelle";
							}
							if (this.prefix == 44)
							{
								text = "Agile";
							}
							if (this.prefix == 45)
							{
								text = "Leste";
							}
							if (this.prefix == 46)
							{
								text = "Meurtrier";
							}
							if (this.prefix == 47)
							{
								text = "Lente";
							}
							if (this.prefix == 48)
							{
								text = "Paresseux";
							}
							if (this.prefix == 49)
							{
								text = "Fainéant";
							}
							if (this.prefix == 50)
							{
								text = "Ennuyeux";
							}
							if (this.prefix == 51)
							{
								text = "Méchant";
							}
							if (this.prefix == 52)
							{
								text = "Maniaco";
							}
							if (this.prefix == 53)
							{
								text = "Blessant";
							}
							if (this.prefix == 54)
							{
								text = "Robuste";
							}
							if (this.prefix == 55)
							{
								text = "Désagréables";
							}
							if (this.prefix == 56)
							{
								text = "Faibles";
							}
							if (this.prefix == 57)
							{
								text = "Impitoyable";
							}
							if (this.prefix == 58)
							{
								text = "Frénétique";
							}
							if (this.prefix == 59)
							{
								text = "Pieux";
							}
							if (this.prefix == 60)
							{
								text = "Démoniaque";
							}
							if (this.prefix == 61)
							{
								text = "Zélé";
							}
							if (this.prefix == 62)
							{
								text = "Durs";
							}
							if (this.prefix == 63)
							{
								text = "Protecteur";
							}
							if (this.prefix == 64)
							{
								text = "Blindés";
							}
							if (this.prefix == 65)
							{
								text = "Défensif";
							}
							if (this.prefix == 66)
							{
								text = "Ésotérique";
							}
							if (this.prefix == 67)
							{
								text = "Précise";
							}
							if (this.prefix == 68)
							{
								text = "Chanceux";
							}
							if (this.prefix == 69)
							{
								text = "Déchiqueté";
							}
							if (this.prefix == 70)
							{
								text = "Pointes";
							}
							if (this.prefix == 71)
							{
								text = "Fâché";
							}
							if (this.prefix == 72)
							{
								text = "Menaçant";
							}
							if (this.prefix == 73)
							{
								text = "Brusque";
							}
							if (this.prefix == 74)
							{
								text = "Fugace";
							}
							if (this.prefix == 75)
							{
								text = "Hâtif";
							}
							if (this.prefix == 76)
							{
								text = "Prompt";
							}
							if (this.prefix == 77)
							{
								text = "Sauvages";
							}
							if (this.prefix == 78)
							{
								text = "Téméraire";
							}
							if (this.prefix == 79)
							{
								text = "Intrépide";
							}
							if (this.prefix == 80)
							{
								text = "Violent";
							}
							if (this.prefix == 81)
							{
								text = "Légendaire";
							}
							if (this.prefix == 82)
							{
								text = "Irréel";
							}
							if (this.prefix == 83)
							{
								text = "Mythique";
							}
						}
public void SetDefaults(string ItemName)
		{
			this.name = "";
			bool flag = false;
			if (ItemName == "Gold Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(210, 190, 0, 100);
				this.useTime = 17;
				this.pick = 55;
				this.useAnimation = 20;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 10000;
				this.toolTip = "Can mine Meteorite";
				this.netID = -1;
				goto IL_1367;
			}
			if (ItemName == "Gold Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(210, 190, 0, 100);
				this.useAnimation = 20;
				this.damage = 13;
				this.scale = 1.05f;
				this.value = 9000;
				this.netID = -2;
				goto IL_1367;
			}
			if (ItemName == "Gold Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(210, 190, 0, 100);
				this.damage = 11;
				this.useAnimation = 11;
				this.scale = 0.95f;
				this.value = 7000;
				this.netID = -3;
				goto IL_1367;
			}
			if (ItemName == "Gold Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(210, 190, 0, 100);
				this.useTime = 18;
				this.axe = 11;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 7;
				this.value = 8000;
				this.netID = -4;
				goto IL_1367;
			}
			if (ItemName == "Gold Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(210, 190, 0, 100);
				this.useAnimation = 28;
				this.useTime = 23;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 55;
				this.value = 8000;
				this.netID = -5;
				goto IL_1367;
			}
			if (ItemName == "Gold Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 26;
				this.useTime = 26;
				this.color = new Color(210, 190, 0, 100);
				this.damage = 11;
				this.value = 7000;
				this.netID = -6;
				goto IL_1367;
			}
			if (ItemName == "Silver Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(180, 180, 180, 100);
				this.useTime = 11;
				this.pick = 45;
				this.useAnimation = 19;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 5000;
				this.netID = -7;
				goto IL_1367;
			}
			if (ItemName == "Silver Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(180, 180, 180, 100);
				this.useAnimation = 21;
				this.damage = 11;
				this.value = 4500;
				this.netID = -8;
				goto IL_1367;
			}
			if (ItemName == "Silver Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(180, 180, 180, 100);
				this.damage = 9;
				this.useAnimation = 12;
				this.scale = 0.95f;
				this.value = 3500;
				this.netID = -9;
				goto IL_1367;
			}
			if (ItemName == "Silver Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(180, 180, 180, 100);
				this.useTime = 18;
				this.axe = 10;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 6;
				this.value = 4000;
				this.netID = -10;
				goto IL_1367;
			}
			if (ItemName == "Silver Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(180, 180, 180, 100);
				this.useAnimation = 29;
				this.useTime = 19;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 45;
				this.value = 4000;
				this.netID = -11;
				goto IL_1367;
			}
			if (ItemName == "Silver Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 27;
				this.useTime = 27;
				this.color = new Color(180, 180, 180, 100);
				this.damage = 9;
				this.value = 3500;
				this.netID = -12;
				goto IL_1367;
			}
			if (ItemName == "Copper Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(180, 100, 45, 80);
				this.useTime = 15;
				this.pick = 35;
				this.useAnimation = 23;
				this.damage = 4;
				this.scale = 0.9f;
				this.tileBoost = -1;
				this.value = 500;
				this.netID = -13;
				goto IL_1367;
			}
			if (ItemName == "Copper Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(180, 100, 45, 80);
				this.useAnimation = 23;
				this.damage = 8;
				this.value = 450;
				this.netID = -14;
				goto IL_1367;
			}
			if (ItemName == "Copper Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(180, 100, 45, 80);
				this.damage = 5;
				this.useAnimation = 13;
				this.scale = 0.8f;
				this.value = 350;
				this.netID = -15;
				goto IL_1367;
			}
			if (ItemName == "Copper Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(180, 100, 45, 80);
				this.useTime = 21;
				this.axe = 7;
				this.useAnimation = 30;
				this.scale = 1f;
				this.damage = 3;
				this.tileBoost = -1;
				this.value = 400;
				this.netID = -16;
				goto IL_1367;
			}
			if (ItemName == "Copper Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(180, 100, 45, 80);
				this.useAnimation = 33;
				this.useTime = 23;
				this.scale = 1.1f;
				this.damage = 4;
				this.hammer = 35;
				this.tileBoost = -1;
				this.value = 400;
				this.netID = -17;
				goto IL_1367;
			}
			if (ItemName == "Copper Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 29;
				this.useTime = 29;
				this.color = new Color(180, 100, 45, 80);
				this.damage = 6;
				this.value = 350;
				this.netID = -18;
				goto IL_1367;
			}
			if (ItemName == "Blue Phasesaber")
			{
				this.SetDefaults(198, false);
				this.damage = 213;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -19;
				goto IL_1367;
			}
			if (ItemName == "Red Phasesaber")
			{
				this.SetDefaults(199, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -20;
				goto IL_1367;
			}
			if (ItemName == "Green Phasesaber")
			{
				this.SetDefaults(200, false);
				this.damage = 213;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -21;
				goto IL_1367;
			}
			if (ItemName == "Purple Phasesaber")
			{
				this.SetDefaults(201, false);
				this.damage = 213;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -22;
				goto IL_1367;
			}
			if (ItemName == "White Phasesaber")
			{
				this.SetDefaults(202, false);
				this.damage = 213;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -23;
				goto IL_1367;
			}
			if (ItemName == "Yellow Phasesaber")
			{
				this.SetDefaults(203, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -24;
				goto IL_1367;
			}
			if (ItemName == "Tin Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(170, 150, 80, 110);
				this.useTime = 14;
				this.pick = 35;
				this.useAnimation = 21;
				this.damage = 5;
				this.scale = 0.95f;
				this.value = 750;
				this.netID = -25;
				goto IL_1367;
			}
			if (ItemName == "Tin Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(170, 150, 80, 110);
				this.useAnimation = 22;
				this.damage = 9;
				this.value = 675;
				this.netID = -26;
				goto IL_1367;
			}
			if (ItemName == "Tin Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(170, 150, 80, 110);
				this.damage = 7;
				this.useAnimation = 12;
				this.scale = 0.85f;
				this.value = 525;
				this.netID = -27;
				goto IL_1367;
			}
			if (ItemName == "Tin Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(170, 150, 80, 110);
				this.useTime = 20;
				this.axe = 8;
				this.useAnimation = 28;
				this.scale = 1.05f;
				this.damage = 4;
				this.value = 600;
				this.netID = -28;
				goto IL_1367;
			}
			if (ItemName == "Tin Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(170, 150, 80, 110);
				this.useAnimation = 31;
				this.useTime = 21;
				this.scale = 1.15f;
				this.damage = 6;
				this.hammer = 38;
				this.value = 600;
				this.netID = -29;
				goto IL_1367;
			}
			if (ItemName == "Tin Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 28;
				this.useTime = 28;
				this.color = new Color(170, 150, 80, 110);
				this.damage = 7;
				this.value = 525;
				this.netID = -30;
				goto IL_1367;
			}
			if (ItemName == "Lead Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(90, 100, 110, 170);
				this.useTime = 12;
				this.pick = 210;
				this.useAnimation = 19;
				this.damage = 6;
				this.scale = 1.025f;
				this.value = 3000;
				this.netID = -31;
				goto IL_1367;
			}
			if (ItemName == "Lead Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(80, 90, 170, 160);
				this.useAnimation = 21;
				this.damage = 11;
				this.value = 2700;
				this.netID = -32;
				goto IL_1367;
			}
			if (ItemName == "Lead Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(90, 100, 110, 170);
				this.damage = 9;
				this.useAnimation = 12;
				this.scale = 0.925f;
				this.value = 2100;
				this.netID = -33;
				goto IL_1367;
			}
			if (ItemName == "Lead Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(90, 100, 110, 170);
				this.useTime = 19;
				this.axe = 10;
				this.useAnimation = 28;
				this.scale = 1.125f;
				this.damage = 6;
				this.value = 2400;
				this.netID = -34;
				goto IL_1367;
			}
			if (ItemName == "Lead Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(90, 100, 110, 170);
				this.useAnimation = 29;
				this.useTime = 19;
				this.scale = 1.225f;
				this.damage = 8;
				this.hammer = 43;
				this.value = 2400;
				this.netID = -35;
				goto IL_1367;
			}
			if (ItemName == "Lead Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 27;
				this.useTime = 27;
				this.color = new Color(90, 100, 110, 170);
				this.damage = 9;
				this.value = 2100;
				this.netID = -36;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(130, 180, 130, 100);
				this.useTime = 19;
				this.pick = 50;
				this.useAnimation = 21;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 7500;
				this.netID = -37;
				this.toolTip = "Can mine Meteorite";
				goto IL_1367;
			}
			if (ItemName == "Tungsten Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(130, 180, 130, 100);
				this.useAnimation = 20;
				this.damage = 12;
				this.scale *= 1.025f;
				this.value = 6750;
				this.netID = -38;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(130, 180, 130, 100);
				this.damage = 10;
				this.useAnimation = 11;
				this.scale = 0.95f;
				this.value = 5250;
				this.netID = -39;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(130, 180, 130, 100);
				this.useTime = 18;
				this.axe = 11;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 7;
				this.value = 4000;
				this.netID = -40;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(130, 180, 130, 100);
				this.useAnimation = 28;
				this.useTime = 25;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 50;
				this.value = 6000;
				this.netID = -41;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 26;
				this.useTime = 26;
				this.color = new Color(130, 180, 130, 100);
				this.damage = 10;
				this.value = 5250;
				this.netID = -42;
				goto IL_1367;
			}
			if (ItemName == "Platinum Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(110, 140, 200, 80);
				this.useTime = 15;
				this.pick = 59;
				this.useAnimation = 19;
				this.scale = 1.05f;
				this.damage = 7;
				this.value = 15000;
				this.toolTip = "Can mine Meteorite";
				this.netID = -43;
				goto IL_1367;
			}
			if (ItemName == "Platinum Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(110, 140, 200, 80);
				this.useAnimation = 19;
				this.damage = 15;
				this.scale = 1.075f;
				this.value = 13500;
				this.netID = -44;
				goto IL_1367;
			}
			if (ItemName == "Platinum Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(110, 140, 200, 80);
				this.damage = 13;
				this.useAnimation = 10;
				this.scale = 0.975f;
				this.value = 10500;
				this.netID = -45;
				goto IL_1367;
			}
			if (ItemName == "Platinum Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(110, 140, 200, 80);
				this.useTime = 17;
				this.axe = 12;
				this.useAnimation = 25;
				this.scale = 1.175f;
				this.damage = 8;
				this.value = 12000;
				this.netID = -46;
				goto IL_1367;
			}
			if (ItemName == "Platinum Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(110, 140, 200, 80);
				this.useAnimation = 27;
				this.useTime = 21;
				this.scale = 1.275f;
				this.damage = 10;
				this.hammer = 59;
				this.value = 12000;
				this.netID = -47;
				goto IL_1367;
			}
			if (ItemName == "Platinum Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 25;
				this.useTime = 25;
				this.color = new Color(110, 140, 200, 80);
				this.damage = 13;
				this.value = 10500;
				this.netID = -48;
				goto IL_1367;
			}
}
			if (ItemName != "")
			{
				for (int i = 0; i < 1725; i++)
				{
					if (Main.itemName[i] == ItemName)
					{
						this.SetDefaults(i, false);
						this.checkMat();
						return;
					}
				}
				this.name = "";
				this.stack = 0;
				this.type = 0;
			}
			IL_1367:
			if (this.type != 0)
			{
				if (flag)
				{
					this.material = false;
					goto IL_1382;
				}
				this.checkMat();
				IL_1382:
				this.name = ItemName;
				this.name = Lang.itemName(this.netID, false);
				this.CheckTip();
			}
		}
		public Rectangle getRect()
		{
			return new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height);
		}
		public bool checkMat()
		{
			if (this.type >= 71 && this.type <= 74)
			{
				this.material = false;
				return false;
			}
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				int num = 0;
				while (Main.recipe[i].requiredItem[num].type > 0)
				{
					if (this.netID == Main.recipe[i].requiredItem[num].netID)
					{
						this.material = true;
						return true;
					}
					num++;
				}
			}
			this.material = false;
			return false;
		}
		public void netDefaults(int type)
		{
			if (type < 0)
			{
				if (type == -1)
				{
					this.SetDefaults("Gold Pickaxe");
					return;
				}
				if (type == -2)
				{
					this.SetDefaults("Gold Broadsword");
					return;
				}
				if (type == -3)
				{
					this.SetDefaults("Gold Shortsword");
					return;
				}
				if (type == -4)
				{
					this.SetDefaults("Gold Axe");
					return;
				}
				if (type == -5)
				{
					this.SetDefaults("Gold Hammer");
					return;
				}
				if (type == -6)
				{
					this.SetDefaults("Gold Bow");
					return;
				}
				if (type == -7)
				{
					this.SetDefaults("Silver Pickaxe");
					return;
				}
				if (type == -8)
				{
					this.SetDefaults("Silver Broadsword");
					return;
				}
				if (type == -9)
				{
					this.SetDefaults("Silver Shortsword");
					return;
				}
				if (type == -10)
				{
					this.SetDefaults("Silver Axe");
					return;
				}
				if (type == -11)
				{
					this.SetDefaults("Silver Hammer");
					return;
				}
				if (type == -12)
				{
					this.SetDefaults("Silver Bow");
					return;
				}
				if (type == -13)
				{
					this.SetDefaults("Copper Pickaxe");
					return;
				}
				if (type == -14)
				{
					this.SetDefaults("Copper Broadsword");
					return;
				}
				if (type == -15)
				{
					this.SetDefaults("Copper Shortsword");
					return;
				}
				if (type == -16)
				{
					this.SetDefaults("Copper Axe");
					return;
				}
				if (type == -17)
				{
					this.SetDefaults("Copper Hammer");
					return;
				}
				if (type == -18)
				{
					this.SetDefaults("Copper Bow");
					return;
				}
				if (type == -19)
				{
					this.SetDefaults("Blue Phasesaber");
					return;
				}
				if (type == -20)
				{
					this.SetDefaults("Red Phasesaber");
					return;
				}
				if (type == -21)
				{
					this.SetDefaults("Green Phasesaber");
					return;
				}
				if (type == -22)
				{
					this.SetDefaults("Purple Phasesaber");
					return;
				}
				if (type == -23)
				{
					this.SetDefaults("White Phasesaber");
					return;
				}
				if (type == -24)
				{
					this.SetDefaults("Yellow Phasesaber");
					return;
				}
				if (type == -25)
				{
					this.SetDefaults("Tin Pickaxe");
					return;
				}
				if (type == -26)
				{
					this.SetDefaults("Tin Broadsword");
					return;
				}
				if (type == -27)
				{
					this.SetDefaults("Tin Shortsword");
					return;
				}
				if (type == -28)
				{
					this.SetDefaults("Tin Axe");
					return;
				}
				if (type == -29)
				{
					this.SetDefaults("Tin Hammer");
					return;
				}
				if (type == -30)
				{
					this.SetDefaults("Tin Bow");
					return;
				}
				if (type == -31)
				{
					this.SetDefaults("Lead Pickaxe");
					return;
				}
				if (type == -32)
				{
					this.SetDefaults("Lead Broadsword");
					return;
				}
				if (type == -33)
				{
					this.SetDefaults("Lead Shortsword");
					return;
				}
				if (type == -34)
				{
					this.SetDefaults("Lead Axe");
					return;
				}
				if (type == -35)
				{
					this.SetDefaults("Lead Hammer");
					return;
				}
				if (type == -36)
				{
					this.SetDefaults("Lead Bow");
					return;
				}
				if (type == -37)
				{
					this.SetDefaults("Tungsten Pickaxe");
					return;
				}
				if (type == -38)
				{
					this.SetDefaults("Tungsten Broadsword");
					return;
				}
				if (type == -39)
				{
					this.SetDefaults("Tungsten Shortsword");
					return;
				}
				if (type == -40)
				{
					this.SetDefaults("Tungsten Axe");
					return;
				}
				if (type == -41)
				{
					this.SetDefaults("Tungsten Hammer");
					return;
				}
				if (type == -42)
				{
					this.SetDefaults("Tungsten Bow");
					return;
				}
				if (type == -43)
				{
					this.SetDefaults("Platinum Pickaxe");
					return;
				}
				if (type == -44)
				{
					this.SetDefaults("Platinum Broadsword");
					return;
				}
				if (type == -45)
				{
					this.SetDefaults("Platinum Shortsword");
					return;
				}
				if (type == -46)
				{
					this.SetDefaults("Platinum Axe");
					return;
				}
				if (type == -47)
				{
					this.SetDefaults("Platinum Hammer");
					return;
				}
				if (type == -48)
				{
					this.SetDefaults("Platinum Bow");
					return;
				}
				return;
			}
			this.SetDefaults(type, false);
		}
		public static int NPCtoBanner(int i)
		{
			switch (i)
			{
			case 1:
			case 147:
			case 184:
				return 69;
			case 2:
			case 133:
			case 190:
			case 191:
			case 192:
			case 193:
			case 194:
				return 25;
			case 3:
			case 132:
			case 186:
			case 187:
			case 188:
			case 189:
			case 200:
				return 87;
			case 6:
				return 27;
			case 10:
			case 11:
			case 12:
			case 95:
			case 96:
			case 97:
				return 84;
			case 21:
			case 201:
			case 202:
			case 203:
				return 67;
			case 23:
				return 55;
			case 24:
				return 50;
			case 27:
				return 41;
			case 28:
				return 42;
			case 29:
				return 39;
			case 32:
				return 68;
			case 39:
			case 40:
			case 41:
				return 13;
			case 42:
			case 176:
			case 231:
			case 232:
			case 233:
			case 234:
			case 235:
				return 47;
			case 43:
				return 54;
			case 46:
				return 14;
			case 47:
				return 18;
			case 48:
				return 44;
			case 49:
			case 93:
				return 7;
			case 55:
			case 230:
				return 43;
			case 57:
				return 19;
			case 58:
				return 61;
			case 60:
			case 151:
				return 45;
			case 61:
				return 79;
			case 62:
			case 66:
			case 156:
				return 24;
			case 63:
			case 64:
			case 103:
				return 51;
			case 65:
				return 66;
			case 67:
				return 20;
			case 69:
				return 4;
			case 73:
				return 40;
			case 74:
				return 8;
			case 75:
				return 63;
			case 77:
				return 6;
			case 78:
			case 79:
			case 80:
				return 57;
			case 82:
				return 85;
			case 83:
				return 23;
			case 84:
				return 28;
			case 85:
				return 16;
			case 86:
				return 77;
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
				return 86;
			case 98:
			case 99:
			case 100:
				return 83;
			case 102:
				return 1;
			case 104:
				return 81;
			case 109:
				return 17;
			case 111:
				return 38;
			case 120:
				return 15;
			case 122:
				return 37;
			case 141:
				return 75;
			case 153:
			case 154:
				return 74;
			case 155:
				return 82;
			case 157:
				return 5;
			case 158:
			case 159:
				return 78;
			case 161:
				return 29;
			case 162:
				return 34;
			case 163:
			case 238:
				return 9;
			case 164:
			case 165:
				return 71;
			case 166:
				return 73;
			case 169:
				return 48;
			case 170:
			case 171:
			case 180:
				return 60;
			case 173:
				return 21;
			case 174:
				return 46;
			case 177:
				return 26;
			case 179:
				return 22;
			case 181:
				return 30;
			case 182:
				return 31;
			case 185:
				return 70;
			case 195:
			case 196:
				return 80;
			case 198:
			case 199:
				return 53;
			case 205:
				return 56;
			case 206:
				return 49;
			case 212:
			case 213:
			case 214:
			case 215:
			case 216:
				return 62;
			case 223:
				return 64;
			case 224:
				return 32;
			case 225:
				return 76;
			case 226:
				return 33;
			case 236:
			case 237:
				return 52;
			case 239:
				return 12;
			case 241:
				return 10;
			case 242:
				return 11;
			case 250:
				return 2;
			case 252:
				return 59;
			case 253:
				return 65;
			case 254:
			case 255:
				return 72;
			case 256:
				return 36;
			case 257:
				return 3;
			case 258:
				return 58;
			case 259:
			case 260:
				return 35;
			}
			return -1;
		}
		public static int BannerToNPC(int i)
		{
			switch (i)
			{
			case 1:
				return 102;
			case 2:
				return 250;
			case 3:
				return 257;
			case 4:
				return 69;
			case 5:
				return 157;
			case 6:
				return 77;
			case 7:
				return 49;
			case 8:
				return 74;
			case 9:
				return 163;
			case 10:
				return 241;
			case 11:
				return 242;
			case 12:
				return 239;
			case 13:
				return 39;
			case 14:
				return 46;
			case 15:
				return 120;
			case 16:
				return 85;
			case 17:
				return 109;
			case 18:
				return 47;
			case 19:
				return 57;
			case 20:
				return 67;
			case 21:
				return 173;
			case 22:
				return 179;
			case 23:
				return 83;
			case 24:
				return 62;
			case 25:
				return 2;
			case 26:
				return 177;
			case 27:
				return 6;
			case 28:
				return 84;
			case 29:
				return 161;
			case 30:
				return 181;
			case 31:
				return 182;
			case 32:
				return 224;
			case 33:
				return 226;
			case 34:
				return 162;
			case 35:
				return 259;
			case 36:
				return 256;
			case 37:
				return 122;
			case 38:
				return 111;
			case 39:
				return 29;
			case 40:
				return 73;
			case 41:
				return 27;
			case 42:
				return 28;
			case 43:
				return 55;
			case 44:
				return 48;
			case 45:
				return 60;
			case 46:
				return 174;
			case 47:
				return 42;
			case 48:
				return 169;
			case 49:
				return 206;
			case 50:
				return 24;
			case 51:
				return 63;
			case 52:
				return 236;
			case 53:
				return 199;
			case 54:
				return 43;
			case 55:
				return 23;
			case 56:
				return 205;
			case 57:
				return 78;
			case 58:
				return 258;
			case 59:
				return 252;
			case 60:
				return 170;
			case 61:
				return 58;
			case 62:
				return 212;
			case 63:
				return 75;
			case 64:
				return 223;
			case 65:
				return 253;
			case 66:
				return 65;
			case 67:
				return 21;
			case 68:
				return 32;
			case 69:
				return 1;
			case 70:
				return 185;
			case 71:
				return 164;
			case 72:
				return 254;
			case 73:
				return 166;
			case 74:
				return 153;
			case 75:
				return 141;
			case 76:
				return 225;
			case 77:
				return 86;
			case 78:
				return 158;
			case 79:
				return 61;
			case 80:
				return 196;
			case 81:
				return 104;
			case 82:
				return 155;
			case 83:
				return 98;
			case 84:
				return 10;
			case 85:
				return 82;
			case 86:
				return 87;
			case 87:
				return 3;
			default:
				return -1;
			}
		}
		public void SetDefaults(int Type, bool noMatCheck = false)
		{
			if (Main.netMode == 1 || Main.netMode == 2)
			{
				this.owner = 255;
				goto IL_28;
			}
			this.owner = Main.myPlayer;
			IL_28:
			this.dye = 0;
			this.paint = 0;
			this.tileWand = -1;
			this.notAmmo = false;
			this.netID = 0;
			this.prefix = 0;
			this.crit = 0;
			this.mech = false;
			this.flame = false;
			this.reuseDelay = 0;
			this.melee = false;
			this.magic = false;
			this.ranged = false;
			this.summon = false;
			this.placeStyle = 0;
			this.buffTime = 0;
			this.buffType = 0;
			this.material = false;
			this.noWet = false;
			this.vanity = false;
			this.mana = 0;
			this.wet = false;
			this.wetCount = 0;
			this.lavaWet = false;
			this.channel = false;
			this.manaIncrease = 0;
			this.release = 0;
			this.noMelee = false;
			this.noUseGraphic = false;
			this.lifeRegen = 0;
			this.shootSpeed = 0f;
			this.active = true;
			this.alpha = 0;
			this.ammo = 0;
			this.useAmmo = 0;
			this.autoReuse = false;
			this.accessory = false;
			this.axe = 0;
			this.healMana = 0;
			this.bodySlot = -1;
			this.legSlot = -1;
			this.headSlot = -1;
			this.potion = false;
			this.color = default(Color);
			this.consumable = false;
			this.createTile = -1;
			this.createWall = -1;
			this.damage = -1;
			this.defense = 0;
			this.hammer = 0;
			this.healLife = 0;
			this.holdStyle = 0;
			this.knockBack = 0f;
			this.maxStack = 1;
			this.pick = 0;
			this.rare = 0;
			this.scale = 1f;
			this.shoot = 0;
			this.stack = 1;
			this.toolTip = null;
			this.toolTip2 = null;
			this.tileBoost = 0;
			this.type = Type;
			this.useStyle = 0;
			this.useSound = 0;
			this.useTime = 100;
			this.useAnimation = 100;
			this.value = 0;
			this.useTurn = false;
			this.buy = false;
			if (this.type == 0)
			{
				this.netID = 0;
				this.name = "";
				this.stack = 0;
				goto IL_381A;
				}
			if (this.type == 127)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 10;
				this.useTime = 7;
				this.name = "Space Zapper";
				this.width = 24;
				this.height = 28;
				this.shoot = 20;
				this.mana = 1;
				this.useSound = 12;
				this.knockBack = 0.5f;
				this.damage = 100;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.scale = 0.8f;
				this.rare = 4;
				this.magic = true;
				this.value = 20000;
				goto IL_2B846;
			}
			}
			if (this.type == 1)
			{
if (this.type == 273)
			{
				this.name = "Sword of Luna";
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 14;
				this.knockBack = 6.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 115;
				this.scale = 1.15f;
	                        this.shoot = 157
				this.useSound = 1;
				this.rare = 3;
				this.value = 54000;
				this.melee = true;
				goto IL_2B846;
	                }
			if (this.type == 758)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Grenade Launcher";
				this.useAmmo = 771;
				this.width = 50;
				this.height = 20;
				this.shoot = 133;
				this.useSound = 11;
				this.damage = 55;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 4f;
				this.rare = 8;
				this.ranged = true;
				goto IL_2B846;
			}
			}
			if (this.type == 792)
			{
				this.name = "Crimson Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 25;
				this.headSlot = 57;
				this.value = 50000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 793)
			{
				this.name = "Crimson Scalemail";
				this.width = 18;
				this.height = 18;
				this.defense = 35;
				this.bodySlot = 37;
				this.value = 40000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 794)
			{
				this.name = "Crimson Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 20;
				this.legSlot = 35;
				this.value = 30000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
				if 
					(this.type == 1327)
			{
				this.autoReuse = true;
				this.name = "Soul Sickle";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.knockBack = 7f;
				this.width = 24;
				this.height = 28;
				this.damage = 180;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 6;
				this.shoot = 274;
				this.shootSpeed = 9f;
				this.value = 250000;
				this.toolTip = "Shoots a deathly sickle";
				this.melee = true;
				goto IL_2B846;
			}
			}
			if (this.type == 1553)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 7;
				this.useTime = 5;
				this.name = "G.D.D.";
				this.crit += 5;
				this.width = 60;
				this.height = 26;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 35;
				this.shootSpeed = 12f;
				this.noMelee = true;
				this.value = 750000;
				this.rare = 8;
				this.toolTip = "100% chance to not consume ammo";
				this.toolTip2 = "'Galactic Dolphin Decimator'";
				this.knockBack = 2.5f;
				this.ranged = true;
				goto IL_2B846;
			}
			}
			if (this.type == 1569)
			{
				this.autoReuse = true;
				this.useStyle = 1;
				this.name = "Crystal Knives";
				this.shootSpeed = 15f;
				this.shoot = 304;
				this.damage = 65;
				this.width = 18;
				this.height = 20;
				this.useSound = 39;
				this.useAnimation = 16;
				this.useTime = 16;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 20, 0, 0);
				this.knockBack = 2.75f;
				this.melee = true;
				this.rare = 8;
				this.toolTip = "Rapidly shoot life stealing daggers";
				goto IL_2B846;
			}
