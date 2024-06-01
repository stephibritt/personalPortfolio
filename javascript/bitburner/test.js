/** @param {NS} ns */
export async function main(ns) {
  let infiltrations = ns.infiltration.getPossibleLocations();
  let infiltrationTargets = [];

  for (let i = 0; i < infiltrations.length; i++) {
    let infiltrationTarget = infiltrations[i];

    infiltrationTargets.push(ns.infiltration.getInfiltration(infiltrationTarget.name));
    
    infiltrationTargets.sort()
  }
  
  ns.print(infiltrationTargets[0].location.name + " " + infiltrationTargets[0].difficulty);

  
}