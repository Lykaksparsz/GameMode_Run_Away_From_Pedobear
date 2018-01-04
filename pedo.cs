datablock PlayerData(PlayerPedo : PlayerStandardArmor)
{
   // copied from bot_zombie.cs,
   // because i am beginner.
   maxForwardSpeed = 4.5;
   uiName = "";
   minJetEnergy = 0;
   jetEnergyDrain = 0;
   canJet = 0;
   maxItems   = 0;
   maxWeapons = 0;
   maxTools = 0;
   runforce = 100 * 90;
   maxForwardSpeed = 8;
   maxBackwardSpeed = 4;
   maxSideSpeed = 8;
   attackpower = 999;
   rideable = false;
   canRide = false;
   maxdamage = 100;
   jumpSound = "";

   //Hole Attributes
	isHoleBot = 0;

	//Spawning option
	hSpawnTooClose = 0;//Doesn't spawn when player is too close and can see it
	  hSpawnTCRange = 8;//above range, set in brick units
	hSpawnClose = 0;//Only spawn when close to a player, can be used with above function as long as hSCRange is higher than hSpawnTCRange
	  hSpawnCRange = 64;//above range, set in brick units

	hType = zombie; //Enemy,Friendly, Neutral
	  hNeutralAttackChance = 100;
	//can have unique types, nazis will attack zombies but nazis will not attack other bots labeled nazi
	hName = "Pedobear";//cannot contain spaces
	hTickRate = 3000;
	
	//Wander Options
	hWander = 1;//Enables random walking
	  hSmoothWander = 1;
	  hReturnToSpawn = 1;//Returns to spawn when too far
	  hSpawnDist = 32;//Defines the distance bot can travel away from spawnbrick
	
	//Searching options
	hSearch = 1;//Search for Players
	  hSearchRadius = 256;//in brick units
	  hSight = 1;//Require bot to see player before pursuing
	  hStrafe = 1;//Randomly strafe while following player
	hSearchFOV = 1;//if enabled disables normal hSearch
	  hFOVRadius = 32;//max 10

	  hAlertOtherBots = 1;//Alerts other bots when he sees a player, or gets attacked

	//Attack Options
	hMelee = 1;//Melee
	  hAttackDamage = 15;//15;//Melee Damage
	hShoot = 0;
	  hWep = "gunImage";
	  hShootTimes = 4;//Number of times the bot will shoot between each tick
	  hMaxShootRange = 30;//The range in which the bot will shoot the player
	  hAvoidCloseRange = 1;//
		hTooCloseRange = 7;//in brick units
	//hHerding = 0;
	//hSound = 1;
	//hSpawnDetect = -1;//Will not spawn when user is too close and can see spawn
	

	
	//Misc options
	hAvoidObstacles = 1;
	hSuperStacker = 1;
	hSpazJump = 0;//Makes bot jump when the user their following is higher than them

	hAFKOmeter = 1;//Determines how often the bot will wander or do other idle actions, higher it is the less often he does things
	hIdle = 1;// Enables use of idle actions, actions which are done when the bot is not doing anything else
	  hIdleAnimation = 1;//Plays random animations/emotes, sit, click, love/hate/etc
	  hIdleLookAtOthers = 1;//Randomly looks at other players/bots when not doing anything else
	    hIdleSpam = 0;//Makes them spam click and spam hammer/spraycan
	  hSpasticLook = 1;//Makes them look around their environment a bit more.
	hEmote = 1;
};

function Pedo_Spawn() {
	// spawning
	
if(isobject($pedo))
      $pedo.delete();
   $pedo = new AIPlayer()
   {
      datablock = PlayerPedo;
      maxPitchSpeed = 40;
      maxYawSpeed = 40;
   };
   // skin
   $pedo.hidenode("ALL");
   $pedo.unhidenode("headSkin");
   $pedo.setnodecolor("headSkin", "0.4 0 0 1");
   $pedo.unhidenode("lhand");
   $pedo.setnodecolor("lhand", "0.4 0 0 1");
   $pedo.unhidenode("rhand");
   $pedo.setnodecolor("rhand", "0.4 0 0 1");
   $pedo.unhidenode("chest");
   $pedo.setnodecolor("chest", "0.4 0 0 1");
   $pedo.unhidenode("larm");
   $pedo.setnodecolor("larm", "0.4 0 0 1");
   $pedo.unhidenode("rarm");
   $pedo.setnodecolor("rarm", "0.4 0 0 1");
   $pedo.unhidenode("pants");
   $pedo.setnodecolor("pants", "0.4 0 0 1");
   $pedo.unhidenode("lshoe");
   $pedo.setnodecolor("lshoe", "0.4 0 0 1");
   $pedo.unhidenode("rshoe");
   $pedo.setnodecolor("rshoe", "0.4 0 0 1");
   // face
   $pedo.setfacename("memePBear");
   return $pedo;
}
