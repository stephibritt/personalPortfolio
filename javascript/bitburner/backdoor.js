/** @param {NS} ns */
export async function main(ns) {
  let hackHosts = ns.read("hackHosts.txt").split(", ");
  let playerHackLevel = ns.getHackingLevel()

  for (let i = 0; i < hackHosts.length; i++) {
    let host = hackHosts[i];

    let hostHackLevel = ns.getServerRequiredHackingLevel(host)

    if (hostHackLevel <= playerHackLevel) {
      ns.killall();
      await ns.singularity.installBackdoor()
    }
  }
}