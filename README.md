# BidderGUI

Easy to use HSD Bidder built on C# .net framework  
**WARNING YOU NEED TO REMEMBER WHAT BID/BLIND YOU ADDED**  
If you don't you might not be able to reveal your bid.

## Instructions
1. Create a file for domains to bid on.  
    This file should contain a domain per line. They should not contain any trailing slash or dot.  
    For example look at example-domains.txt
2. Select file in GUI app.
3. Check in list to make sure all domains are selected
4. Set bid and blind in HNS values (If using BID mode)
5. Set API key and Wallet name
6. Test using the Test button. (It should spit out your accounts. This Gui only uses default account at the moment)
7. Add passphrase
8. Set transaction sending interval (defaul 1000 ms)
9. Set transaction mode
   1. OPEN: Opens domains
   2. BID: Sends bid with specified bid and blind
   3. REVEAL: Reveals bid
   4. REDEEM: Redeems lost auction bids
10. Press start to begin sending bids