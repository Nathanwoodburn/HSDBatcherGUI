# **NEW WALLET**
FireWallet is a new wallet for Handshake.  
It runs on Windows (using .net framework).  
It includes the same functionality as this Batcher tool and much more.
You can have a look at it [here](https://github.com/Nathanwoodburn/FireWallet/)


# BidderGUI
![image](https://github.com/Nathanwoodburn/HSDBatcherGUI/blob/master/HSDBatcher-v4.1.png)

Watch this video for a short intro on how this tool works:
[https://youtu.be/w8NUjOqySiM](https://youtu.be/w8NUjOqySiM)

Easy to use HSD Bidder built on C# .net framework  
This version only works with HSD v5 or greater.  
If you have below this version use [this release](https://github.com/Nathanwoodburn/HSDBatcherGUI/releases/tag/1.1.0.0)

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
5. Select mode from [available transaction types](#transactions)
   
6. Set batching settings
7. Press start to begin batching transactions
8. Pause at any time by pressing Stop


## Transactions
1. OPEN: Opens domains for auction
2. BID: Send bids with specified bid and blind  
     • Set bid and blind in HNS values (not dollarydoos)
3. REVEAL: Reveal bids
4. REDEEM: Redeems lost auction bids
5. REGISTER: Registers domain to winning bid and burns second highest bid value (can use UPDATE instead)
6. UPDATE: Updates domains' resource (Blockchain DNS) records
     • Add DNS records
7. RENEW: Renews domains
8. TRANSFER: Start domain transfers to a new address (Not implemented yet)
9.  FINALIZE: Finalize transfers. You need to wait at least 288 blocks between TRANSFER & FINALIZE (Not implemented yet)

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


## Theme
You can change the theme by editing the `theme.txt` file in `%appdata%/HSDBidderGUI`.  
Here is a list of options:

### background:
Sets the background color of the form.

### background-alt:
Sets the background color of the controls.

### foreground:
Sets the foreground color of the form.

### foreground-alt:
Sets the foreground color of the controls.

### trantransparent-mode:
Sets the transparency of the form.
Options are:
1. off (or delete the line)
2. mica (styled like some newer windows apps)
3. key (transparent with a key color)
     This will also make the transparent colour clickthroughable.
4. percent (transparent with a percentage)
     This will affect all parts of the form.

### transparency-key:
Sets the key color for the form. Required if transparent-mode is set to key.  
Can also be set to `main` or `alt` to use the main or alt background colors.  
! Warning if you set this to be black the menu options (Minimize, Close) will be a bit buggy.

### transparency-percent:
Sets the transparency percentage for the form. Required if transparent-mode is set to percent.  
0 is fully transparent and 100 is fully opaque.