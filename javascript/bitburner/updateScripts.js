/** @param {NS} ns */
export async function main(ns) {
  // used to update the chosen list of scripts.
  // files on the target server.
  const servers = ns.scan();

  // initialize a list of the desired files
  const files = ns.read("filesToCopy.txt").split(", ");

  // for each item in the list...
  let i = 0;
  let serversLen = servers.length;

  for (i; i < serversLen; i++) {
    // take the hostname from the list of servers
    let hostname = servers[i];

    if (ns.hasRootAccess(hostname)) {
      // kill all processesns.
      await ns.killall(hostname);

      // for each file in the list...
      let filesLen = files.length;
      let j = 0;

      for (j; j < filesLen; j++) {
        // get the file name
        let file = files[j];

        // copy the file, which overwrites
        ns.scp(file, hostname, "home");
      }

      ns.print("Files updated successfully.");
    } else {
      ns.print("No root access on " + hostname + ".");
    }
  }
}