/** @param {NS} ns */
export async function main(ns) {
  // Defines the "target server", which is the server
  // that we're going to hack using this script
  const portNumber = 1;
  const portWriteThreads = 1;

  ns.clearPort(portNumber)

  ns.exec("determineHackTarget.js", "home", portWriteThreads, portNumber);

  await ns.sleep(3)
  
  let target = ns.readPort(portNumber);

  // a list of servers that we do not want to hack or open ports on
  const ignoreServers = ns.read("ignoreServers.txt").split(", ");
  const purchasedServers = ns.read("ownedServers.txt").split(", ");

  ns.exec("populateHackHosts.js", "home");

  await ns.sleep(3)

  // a list of all servers connected to the host
  var hackHosts = ns.read("hackHosts.txt").split(", ");

  for (let i = 0; i < hackHosts.length; i++) {
    // define which server to work on
    let hackHost = hackHosts[i];

    // get root access to the hackHosts
    // if the server is not in the ignore list...
    if ((!ignoreServers.includes(hackHost)) && (!purchasedServers.includes(hackHost))) {

      // try to open all ports, if the .exe exists
      if (ns.fileExists("BruteSSH.exe", "home")) {
        ns.brutessh(hackHost);
      }

      if (ns.fileExists("FTPCrack.exe", "home")) {
        ns.ftpcrack(hackHost);
      }

      if (ns.fileExists("relaySMTP.exe", "home")) {
        ns.relaysmtp(hackHost);
      }

      if (ns.fileExists("HTTPWorm.exe", "home")) {
        ns.httpworm(hackHost);
      }

      if (ns.fileExists("SQLInject.exe", "home")) {
        ns.sqlinject(hackHost);
      }

      let isRootAccessable = ns.hasRootAccess(hackHost);

      // if no root access, attempt to gain
      if (!(isRootAccessable)) {

        try {
          ns.nuke(hackHost);
        } catch {
          continue;
        }
      }
    }

    if (!ignoreServers.includes(hackHost)) {
      // kill all current scripts on neighbor
      ns.killall(hackHost);

      // initialize a list of the desired files
      let filesToCopy = ns.read("filesToCopy.txt").split(", ");

      // copy files to the host
      ns.scp(filesToCopy, hackHost, "home");

      ns.exec("populateHackHosts.js", hackHost);

      await ns.sleep(3)

      ns.killall(hackHost);

      let serverMaxRam = ns.getServerMaxRam(hackHost);
      let scriptRam = ns.getScriptRam("hack.js", "home");

      // set the max thread count
      let threads = Math.floor(serverMaxRam / scriptRam);

      if (threads >= 1) {
        // tell the neighbor to hack the target with threads
        ns.exec("hack.js", hackHost, threads, target);
      }
    }
  }
}