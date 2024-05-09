/** @param {NS} ns */
export async function main(ns) {
  // used to kill all active scripts

  // list of servers on which hack scripts can run
  const servers = ns.read("hackHosts.txt").split(", ");

  for (let i = 0; i < servers.length; i++) {
    // for each server
    let server = servers[i];

    // kill all scripts
    ns.killall(server);
  }
}