// It's poorly scripted,
// You can help me UwU.

$started = false;
$schedules = "";
$schedules2 = "";
$pedo = "";

function AppearPedo()
{
 $pedo = Pedo_Spawn();
 $pedo.settransform("0,0,25");
 centerprintall("LET'S GET SOME LOLI!!!", 3);
}

function EndPedo()
{
 centerprintall("OK, THAT'S ENOUGH. SEE YOU SPACE, COWBOY!", 3);
 $pedo.delete();
 roundEnd();
}

function roundStart() {
 $started = true;
 $schedules = schedule(30*1000, AppearPedo, "");
 $schedules2 = schedule(500*1000, EndPedo, "");
}

function roundEnd() 
{
 centerprintall("Re-Starting Round...", 5);
 $schedules = schedule(5, roundStart, "");
}

package RAFPB 
{
 function GameConnection::spawnPlayer(%this) 
 { 
  Parent::spawnPlayer(%this);
  if ($started == false) 
  {
   roundStart();
  }
 }
};
activatepackage(RAFPB);