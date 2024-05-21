/** @param {NS} ns */
export async function main(ns) {
  let serverToRename = ns.args[0];
  let newServerName = ns.args[1];
  
  ns.renamePurchasedServer(serverToRename, newServerName);
}