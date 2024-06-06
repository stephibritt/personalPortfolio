/** @param {NS} ns */
export async function main(ns) {
  let portNumber = ns.args[0];
  if (portNumber == undefined) {
    // if no port number is defined, set to 1
    portNumber = 1;
  }

  let hackTargets = ns.read("hackHosts.txt").split(", ");

  let playerHackLevel = ns.getHackingLevel();

  let targetsAndMoney = {};

  for (let i = 0; i < hackTargets.length; i++) {
    let currentTarget = hackTargets[i];

    let currentTargetHackLevel = ns.getServerRequiredHackingLevel(currentTarget);

    if (!(currentTargetHackLevel <= playerHackLevel)) {
      continue;
    }

    if (!(ns.hasRootAccess(currentTarget))) {
      continue;
    }

    if (ns.getServerMaxMoney(currentTarget) == 0) {
      continue;
    }

    targetsAndMoney[currentTarget] = ns.getServerMaxMoney(currentTarget);
  }

  let targetsAndMoneySortable = Object.fromEntries(
    Object.entries(targetsAndMoney).sort(([, a], [, b]) => b - a)
  );

  let targetsAndMoneyFinalSort = [];

  for (let target in targetsAndMoneySortable) {
    targetsAndMoneyFinalSort.push(target)
  }

  let mostLucrativeTarget = targetsAndMoneyFinalSort[0];

  //if mostLucrativeTarget is undefined, default to n00dles
  if (mostLucrativeTarget == undefined) {
    mostLucrativeTarget = "n00dles";
  }

  // send the hack target to a port
  ns.clearPort(portNumber)
  ns.writePort(portNumber, mostLucrativeTarget);
}