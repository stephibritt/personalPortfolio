/** @param {NS} ns */
export async function main(ns) {
  let sortMode = "Hacking Level";

  sortMode = await ns.prompt("Please choose how to sort the list of servers:", { type: "select", choices: ["Hacking Level", "Max Money"] });

  ns.run("sanitizeHackHosts.js");

  await ns.sleep(50);

  if (sortMode == "Max Money") {
    let targetsSorted = await sortByMoney(ns);
    ns.write("targetsSortedByMaxMoney.txt", targetsSorted.toString().replaceAll(",", "\n"), "w");
  } else {
    let targetsSorted = await sortByLevel(ns);
    ns.write("targetsSortedByHackLevel.txt", targetsSorted.toString().replaceAll(",", "\n"), "w");
  }
}

async function sortByLevel(ns) {
  let hackTargets = ns.read("hackHosts.txt").split(", ");
  let targetsAndLevel = {};

  for (let i = 0; i < hackTargets.length; i++) {
    let currentTarget = hackTargets[i];

    let targetToAdd = new HackTarget(currentTarget, ns);

    targetsAndLevel[targetToAdd.name] = targetToAdd.requiredHackingLevel;
  }

  let targetsAndLevelSortable = Object.fromEntries(
    Object.entries(targetsAndLevel).sort(([, a], [, b]) => a - b)
  );

  let targetsFinalLevelSort = [];

  for (let target in targetsAndLevelSortable) {
    targetsFinalLevelSort.push(new HackTarget(target, ns).toString())
  }

  return targetsFinalLevelSort;
}

async function sortByMoney(ns) {
  let hackTargets = ns.read("hackHosts.txt").split(", ");
  let targetsAndMoney = {};

  for (let i = 0; i < hackTargets.length; i++) {
    let currentTarget = hackTargets[i];

    let targetToAdd = new HackTarget(currentTarget, ns);

    targetsAndMoney[targetToAdd.name] = targetToAdd.maximumMoney;
  }

  let targetsAndMoneySortable = Object.fromEntries(
    Object.entries(targetsAndMoney).sort(([, a], [, b]) => a - b)
  );

  let targetsFinalMoneySort = [];

  for (let target in targetsAndMoneySortable) {
    targetsFinalMoneySort.push(new HackTarget(target, ns).toString())
  }

  return targetsFinalMoneySort;
}

function HackTarget(serverName, ns) {
  this.name = serverName;
  this.requiredHackingLevel = ns.getServerRequiredHackingLevel(serverName);
  this.maximumMoney = ns.getServerMaxMoney(serverName);

  this.writeToFile = function (fileName = "targetsSorted.txt") {
    this.fileName = fileName;

    ns.write(fileName, this.toString(), "a")
  }

  this.toString = function () {
    return `Server Name: ${this.name}`.padding(38) + `Hack Level: ${this.requiredHackingLevel}`.padding(25) + `Max Money: ${this.maximumMoney}`;
  };
}

/**
 * object.padding(padding, paddingCharacter)
 * Transform the string object to string of the actual width filling by the padding character (by default ' ')
 * Negative value of width means left padding, and positive value means right one
 *
 * @param       padding  Width of string padding
 * @param       paddingCharacter  Padding chacracter (by default, ' ')
 * @return      string
 * @access      public
 */
String.prototype.padding = function (padding, paddingCharacter) {
  let inputString = this.valueOf();

  if (Math.abs(padding) <= inputString.length) {
    return inputString;
  }

  let maxLength = Math.max((Math.abs(padding) - this.length) || 0, 0);

  let pad = Array(maxLength + 1).join(String(paddingCharacter || ' ').charAt(0));

  return (padding < 0) ? pad + inputString : inputString + pad;
};