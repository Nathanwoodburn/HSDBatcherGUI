# BidderGUI
![image](https://github.com/Nathanwoodburn/HSDBidderGUI/blob/master/ledgerscreenshot.png)

Easy to use HSD Bidder built on C# .net framework  
This version only works with HSD v5 or greater.  
If you have below this version use [this release](https://github.com/Nathanwoodburn/HSDBidderGUI/releases/tag/1.1.0.0)

To use this you need to be running a HSD node (either Full or SPV).  
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
   5. REGISTER: Not implemented yet
   6. RENEW: Renews domains
   7. UPDATE: Not implemented yet
   8. TRANSFER: Not implemented yet
   9. FINALIZE: Not implemented yet
6. Set batching settings
7. Press start to begin batching transactions
8. Pause at any time by pressing Stop

## Settings
- Batch size
This sets how many domains are sent in each transaction. If you send too many the transaction might fail to send.
- Batch interval
This sets how many minutes are between sending batch transactions. If you set this too low the transactions might fail to send.
- Log length
This sets how many lines of log are shown in the log box. If you set this too high the log box might become slow to update (and in extreme cases cause crashing).
- Skip Errors
This will continue to send transactions even if one fails. This is useful if you have a large number of domains and one fails to send.

## Ledger
1. Clone the HSD ledger repo and build it  
`git clone https://github.com/handshake-org/hsd-ledger.git`  
`cd hsd-ledger`  
`npm install`

2. Replace the `hsd-ledger` file in the `bin` folder with [this file](hsd-ledger). This file adds the sendraw transaction command required to send a batch.
3. Open the HSD GUI and fill in your API key, wallet name and password. Also check the `Use Ledger` box.
4. Create a file in the `hsd-ledger` folder called `names.txt` and paste in the domains you want to send. Each domain should be separated by a `,` in a single line. eg `domain1,domain2,domain3`
5. Send a batch like you would normally. Press the Start and wait for the log to say `Saved to clipboard.` then press Stop (as you now need to sign and send this transaction).
6. Create a file in the `hsd-ledger` folder called `batch.json` and paste the contents of the clipboard into this file. This will be the transaction you tell your ledger to sign.
7. Connect your ledger to your computer and open the Handshake app.
8. Run the command `node bin/hsd-ledger sendraw --http-host 127.0.0.1 --api-key=<your-api-key> -w <your-wallet-name-as-shown-in-bob> batch.json names.txt` and follow the instructions on your ledger to sign the transaction.  
Example `node bin/hsd-ledger sendraw --http-host 127.0.0.1 --api-key=1234 -w coldwallet batch.json names.txt`
9. Sign the transaction on your ledger.