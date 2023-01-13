# BidderGUI
![image](https://user-images.githubusercontent.com/62039630/212264185-612a0683-334a-45f1-b7ea-1345aefc6da8.png)

Easy to use HSD Bidder built on C# .net framework  
This version only works with HSD v5 or greater.  
If you have below this version use [this release](https://github.com/Nathanwoodburn/HSDBidderGUI/releases/tag/1.1.0.0)

To use this you need to be running a HSD node.  
Bob comes with this node built in.

The API key is set using the HSD flag `--api-key=<key>`.  
Bob automatically generates an API key for you. This can be obtained from Bob wallet in Settings > wallet > API Key.

The wallet name and passphrase are the same as you set on Bob or HSD.

## Instructions
1. Enter API key
2. Enter wallet name and password.
3. Test your connection to the HSD node. To connect you need to be running HSD (or Bob Wallet).
4. Add domains either using the text box or by importing a text file. (See example-domains.txt for formatting)
5. Select mode
   1. OPEN: Opens domains for auction
   2. BID: Send bids with specified bid and blind  
        • Set bid and blind in HNS values
   3. REVEAL: Reveal bids
   4. REDEEM: Redeems lost auction bids
   5. UPDATE: Not implemented yet
   6. TRANSFER: Not implemented yet
   7. FINALIZE: Not implemented yet
6. Set batching settings
7. Press start to begin batching transactions
8. Pause at any time by pressing Stop

## Settings
- Batch size
This sets how many domains are sent in each transaction. If you send too many the transaction might fail to send.
- Batch interval
This sets how many minutes are between sending batch transactions. If you set this too low the transactions might fail to send.
