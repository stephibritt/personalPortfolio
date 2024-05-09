/** @param {NS} ns */
export async function main(ns) {
  // Defines the "target server", which is the server
  // that we're going to hack.
  const target = ns.args[0];

  // a list of servers that we do not want to hack or open ports on
  const ignoreServers = ns.read("ignoreServers.txt").split(", ");
  const purchasedServers = ns.read("ownedServers.txt").split(", ");

  // a list of all servers connected to the host
  const hackHosts = ns.read("hackHosts.txt").split(", ");

  for (let i = 0; i < hackHosts.length; i++) {
    // define which server to work on
    let hackHost = hackHosts[i];

    // get root access to the hackHosts
    // if the server is not in the ignore list...
    if ((!ignoreServers.includes(hackHost)) && (!purchasedServers.includes(hackHost))) {
      let isRootAccessable = ns.hasRootAccess(hackHost);

      // if no root access, attempt to gain
      if (!(isRootAccessable)) {
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

        try {
          ns.nuke(hackHost);
        } catch {
          continue;
        }
      }
    }


    if (!ignoreServers.includes(hackHost)) {
      // kill all current scripts on neighbor
      ns.killall(hackHost)

      // initialize a list of the desired files
      let filesToCopy = ns.read("filesToCopy.txt").split(", ");

      // copy files to the host
      ns.scp(filesToCopy, hackHost, "home");

      let scriptRam = ns.getScriptRam("hack.js", "home");

      // set the max thread count
      let threads = Math.floor(ns.getServerMaxRam(hackHost) / scriptRam);

      // tell the neighbor to hack the target with threads
      ns.exec("hack.js", hackHost, threads, target);
    }
  }
}