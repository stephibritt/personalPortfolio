/** @param {NS} ns */
export async function main(ns) {
  const MAXLEVELUPGRADES = 200;
  const MAXRAMUPGRADES = 64;
  const MAXCOREUPGRADES = 16;
  const MAXHACKNETNODES = ns.hacknet.maxNumNodes();

  ns.disableLog("disableLog");
  ns.disableLog("getServerMoneyAvailable");
  ns.disableLog("sleep");

  while (true) {
    let playerMoney = ns.getServerMoneyAvailable("home");

    let numberOfNodes = ns.hacknet.numNodes();

    let nodePurchaseCost = ns.hacknet.getPurchaseNodeCost();

    if ((numberOfNodes == 0) && (nodePurchaseCost <= playerMoney)) {
      ns.hacknet.purchaseNode();
    }

    let costOfLevelUpgrade = 1000000000000;
    let costOfRamUpgrade = 1000000000000;
    let costOfCoreUpgrade = 1000000000000;
    let nodeToUpgrade;
    let partToUpgrade;
    let timesToUpgrade = 1;

    for (let i = 0; i < numberOfNodes; i++) {

      let nodeLevelUpgradeCost = ns.hacknet.getLevelUpgradeCost(i, timesToUpgrade);
      let nodeRamUpgradeCost = ns.hacknet.getRamUpgradeCost(i, timesToUpgrade);
      let nodeCoreUpgradeCost = ns.hacknet.getCoreUpgradeCost(i, timesToUpgrade);

      let costs = [nodeRamUpgradeCost, nodeCoreUpgradeCost, nodeLevelUpgradeCost];

      costs.sort(function (a, b) {
        return a - b;
      });

      if (nodeLevelUpgradeCost < costOfLevelUpgrade) {
        if (nodeLevelUpgradeCost != 0) {
          costOfLevelUpgrade = nodeLevelUpgradeCost;
          nodeToUpgrade = i;
          if (nodeLevelUpgradeCost == costs[0]) {
            partToUpgrade = "level";
          }
        }
      }

      if (nodeRamUpgradeCost < costOfRamUpgrade) {
        if (nodeRamUpgradeCost != 0) {
          costOfRamUpgrade = nodeRamUpgradeCost;
          nodeToUpgrade = i;
          if (nodeRamUpgradeCost == costs[0]) {
            partToUpgrade = "ram";
          }
        }
      }

      if (nodeCoreUpgradeCost < costOfCoreUpgrade) {
        if (nodeCoreUpgradeCost != 0) {
          costOfCoreUpgrade = nodeCoreUpgradeCost;
          nodeToUpgrade = i;
          if (nodeCoreUpgradeCost == costs[0]) {
            partToUpgrade = "cores";
          }
        }
      }
    }

    switch (partToUpgrade) {
      case "level":
        let nodeLevelUpgradeCost = ns.hacknet.getLevelUpgradeCost(nodeToUpgrade, timesToUpgrade);

        if (nodeLevelUpgradeCost < nodePurchaseCost) {
          if (nodeLevelUpgradeCost <= playerMoney) {
            ns.hacknet.upgradeLevel(nodeToUpgrade, timesToUpgrade);
          }
        } else {
          if (nodePurchaseCost <= playerMoney) {
            if (numberOfNodes < MAXHACKNETNODES) {
              ns.hacknet.purchaseNode();
            }
          }
        }

        break;
      case "ram":
        let nodeRamUpgradeCost = ns.hacknet.getRamUpgradeCost(nodeToUpgrade, timesToUpgrade);

        if (nodeRamUpgradeCost < nodePurchaseCost) {
          if (nodeRamUpgradeCost <= playerMoney) {
            ns.hacknet.upgradeRam(nodeToUpgrade, timesToUpgrade);
          }
        } else {
          if (nodePurchaseCost <= playerMoney) {
            if (numberOfNodes < MAXHACKNETNODES) {
              ns.hacknet.purchaseNode();
            }
          }
        }

        break;
      case "cores":
        let nodeCoreUpgradeCost = ns.hacknet.getCoreUpgradeCost(nodeToUpgrade, timesToUpgrade);

        if (nodeCoreUpgradeCost < nodePurchaseCost) {
          if (nodeCoreUpgradeCost <= playerMoney) {
            ns.hacknet.upgradeCore(nodeToUpgrade, timesToUpgrade);
          }
        } else {
          if (nodePurchaseCost <= playerMoney) {
            if (numberOfNodes < MAXHACKNETNODES) {
              ns.hacknet.purchaseNode();
            }
          }
        }

        break;
    }
    await ns.sleep(3);
  }
}