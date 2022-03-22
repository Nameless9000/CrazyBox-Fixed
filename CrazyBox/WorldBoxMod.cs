using UnityEngine;

namespace CrazyBox
{
	internal class WorldBoxMod : MonoBehaviour
	{
		public void Awake()
		{
			Config.MODDED = true;
			this.init();
		}

		private void init()
		{
			ActorStats actorStats = AssetManager.unitStats.get("dragon");
			actorStats.traits.Add("giant");
			actorStats.baseStats.armor = 50;
			actorStats.baseStats.damage = 160;
			ActorStats actorStats2 = AssetManager.unitStats.get("bear");
			actorStats2.traits.Add("giant");
			ActorStats actorStats3 = AssetManager.unitStats.get("baby_human");
			actorStats3.traits.Remove("peaceful");
			ActorStats actorStats4 = AssetManager.unitStats.get("baby_elf");
			actorStats4.traits.Remove("peaceful");
			ActorStats actorStats5 = AssetManager.unitStats.get("baby_dwarf");
			actorStats5.traits.Remove("peaceful");
			ActorStats actorStats6 = AssetManager.unitStats.get("baby_orc");
			actorStats6.traits.Remove("peaceful");
			BuildingAsset buildingAsset = AssetManager.buildings.get("goldenBrain");
			buildingAsset.spawnUnits = true;
			buildingAsset.spawnUnits_asset = "bear";
			ActorJob actorJob = AssetManager.job_actor.get("baby");
			actorJob.addTask("find_city_job");
			MoodAsset moodAsset = AssetManager.moods.get("angry");
			moodAsset.baseStats.mod_damage = 40f;
			ActorTrait actorTrait = new ActorTrait();
			actorTrait.id = "workaholic";
			actorTrait.icon = AssetManager.traits.get("energized").icon;
			actorTrait.baseStats.stewardship = 11;
			actorTrait.baseStats.accuracy = 10f;
			actorTrait.baseStats.attackSpeed = 15f;
			actorTrait.baseStats.warfare = -3;
			actorTrait.baseStats.diplomacy = -5;
			actorTrait.birth = 0.8f;
			actorTrait.inherit = 45f;
			AssetManager.traits.add(actorTrait);
			addLocalization("trait_" + actorTrait.id, "Workaholic");
			addLocalization("trait_" + actorTrait.id + "_info", "Addicted to working");
			ActorTrait actorTrait2 = new ActorTrait();
			actorTrait2.id = "bowmaster";
			actorTrait2.icon = AssetManager.traits.get("eagle_eyed").icon;
			actorTrait2.birth = 0.3f;
			actorTrait2.inherit = 65f;
			actorTrait2.baseStats.accuracy = 100f;
			actorTrait2.baseStats.mod_attackSpeed = 50f;
			actorTrait2.baseStats.mod_damage = 40f;
			actorTrait2.baseStats.range = 8f;
			AssetManager.traits.add(actorTrait2);
			addLocalization("trait_" + actorTrait2.id, "Bowmaster");
			addLocalization("trait_" + actorTrait2.id + "_info", "Very skilled when it comes to archery");
			ActorTrait actorTrait3 = new ActorTrait();
			actorTrait3.id = "DiscordModerator";
			actorTrait3.icon = AssetManager.traits.get("fat").icon;
			actorTrait3.birth = 0.1f;
			actorTrait3.inherit = 60f;
			actorTrait3.baseStats.mod_speed = -80f;
			actorTrait3.baseStats.mod_attackSpeed = -30f;
			actorTrait3.baseStats.mod_diplomacy = -15f;
			actorTrait3.baseStats.stewardship = 2;
			actorTrait3.baseStats.health = 65;
			actorTrait3.baseStats.mod_damage = 10f;
			AssetManager.traits.add(actorTrait3);
			addLocalization("trait_" + actorTrait3.id, "Discord Moderator");
			addLocalization("trait_" + actorTrait3.id + "_info", "Discord mod, his weight is beyond measure");
			ActorTrait actorTrait4 = new ActorTrait();
			actorTrait4.id = "Demigod";
			actorTrait4.icon = AssetManager.traits.get("blessed").icon;
			actorTrait4.baseStats.mod_damage = 1400f;
			actorTrait4.baseStats.mod_attackSpeed = 180f;
			actorTrait4.baseStats.mod_diplomacy = 300f;
			actorTrait4.baseStats.mod_health = 4900f;
			actorTrait4.baseStats.mod_speed = 200f;
			actorTrait4.baseStats.crit = 150f;
			actorTrait4.baseStats.damageCritMod = 100f;
			actorTrait4.baseStats.armor = 50;
			actorTrait4.baseStats.mod_armor = 100f;
			actorTrait4.baseStats.dodge = 40f;
			actorTrait4.baseStats.stewardship = 40;
			actorTrait4.baseStats.knockbackReduction = 100f;
			actorTrait4.baseStats.warfare = 35;
			actorTrait4.action_death = new WorldAction(ActionLibrary.startNuke);
			actorTrait4.birth = 0f;
			actorTrait4.inherit = 0f;
			AssetManager.traits.add(actorTrait4);
			addLocalization("trait_" + actorTrait4.id, "Demigod");
			CrazyBox.WorldBoxMod.addLocalization("trait_" + actorTrait4.id + "_info", "He's the chosen one. Also be careful when killing him");
			ActorTrait actorTrait5 = new ActorTrait();
			actorTrait5.id = "drunk";
			actorTrait5.icon = AssetManager.resources.get("ale").icon;
			actorTrait5.baseStats.accuracy = -70f;
			actorTrait5.baseStats.mod_damage = -20f;
			actorTrait5.baseStats.mod_health = -35f;
			actorTrait5.baseStats.mod_speed = -30f;
			actorTrait5.baseStats.diplomacy = -25;
			actorTrait5.baseStats.stewardship = -23;
			actorTrait5.baseStats.mod_attackSpeed = -65f;
			actorTrait5.baseStats.warfare = -20;
			actorTrait5.birth = 0.75f;
			AssetManager.traits.add(actorTrait5);
			CrazyBox.WorldBoxMod.addLocalization("trait_" + actorTrait5.id, "Drunk");
			CrazyBox.WorldBoxMod.addLocalization("trait_" + actorTrait5.id + "_info", "Drank too much apple juice");
			ActorTrait actorTrait6 = new ActorTrait();
			actorTrait6.id = "super_inelligence";
			actorTrait6.icon = AssetManager.culture_tech.get("knowledge_gain_3").icon;
			actorTrait6.baseStats.intelligence = 300;
			actorTrait6.baseStats.diplomacy = 45;
			actorTrait6.baseStats.stewardship = 40;
			actorTrait6.baseStats.warfare = 30;
			actorTrait6.birth = 0.015f;
			actorTrait6.inherit = 60f;
			AssetManager.traits.add(actorTrait6);
			CrazyBox.WorldBoxMod.addLocalization("trait_" + actorTrait6.id, "Super intelligence");
			CrazyBox.WorldBoxMod.addLocalization("trait_" + actorTrait6.id + "_info", "This is big brain time");
			ActorTrait actorTrait7 = new ActorTrait();
			actorTrait7.id = "titan";
			actorTrait7.icon = AssetManager.traits.get("giant").icon;
			actorTrait7.baseStats.scale = 0.6f;
			actorTrait7.baseStats.mod_health = 700f;
			actorTrait7.baseStats.mod_damage = 200f;
			actorTrait7.baseStats.mod_attackSpeed = -30f;
			actorTrait7.baseStats.range = 1f;
			actorTrait7.inherit = 100f;
			AssetManager.traits.add(actorTrait7);
			addLocalization("trait_" + actorTrait7.id, "Titan");
			addLocalization("trait_" + actorTrait7.id + "_info", "He is big. Really big");
		}

		public static void addLocalization(string key, string value)
		{
			System.Collections.Generic.Dictionary<string, string> dictionary = ReflectionUtility.Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as System.Collections.Generic.Dictionary<string, string>;
			dictionary.Add(key, value);
		}
	}
}
