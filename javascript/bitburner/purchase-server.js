/** @param {NS} ns */
export async function main(ns) {
  // How much RAM each purchased server will have.
  const ram = ns.args[0];

  // the target for the server to begin hacking
  const hackTarget = ns.args[1];

  // Iterator we'll use for our loop
  let i = 0;

  // Continuously try to purchase servers until we've reached the maximum
  // amount of servers
  while (i < ns.getPurchasedServerLimit()) {
    // Check if we have enough money to purchase a server
    ns.print(ns.getPurchasedServerCost(ram));
    
    if (ns.getServerMoneyAvailable("home") > ns.getPurchasedServerCost(ram)) {
      // If we have enough money, then:
      //  1. Purchase the server
      //  2. Copy our hacking script onto the newly-purchased server
      //  3. Run our hacking script on the newly-purchased server with 3 threads
      //  4. Increment our iterator to indicate that we've bought a new server
      let hostname = "serv-" + i;

      ns.purchaseServer(hostname, ram);

      ns.write("ownedServers.txt", ", " + hostname, "a");

      let threads = Math.floor(ns.getServerMaxRam(hostname) / ns.getScriptRam("hack.js", "home"));

      ns.scp("hack.js", hostname);
      ns.exec("hack.js", hostname, threads, hackTarget);

      ++i;
    }
    //Make the script wait for a second before looping again.
    //Removing this line will cause an infinite loop and crash the game.
    await ns.sleep(1000);
  }

  ns.exit();
}