/** @param {NS} ns */
export async function main(ns) {
  // Defines the "target server", which is the server
  // that we're going to hack.
  const target = ns.args[0];

  const ignoreServers = ns.read("ignoreServers.txt").split(", ");
  const purchasedServers = ns.read("ownedServers.txt").split(", ");

  // do not hack my own servers
  if ((!ignoreServers.includes(target)) && (!purchasedServers.includes(target))) {
    // Defines how much money a server should have before we hack it
    // In this case, it is set to the maximum amount of money.
    const moneyThresh = ns.getServerMaxMoney(target);

    // Defines the maximum security level the target server can
    // have. If the target's security level is higher than this,
    // we'll weaken it before doing anything else
    const securityThresh = ns.getServerMinSecurityLevel(target);



    // try to open all ports, if the .exe exists
    if (ns.fileExists("BruteSSH.exe", "home")) {
      ns.brutessh(target);
    }

    if (ns.fileExists("FTPCrack.exe", "home")) {
      ns.ftpcrack(target);
    }

    if (ns.fileExists("relaySMTP.exe", "home")) {
      ns.relaysmtp(target);
    }

    if (ns.fileExists("HTTPWorm.exe", "home")) {
      ns.httpworm(target);
    }

    if (ns.fileExists("SQLInject.exe", "home")) {
      ns.sqlinject(target);
    }

    let isRootAccessable = ns.hasRootAccess(target);
    
    // if no root access, attempt to gain
    if (!(isRootAccessable)) {
      try {
        ns.nuke(target);
      } catch {
        ns.print("Unable to gain root access on " + target);
      }
    }

    // Infinite loop that continously hacks/grows/weakens the target server
    // if root access is held
    if (isRootAccessable) {
      while (true) {
        if (ns.getServerSecurityLevel(target) > securityThresh) {
          // If the server's security level is above our threshold, weaken it
          await ns.weaken(target);
        } else if (ns.getServerMoneyAvailable(target) < moneyThresh) {
          // If the server's money is less than our threshold, grow it
          await ns.grow(target);
        } else {
          // Otherwise, hack it
          await ns.hack(target);
        }
      }
    }
  }
}