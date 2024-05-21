/** @param {NS} ns */
export async function main(ns) {
  let portNumber = ns.args[0];
  if (portNumber == undefined) {
    // if no port number is defined, set to 1
    portNumber = 1;
  }

  let hackTarget;
  let hackLevelSentinel = 0;

  let playerHackingLevel = ns.getHackingLevel();

  var hackHosts = ns.read("hackHosts.txt").split(", ");

  for (let i = 0; i < hackHosts.length; i++) {
    // define the potential server's stats
    let potentialTarget = hackHosts[i];
    let serverHackLevel = ns.getServerRequiredHackingLevel(potentialTarget);

    /* define the sentinel values to choose a server
    the server will be chosen if the hack level is
    lower than the players hack level and higher than the hack
    level sentinel. This will ensure that the chosen target is 
    viable to hack and as close to the player level as possible. 
    Must have root access as well*/


    if ((serverHackLevel <= playerHackingLevel) && (serverHackLevel >= hackLevelSentinel) &&
      ns.hasRootAccess(potentialTarget)) {
      hackLevelSentinel = serverHackLevel;
      hackTarget = potentialTarget;
    }
  }

  // send the hack target to a port
  ns.clearPort(portNumber)
  ns.writePort(portNumber, hackTarget);
}