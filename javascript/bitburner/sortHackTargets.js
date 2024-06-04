/** @param {NS} ns */
export async function main(ns) {
  let sortMode = "Hacking Level";

  //sortMode = await ns.prompt("Please choose how to sort the list of servers:", { type: "select", choices: ["Hacking Level", "Max Money"] });

  ns.run("sanitizeHackHosts.js");
  
  if (sortMode == "Max Money") {
    let targetsSorted = await sortByMoney(ns);
    ns.write("targetsSorted.txt", targetsSorted.toString().replaceAll(",", "\n"), "w");
  } else {
    let targetsSorted = await sortByLevel(ns);
    ns.write("targetsSorted.txt", targetsSorted.toString().replaceAll(",", "\n"), "w");
  }
}

async function sortByLevel(ns) {
  let hackTargets = ns.read("hackHosts.txt").split(", ");
  let targetsAndLevel = [];

  for (let i = 0; i < hackTargets.length; i++) {
    let currentTarget = hackTargets[i];

    let currentTargetHackLevel = ns.getServerRequiredHackingLevel(currentTarget)

    let targetToAdd = { name: currentTarget, level: currentTargetHackLevel };

    targetsAndLevel.push(targetToAdd)
  }

  let targetsAndLevelSorted = [];
  let levelThreshold = 0;
  while (levelThreshold < 3000) {
    for (let i = 0; i < targetsAndLevel.length; i++) {
      let currentTarget = targetsAndLevel[i];
      let targetInfo = `Server Name: ${currentTarget.name}`.padding(35) + `Min. Hack Level: ${currentTarget.level}`;

      if (targetsAndLevelSorted.includes(targetInfo)) {
        continue;
      }

      if (currentTarget.level <= levelThreshold) {
        targetsAndLevelSorted.push(targetInfo);
      }
    }
    levelThreshold++;
  }

  return targetsAndLevelSorted;
}

async function sortByMoney(ns) {
  let hackTargets = ns.read("hackHosts.txt").split(", ");
  let targetsAndMoney = [];

  for (let i = 0; i < hackTargets.length; i++) {
    let currentTarget = hackTargets[i];

    let currentTargetMaxMoney = ns.getServerMaxMoney(currentTarget);

    let targetToAdd = { name: currentTarget, maxMoney: currentTargetMaxMoney };

    targetsAndMoney.push(targetToAdd)
  }

  let targetsAndMoneySorted = [];
  let moneyThreshold = 1;
  //100000000000000
  while (moneyThreshold < 1000000000000) {
    for (let i = 0; i < targetsAndMoney.length; i++) {
      let currentTarget = targetsAndMoney[i];
      let targetInfo = `Server Name: ${currentTarget.name}`.padding(35) + `Max Money: ${currentTarget.maxMoney}`;

      if (targetsAndMoneySorted.includes(targetInfo)) {
        continue;
      }

      if (currentTarget.maxMoney <= moneyThreshold) {
        targetsAndMoneySorted.push(targetInfo);
      }
    }
    moneyThreshold *= 10;
  }

  return targetsAndMoneySorted;
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