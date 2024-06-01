/** @param {NS} ns */
export async function main(ns) {
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
      //let targetInfo = "Server Name: " + currentTarget.name + "         Min. Hacking Level: " + currentTarget.level;
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

  ns.write("targetsAndLevel.txt", targetsAndLevelSorted.toString(), "w");
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