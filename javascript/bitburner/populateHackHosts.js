/** @param {NS} ns */
export async function main(ns) {
  // list of servers to not host a hack
  let ignoreList = ns.read("ignoreServers.txt").split(", ");

  // get the most current list of hack hosts from home
  ns.scp("hackHosts.txt", ns.getHostname(), "home");

  // ensure hackHosts.txt has at least one known good value
  if (ns.read("hackHosts.txt").split(", ") == "") {
    ns.write("hackHosts.txt", "n00dles", "w");
  }

  // concatinate the list of known hacking hosts
  ignoreList = ignoreList.concat(ns.read("hackHosts.txt").split(", "));
  
  // scan for connected servers
  let neighbors = ns.scan();

  // for each item of neighbors
  // if item in returned list is not in ignore list
  // write it to the hackHosts.txt file
  for (let i = 0; i < neighbors.length; i++) {
    if (!ignoreList.includes(neighbors[i])) {
      ns.write("hackHosts.txt", ", " + neighbors[i], "a");
    }
  }

  // list of hacking hosts
  let hackHosts = ns.read("hackHosts.txt").split(", ");

  // sort the list
  hackHosts.sort();

  // overwrite the comma separated list in alphabetical order
  ns.write("hackHosts.txt", hackHosts.join(", "), "w");

  // overwrite the list on "home" with the update
  ns.scp("hackHosts.txt", "home");
}