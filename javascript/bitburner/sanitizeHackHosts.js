/** @param {NS} ns */
export async function main(ns) {
  /** create a regular expression which will find
  any server with my naming scheme, which will
  then be used to remove my servers from the list
  of known hack hosts */

  /** begin with ", " so that the extra separators
  are accounted for even if there is a server name
  that follows this pattern at the end of the string,
  it will be caught and the string will be terminated.
  account for a four-digit number (larger than needed),
  both GB and TB, -serv-, then a three-digit number */

  const serverRegularExpression =
    /, ([0-9]|)([0-9]|)([0-9]|)([0-9]|)(.|)(.|)-serv-([0-9]|)([0-9]|)([0-9]|)/ig;

  // pull the list of hack hosts
  let hackHosts = ns.read("hackHosts.txt");

  // sanitize my servers
  let sanitizedHackHosts = hackHosts.replace(serverRegularExpression, "");

  // overwrite the file with the sanitized string
  ns.write("hackHosts.txt", sanitizedHackHosts, "w");
}