/** @param {NS} ns */
export async function main(ns) {
  // Defines the "target server", which is the server
  // that we're going to hack.
  const target = ns.args[0];

  // a list of servers that we do not want to hack or open ports on
  const ignoreServers = ns.read("ignoreServers.txt").split(", ");
  const purchasedServers = ns.read("ownedServers.txt").split(", ");

  // a list of all servers connected to the host
  const neighbors = ns.scan();

  for (let i = 0; i < neighbors.length; i++) {
    // define which server to work on
    let neighborServer = neighbors[i];

    // get root access to the neighbors
    // if the server is not in the ignore list...
    if ((!ignoreServers.includes(neighborServer)) && (!purchasedServers.includes(neighborServer))) {
      // try to open all ports, if the .exe exists
      if (ns.fileExists("BruteSSH.exe", "home")) {
        ns.brutessh(neighborServer);
      }

      if (ns.fileExists("FTPCrack.exe", "home")) {
        ns.ftpcrack(neighborServer);
      }

      if (ns.fileExists("relaySMTP.exe", "home")) {
        ns.relaysmtp(neighborServer);
      }

      if (ns.fileExists("HTTPWorm.exe", "home")) {
        ns.httpworm(neighborServer);
      }

      if (ns.fileExists("SQLInject.exe", "home")) {
        ns.sqlinject(neighborServer);
      }

      // if no root access, nuke it
      if ((!ns.hasRootAccess(neighborServer))) {
        ns.nuke(neighborServer);
      }
    }

    if (!ignoreServers.includes(neighborServer)) {
      // kill all current scripts on neighbor
      ns.killall(neighborServer)
      
      // set the max thread count
      let threads = Math.floor(ns.getServerMaxRam(neighborServer) / ns.getScriptRam("hack.js", "home"));
      
      // initialize a list of the desired files
      let filesToCopy = ns.read("filesToCopy.txt").split(", ");
      
      // copy files to the neighbor
      ns.scp(filesToCopy, neighborServer, "home");
      
      // tell the neighbor to hack the target with threads
      ns.exec("hack.js", neighborServer, threads, target);
    }
  }
}