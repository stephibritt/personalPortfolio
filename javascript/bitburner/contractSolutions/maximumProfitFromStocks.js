/** @param {NS} ns */
export async function main(ns) {
  /** You are given the following array of stock prices (which are numbers) where the i-th element represents the stock price on day i:

  132,156,106,191,198,200,122,45,97,154,189,187,184,40

  Determine the maximum possible profit you can earn using as many transactions   as you'd like. A transaction is defined as buying and then selling one share of   the stock. Note that you cannot engage in multiple transactions at once. In     other words, you must sell the stock before you buy it again.

  If no profit can be made, then the answer should be 0 */

  // get the comma separated list of stock prices
  let stockPrices = ns.args[0];

  while (stockPrices == undefined || stockPrices == "") {
    stockPrices = await ns.prompt("Please input the stock prices:", { type: "text" })
  }

  // split the stock prices into an array
  stockPrices = stockPrices.split(",");

  let maximumProfit = 0;
  let heldStock = stockPrices[0];

  for (let i = 0; i < stockPrices.length; i++) {
    
  }

  // print the output and call the tail window befor exiting
  ns.print("Maximum Profit: " + maximumProfit);
  ns.print(stockPrices);
  ns.tail();
}