/** @param {NS} ns */
export async function main(ns) {
  ns.killall("home", true);

  // sanatize the list of servers
  ns.run("sanitizeHackHosts.js");
  await ns.sleep(100);

  // populate the list in case it is empty
  ns.run("populateHackHosts.js");
  await ns.sleep(100);

  for (let i = 0; i < 1; i++) {
    // execute the remoteHack.js script
    // multiple times to ensure the server
    // with the highest requirements is chosen
    ns.run("remoteHack.js");
    await ns.sleep(450);
  }

  let playerHackLevel = ns.getHackingLevel();
  let chosenHackTarget = "n00dles";

  let ironGymHackLevel = ns.getServerRequiredHackingLevel("iron-gym");
  let theHubHackLevel = ns.getServerRequiredHackingLevel("the-hub");
  let milleniumFitnessHackLevel = ns.getServerRequiredHackingLevel("millenium-fitness");
  let megacorpHackLevel = ns.getServerRequiredHackingLevel("megacorp");

  if (playerHackLevel >= ironGymHackLevel && ns.hasRootAccess("iron-gym")) {
    chosenHackTarget = "iron-gym";
  }

  if (playerHackLevel >= theHubHackLevel && ns.hasRootAccess("the-hub")) {
    chosenHackTarget = "the-hub";
  }

  if (playerHackLevel >= milleniumFitnessHackLevel && ns.hasRootAccess("millenium-fitness")) {
    chosenHackTarget = "millenium-fitness";
  }

  if (playerHackLevel >= megacorpHackLevel && ns.hasRootAccess("megacorp")) {
    chosenHackTarget = "megacorp";
  }

  // exec the hack.js script on home using the target
  let homeMaxRam = ns.getServerMaxRam("home");
  let hackRam = ns.getScriptRam("hack.js", "home");
  
  // set the max thread count
  let percentThreadsToUse = .70;
  let homeThreads = Math.floor((homeMaxRam / hackRam) * percentThreadsToUse);

  ns.exec("hack.js", "home", homeThreads, chosenHackTarget);

  // if the Tor server is not owned, buy it
  /** if (!ns.hasTorRouter()) {
   * when it's time, extract this into 
   * its own script and call it here
   * to lessen the ram requirements here
   * ns.killall("home", true);
   * ns.run("torPurchaserz.js");
    ns.singularity.purchaseTor();
  } */
  
  // if hacknet manage not running, start it
  if (!ns.isRunning("manageHacknet.js", "home")) {
    ns.exec("manageHacknet.js", "home");
  }
}