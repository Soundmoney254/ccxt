namespace ccxt;

//
// Exchange Types that are used in the Exchange.Wrappers.cs file to type the generic methods
//

// public partial class Exchange
// {

public struct Precision
{
    public double? amount;
    public double? price;
    public Precision(object precision2)
    {
        var precision = (Dictionary<string, object>)precision2;
        amount = Exchange.SafeFloat(precision, "amount");
        price = Exchange.SafeFloat(precision, "price");
    }
}

public struct MinMax
{
    public double? min;
    public double? max;
    public MinMax(object minMax2)
    {
        var minMax = (Dictionary<string, object>)minMax2;
        min = Exchange.SafeFloat(minMax, "min");
        max = Exchange.SafeFloat(minMax, "max");
    }
}

public struct Fee
{
    public double? rate;
    public double? cost;

    public Fee(object fee2)
    {
        var fee = (Dictionary<string, object>)fee2;
        rate = Exchange.SafeFloat(fee, "rate");
        cost = Exchange.SafeFloat(fee, "cost");
    }
}

public struct Limits
{
    public MinMax? amount;
    public MinMax? cost;
    public MinMax? leverage;
    public MinMax? price;

    public Limits(object limits2)
    {
        var limits = (Dictionary<string, object>)limits2;
        amount = limits.ContainsKey("amount") ? new MinMax(limits["amount"]) : null;
        cost = limits.ContainsKey("cost") ? new MinMax(limits["cost"]) : null;
        leverage = limits.ContainsKey("leverage") ? new MinMax(limits["leverage"]) : null;
        price = limits.ContainsKey("price") ? new MinMax(limits["price"]) : null;
    }
}

public struct Market
{
    public string? id;
    public string? symbol;
    public string? baseCurrency;
    public string? quote;
    public string? baseId;
    public string? quoteId;
    public bool? active;
    public string? type;
    public bool? spot;
    public bool? margin;
    public bool? swap;
    public bool? future;
    public bool? option;
    public bool? contract;
    public string? settle;
    public string? settleId;
    public double? contractSize;
    public bool? linear;
    public bool? inverse;
    public double? expiry;
    public string? expiryDatetime;
    public double? strike;
    public string? optionType;
    public double? taker;
    public double? maker;
    public bool? percentage;
    public bool? tierBased;
    public string? feeSide;

    public Precision? precision;

    public Limits? limits;
    public Dictionary<string, object> info;

    public Market(object market2)
    {
        var market = (Dictionary<string, object>)market2;
        id = Exchange.SafeString(market, "id");
        symbol = Exchange.SafeString(market, "symbol");
        baseCurrency = Exchange.SafeString(market, "base");
        quote = Exchange.SafeString(market, "quote");
        baseId = Exchange.SafeString(market, "baseId");
        quoteId = Exchange.SafeString(market, "quoteId");
        active = market.ContainsKey("active") && market["active"] != null ? (bool)market["active"] : null;
        type = Exchange.SafeString(market, "type");
        spot = market.ContainsKey("spot") && market["spot"] != null ? (bool)market["spot"] : null;
        margin = market.ContainsKey("margin") && market["margin"] != null ? (bool)market["margin"] : null;
        swap = market.ContainsKey("swap") && market["swap"] != null ? (bool)market["swap"] : null;
        future = market.ContainsKey("future") && market["future"] != null ? (bool)market["future"] : null;
        option = market.ContainsKey("option") && market["option"] != null ? (bool)market["option"] : null;
        contract = market.ContainsKey("contract") && market["contract"] != null ? (bool)market["contract"] : null;
        settle = Exchange.SafeString(market, "settle");
        settleId = Exchange.SafeString(market, "settleId");
        contractSize = Exchange.SafeFloat(market, "contractSize");
        linear = market.ContainsKey("linear") && market["linear"] != null ? (bool)market["linear"] : null;
        inverse = market.ContainsKey("inverse") && market["inverse"] != null ? (bool)market["inverse"] : null;
        expiry = Exchange.SafeFloat(market, "expiry");
        expiryDatetime = Exchange.SafeString(market, "expiryDatetime");
        strike = Exchange.SafeFloat(market, "strike");
        optionType = Exchange.SafeString(market, "optionType");
        taker = Exchange.SafeFloat(market, "taker");
        maker = Exchange.SafeFloat(market, "maker");
        percentage = market.ContainsKey("percentage") && market["percentage"] != null ? (bool)market["percentage"] : null;
        tierBased = market.ContainsKey("tierBased") && market["tierBased"] != null ? (bool)market["tierBased"] : null;
        feeSide = Exchange.SafeString(market, "feeSide");
        precision = market.ContainsKey("precision") ? new Precision(market["precision"]) : null;
        limits = market.ContainsKey("limits") ? new Limits(market["limits"]) : null;
        info = market;
    }
}

public struct Trade
{
    public double? amount;
    public double? price;
    public double? cost;
    public string? id;
    public string? orderId;
    public Dictionary<string, object>? info;
    public Int64? timestamp;
    public string? datetime;
    public string? symbol;
    public string? type;
    public string? side;
    public string? takerOrMaker;
    public Fee? fee;
    public Trade(object trade2)
    {
        var trade = (Dictionary<string, object>)trade2;
        amount = Exchange.SafeFloat(trade, "amount");
        price = Exchange.SafeFloat(trade, "price");
        cost = Exchange.SafeFloat(trade, "cost");
        id = Exchange.SafeString(trade, "id");
        orderId = Exchange.SafeString(trade, "orderId");
        info = trade.ContainsKey("info") ? (Dictionary<string, object>)trade["info"] : null;
        timestamp = Exchange.SafeInteger(trade, "timestamp");
        datetime = Exchange.SafeString(trade, "datetime");
        symbol = Exchange.SafeString(trade, "symbol");
        type = Exchange.SafeString(trade, "type");
        side = Exchange.SafeString(trade, "side");
        takerOrMaker = Exchange.SafeString(trade, "takerOrMaker");
        fee = trade.ContainsKey("fee") ? new Fee(trade["fee"]) : null;
    }
}

public struct Order
{
    public string? id;
    public string? clientOrderId;
    public Int64? timestamp;
    public string? datetime;
    public string? lastTradeTimestamp;
    public string? symbol;
    public string? type;
    public string? side;
    public double? price;
    public double? cost;
    public double? average;
    public double? amount;
    public double? filled;

    public double? triggerPrice;

    public double? stopLossPrice;

    public double? takeProfitPrice;
    public double? remaining;
    public string? status;
    public Fee? fee;
    public IEnumerable<Trade>? trades;
    public Dictionary<string, object>? info;
    public Order(object order2)
    {
        var order = (Dictionary<string, object>)order2;
        id = Exchange.SafeString(order, "id");
        clientOrderId = Exchange.SafeString(order, "clientOrderId");
        timestamp = Exchange.SafeInteger(order, "timestamp");
        datetime = Exchange.SafeString(order, "datetime");
        lastTradeTimestamp = Exchange.SafeString(order, "lastTradeTimestamp");
        symbol = Exchange.SafeString(order, "symbol");
        type = Exchange.SafeString(order, "type");
        side = Exchange.SafeString(order, "side");
        price = Exchange.SafeFloat(order, "price");
        cost = Exchange.SafeFloat(order, "cost");
        average = Exchange.SafeFloat(order, "average");
        amount = Exchange.SafeFloat(order, "amount");
        filled = Exchange.SafeFloat(order, "filled");
        remaining = Exchange.SafeFloat(order, "remaining");
        status = Exchange.SafeString(order, "status");
        fee = order.ContainsKey("fee") ? new Fee(order["fee"]) : null;
        trades = order.ContainsKey("trades") ? ((IEnumerable<object>)order["trades"]).Select(x => new Trade(x)) : null;
        triggerPrice = Exchange.SafeFloat(order, "triggerPrice");
        stopLossPrice = Exchange.SafeFloat(order, "stopLossPrice");
        takeProfitPrice = Exchange.SafeFloat(order, "takeProfitPrice");
        info = order.ContainsKey("info") ? (Dictionary<string, object>)order["info"] : null;
    }
}

public struct Ticker
{
    public string? symbol;
    public Int64? timestamp;
    public string? datetime;
    public double? high;
    public double? low;
    public double? bid;
    public double? bidVolume;
    public double? ask;
    public double? askVolume;
    public double? vwap;
    public double? open;

    public double? close;
    public double? last;
    public double? previousClose;
    public double? change;
    public double? percentage;
    public double? average;
    public double? baseVolume;
    public double? quoteVolume;
    public Dictionary<string, object> info;

    public Ticker(object ticker2)
    {
        var ticker = (Dictionary<string, object>)ticker2;
        symbol = Exchange.SafeString(ticker, "symbol");
        timestamp = Exchange.SafeInteger(ticker, "timestamp");
        datetime = Exchange.SafeString(ticker, "datetime");
        high = Exchange.SafeFloat(ticker, "high");
        low = Exchange.SafeFloat(ticker, "low");
        bid = Exchange.SafeFloat(ticker, "bid");
        bidVolume = Exchange.SafeFloat(ticker, "bidVolume");
        ask = Exchange.SafeFloat(ticker, "ask");
        askVolume = Exchange.SafeFloat(ticker, "askVolume");
        vwap = Exchange.SafeFloat(ticker, "vwap");
        open = Exchange.SafeFloat(ticker, "open");
        close = Exchange.SafeFloat(ticker, "close");
        last = Exchange.SafeFloat(ticker, "last");
        previousClose = Exchange.SafeFloat(ticker, "previousClose");
        change = Exchange.SafeFloat(ticker, "change");
        percentage = Exchange.SafeFloat(ticker, "percentage");
        average = Exchange.SafeFloat(ticker, "average");
        baseVolume = Exchange.SafeFloat(ticker, "baseVolume");
        quoteVolume = Exchange.SafeFloat(ticker, "quoteVolume");
        info = ticker.ContainsKey("info") ? (Dictionary<string, object>)ticker["info"] : null;
    }
}

public struct Tickers
{
    public Dictionary<string, object> info;
    public Dictionary<string, Ticker> tickers;

    public Tickers(object tickers2)
    {
        var tickers = (Dictionary<string, object>)tickers2;

        info = tickers.ContainsKey("info") ? (Dictionary<string, object>)tickers["info"] : null;
        this.tickers = new Dictionary<string, Ticker>();
        foreach (var ticker in tickers)
        {
            if (ticker.Key != "info")
                this.tickers.Add(ticker.Key, new Ticker(ticker.Value));
        }
    }

    // Indexer
    public Ticker this[string key]
    {
        get
        {
            if (tickers.ContainsKey(key))
            {
                return tickers[key];
            }
            else
            {
                throw new KeyNotFoundException($"The key '{key}' was not found in the tickers.");
            }
        }
        set
        {
            tickers[key] = value;
        }
    }
}

public struct Transaction
{
    public string? id;
    public string? txid;
    public string? address;
    public string? tag;
    public string? type;
    public string? currency;
    public double? amount;
    public string? status;
    public Int64? updated;
    public Int64? timestamp;
    public string? datetime;

    public Transaction(object transaction2)
    {
        var transaction = (Dictionary<string, object>)transaction2;
        id = Exchange.SafeString(transaction, "id");
        txid = Exchange.SafeString(transaction, "txid");
        address = Exchange.SafeString(transaction, "address");
        tag = Exchange.SafeString(transaction, "tag");
        type = Exchange.SafeString(transaction, "type");
        currency = Exchange.SafeString(transaction, "currency");
        amount = Exchange.SafeFloat(transaction, "amount");
        status = Exchange.SafeString(transaction, "status");
        updated = Exchange.SafeInteger(transaction, "updated");
        timestamp = Exchange.SafeInteger(transaction, "timestamp");
        datetime = Exchange.SafeString(transaction, "datetime");
    }
}

public struct OrderBook
{
    public List<List<double>>? bids;
    public List<List<double>>? asks;

    public string? symbol;
    public Int64? timestamp;
    public string? datetime;
    public Int64? nonce;

    public OrderBook(object orderbook2)
    {
        var orderbook = (IDictionary<string, object>)orderbook2;
        bids = orderbook.ContainsKey("bids") ? ((IEnumerable<object>)orderbook["bids"]).Select(x => ((IEnumerable<object>)x).Select(y => Convert.ToDouble(y)).ToList()).ToList() : null;
        asks = orderbook.ContainsKey("asks") ? ((IEnumerable<object>)orderbook["asks"]).Select(x => ((IEnumerable<object>)x).Select(y => Convert.ToDouble(y)).ToList()).ToList() : null;
        symbol = Exchange.SafeString(orderbook, "symbol");
        timestamp = Exchange.SafeInteger(orderbook, "timestamp");
        datetime = Exchange.SafeString(orderbook, "datetime");
        nonce = Exchange.SafeInteger(orderbook, "nonce");
    }
}

public struct OHLCV
{
    public Int64? timestamp;
    public double? open;
    public double? high;
    public double? low;
    public double? close;
    public double? volume;

    public OHLCV(object ohlcv2)
    {
        var ohlcv = (List<object>)ohlcv2;
        timestamp = Exchange.SafeInteger(ohlcv, 0);
        open = Exchange.SafeFloat(ohlcv, 1);
        high = Exchange.SafeFloat(ohlcv, 2);
        low = Exchange.SafeFloat(ohlcv, 3);
        close = Exchange.SafeFloat(ohlcv, 4);
        volume = Exchange.SafeFloat(ohlcv, 5);
    }
}

public struct OHLCVC
{
    public Int64? timestamp;
    public double? open;
    public double? high;
    public double? low;
    public double? close;
    public double? volume;
    public double? cost;

    public OHLCVC(object ohlcv2)
    {
        var ohlcv = (List<object>)ohlcv2;
        timestamp = Exchange.SafeInteger(ohlcv, 0);
        open = Exchange.SafeFloat(ohlcv, 1);
        high = Exchange.SafeFloat(ohlcv, 2);
        low = Exchange.SafeFloat(ohlcv, 3);
        close = Exchange.SafeFloat(ohlcv, 4);
        volume = Exchange.SafeFloat(ohlcv, 5);
        cost = Exchange.SafeFloat(ohlcv, 6);
    }
}

public struct Balance
{
    public double? free;
    public double? used;
    public double? total;

    public Balance(object balance2)
    {
        var balance = (Dictionary<string, object>)balance2;
        free = Exchange.SafeFloat(balance, "free");
        used = Exchange.SafeFloat(balance, "used");
        total = Exchange.SafeFloat(balance, "total");
    }
}

public struct Balances
{
    public Dictionary<string, Balance> balances;
    public Dictionary<string, object> info;

    public Balances(object balances2)
    {
        var balances = (Dictionary<string, object>)balances2;
        this.balances = new Dictionary<string, Balance>();
        foreach (var balance in balances)
        {
            if (balance.Key != "info" && balance.Key != "free" && balance.Key != "used" && balance.Key != "total" && balance.Key != "timestamp" && balance.Key != "datetime")
            {
                this.balances.Add(balance.Key, new Balance(balance.Value));
            }
        }
        info = (Dictionary<string, object>)balances["info"];
    }

    public Balance this[string key]
    {
        get
        {
            if (balances.ContainsKey(key))
            {
                return balances[key];
            }
            else
            {
                throw new KeyNotFoundException($"The key '{key}' was not found in the balances.");
            }
        }
        set
        {
            balances[key] = value;
        }
    }
}

public struct WithdrawlResponse
{
    public Dictionary<string, object> info;
    public string? id;

    public WithdrawlResponse(object withdrawlResponse2)
    {
        var withdrawlResponse = (Dictionary<string, object>)withdrawlResponse2;
        info = (Dictionary<string, object>)withdrawlResponse["info"];
        id = Exchange.SafeString(withdrawlResponse, "id");
    }
}

public struct DepositAddressResponse
{
    public string? address;
    public string? tag;
    public string? status;
    public Dictionary<string, object>? info;

    public DepositAddressResponse(object depositAddressResponse2)
    {
        var depositAddressResponse = (Dictionary<string, object>)depositAddressResponse2;
        address = Exchange.SafeString(depositAddressResponse, "address");
        tag = Exchange.SafeString(depositAddressResponse, "tag");
        status = Exchange.SafeString(depositAddressResponse, "status");
        info = depositAddressResponse.ContainsKey("info") ? (Dictionary<string, object>)depositAddressResponse["info"] : null;
    }
}

public struct BorrowRate
{
    public string? currency;
    public double? rate;
    public Int64? timestamp;
    public string? datetime;
    public Dictionary<string, object> info;

    public BorrowRate(object borrowRate)
    {
        var borrowRate2 = (Dictionary<string, object>)borrowRate;
        currency = Exchange.SafeString(borrowRate2, "currency");
        rate = Exchange.SafeFloat(borrowRate2, "rate");
        timestamp = Exchange.SafeInteger(borrowRate2, "timestamp");
        datetime = Exchange.SafeString(borrowRate2, "datetime");
        info = borrowRate2.ContainsKey("info") ? (Dictionary<string, object>)borrowRate2["info"] : null;
    }
}

public struct BorrowInterest
{
    public string? account;
    public string? currency;
    public double? interest;
    public double? interestRate;
    public double? amountBorrowed;
    public Int64? timestamp;
    public string? datetime;
    public string? marginMode;
    public Dictionary<string, object> info;

    public BorrowInterest(object borrowInterest)
    {
        account = Exchange.SafeString(borrowInterest, "account");
        currency = Exchange.SafeString(borrowInterest, "currency");
        interest = Exchange.SafeFloat(borrowInterest, "interest");
        interestRate = Exchange.SafeFloat(borrowInterest, "interestRate");
        amountBorrowed = Exchange.SafeFloat(borrowInterest, "amountBorrowed");
        timestamp = Exchange.SafeInteger(borrowInterest, "timestamp");
        datetime = Exchange.SafeString(borrowInterest, "datetime");
        marginMode = Exchange.SafeString(borrowInterest, "marginMode");
        info = Exchange.SafeValue(borrowInterest, "info", new Dictionary<string, object>()) as Dictionary<string, object>;
    }
}

public struct OpenInterest
{
    public string? symbol;
    public double? openInterestAmount;
    public double? openInterestValue;
    public Int64? timestamp;
    public string? datetime;
    public Dictionary<string, object> info;

    public OpenInterest(object openInterest)
    {
        symbol = Exchange.SafeString(openInterest, "symbol");
        openInterestAmount = Exchange.SafeFloat(openInterest, "openInterestAmount");
        openInterestValue = Exchange.SafeFloat(openInterest, "openInterestValue");
        timestamp = Exchange.SafeInteger(openInterest, "timestamp");
        datetime = Exchange.SafeString(openInterest, "datetime");
        info = Exchange.SafeValue(openInterest, "info", new Dictionary<string, object>()) as Dictionary<string, object>;
    }
}

public struct Liquidation
{
    public string? symbol;
    public double? quoteValue;
    public double? baseValue;
    public Int64? timestamp;
    public string? datetime;
    public Dictionary<string, object> info;

    public Liquidation(object openInterest)
    {
        symbol = Exchange.SafeString(openInterest, "symbol");
        quoteValue = Exchange.SafeFloat(openInterest, "quoteValue");
        baseValue = Exchange.SafeFloat(openInterest, "baseValue");
        timestamp = Exchange.SafeInteger(openInterest, "timestamp");
        datetime = Exchange.SafeString(openInterest, "datetime");
        info = Exchange.SafeValue(openInterest, "info", new Dictionary<string, object>()) as Dictionary<string, object>;
    }
}

public struct FundingRate
{
    public string? symbol;
    public Int64? timestamp;
    public string? datetime;
    public double? fundingRate;
    public double? markPrice;
    public double? indexPrice;
    public double? interestRate;
    public double? estimatedSettlePrice;
    public double? fundingTimestamp;
    public double? nextFundingTimestamp;
    public double? nextFundingRate;
    public Int64? nextFundingDatetime;
    public double? previousFundingTimestamp;
    public string? previousFundingDatetime;
    public double? previousFundingRate;

    public FundingRate(object fundingRateEntry)
    {
        symbol = Exchange.SafeString(fundingRateEntry, "symbol");
        datetime = Exchange.SafeString(fundingRateEntry, "datetime");
        timestamp = Exchange.SafeInteger(fundingRateEntry, "timestamp");
        fundingRate = Exchange.SafeFloat(fundingRateEntry, "fundingRate");
        markPrice = Exchange.SafeFloat(fundingRateEntry, "markPrice");
        indexPrice = Exchange.SafeFloat(fundingRateEntry, "indexPrice");
        interestRate = Exchange.SafeFloat(fundingRateEntry, "interestRate");
        estimatedSettlePrice = Exchange.SafeFloat(fundingRateEntry, "estimatedSettlePrice");
        fundingTimestamp = Exchange.SafeFloat(fundingRateEntry, "fundingTimestamp");
        nextFundingTimestamp = Exchange.SafeFloat(fundingRateEntry, "nextFundingTimestamp");
        nextFundingRate = Exchange.SafeFloat(fundingRateEntry, "nextFundingRate");
        nextFundingDatetime = Exchange.SafeInteger(fundingRateEntry, "nextFundingDatetime");
        previousFundingTimestamp = Exchange.SafeFloat(fundingRateEntry, "previousFundingTimestamp");
        previousFundingDatetime = Exchange.SafeString(fundingRateEntry, "previousFundingDatetime");
        previousFundingRate = Exchange.SafeFloat(fundingRateEntry, "previousFundingRate");
    }
}

public struct FundingRateHistory
{
    public string? symbol;
    public Int64? timestamp;
    public string? datetime;
    public double? fundingRate;

    public FundingRateHistory(object fundingRateEntry)
    {
        symbol = Exchange.SafeString(fundingRateEntry, "symbol");
        datetime = Exchange.SafeString(fundingRateEntry, "datetime");
        timestamp = Exchange.SafeInteger(fundingRateEntry, "timestamp");
        fundingRate = Exchange.SafeFloat(fundingRateEntry, "fundingRate");
    }
}

// public struct Transaction
// {
//     public string? id;
//     public string? txid;
//     public string? address;
//     public string? tag;
//     public string? type;
//     public string? currency;
//     public double? amount;
//     public string? status;
//     public Int64? updated;
//     public Int64? timestamp;
//     public string? datetime;
//     public Fee? fee;
//     public string? tagFrom;
//     public string? tagTo;
//     public string? addressTo;
//     public string? addressFrom;
//     public string? comment;

//     public Transaction(object transaction)
//     {
//         id = Exchange.SafeString(transaction, "id");
//         txid = Exchange.SafeString(transaction, "txid");
//         address = Exchange.SafeString(transaction, "address");
//         tag = Exchange.SafeString(transaction, "tag");
//         type = Exchange.SafeString(transaction, "type");
//         currency = Exchange.SafeString(transaction, "currency");
//         amount = Exchange.SafeFloat(transaction, "amount");
//         status = Exchange.SafeString(transaction, "status");
//         updated = Exchange.SafeInteger(transaction, "updated");
//         timestamp = Exchange.SafeInteger(transaction, "timestamp");
//         datetime = Exchange.SafeString(transaction, "datetime");
//         fee = Exchange.SafeValue(transaction, "fee") != null ? new Fee(Exchange.SafeValue(transaction, "fee")) : null;
//         tagFrom = Exchange.SafeString(transaction, "tagFrom");
//         tagTo = Exchange.SafeString(transaction, "tagTo");
//         addressTo = Exchange.SafeString(transaction, "addressTo");
//         addressFrom = Exchange.SafeString(transaction, "addressFrom");
//         comment = Exchange.SafeString(transaction, "comment");
//     }
// }

public struct Position
{
    public string symbol;
    public string? id;
    public Dictionary<string, object>? info;
    public double? timestamp;
    public string? datetime;
    public double? contracts;
    public double? contractsSize;
    public string? side;
    public double? notional;
    public double? leverage;
    public double? unrealizedPnl;

    public double? realizedPnl;
    public double? collateral;
    public double? entryPrice;
    public double? markPrice;
    public double? liquidationPrice;

    public double? stopLossPrice;

    public double? takeProfitPrice;
    public string? marginMode;
    public bool? hedged;
    public double? maintenenceMargin;
    public double? maintenanceMarginPercentage;
    public double? initialMargin;
    public double? initialMarginPercentage;
    public double? marginRatio;
    public double? lastUpdateTimestamp;
    public double? lastPrice;
    public double? percentage;

    public Position(object position)
    {
        symbol = Exchange.SafeString(position, "symbol");
        id = Exchange.SafeString(position, "id");
        info = Exchange.SafeValue(position, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(position, "info") : null;
        timestamp = Exchange.SafeInteger(position, "timestamp");
        datetime = Exchange.SafeString(position, "datetime");
        contracts = Exchange.SafeFloat(position, "contracts");
        contractsSize = Exchange.SafeFloat(position, "contractsSize");
        side = Exchange.SafeString(position, "side");
        notional = Exchange.SafeFloat(position, "notional");
        leverage = Exchange.SafeFloat(position, "leverage");
        unrealizedPnl = Exchange.SafeFloat(position, "unrealizedPnl");
        realizedPnl = Exchange.SafeFloat(position, "realizedPnl");
        collateral = Exchange.SafeFloat(position, "collateral");
        entryPrice = Exchange.SafeFloat(position, "entryPrice");
        markPrice = Exchange.SafeFloat(position, "markPrice");
        liquidationPrice = Exchange.SafeFloat(position, "liquidationPrice");
        marginMode = Exchange.SafeString(position, "marginMode");
        hedged = Exchange.SafeValue(position, "hedged") != null ? (bool)Exchange.SafeValue(position, "hedged") : null;
        maintenenceMargin = Exchange.SafeFloat(position, "maintenenceMargin");
        maintenanceMarginPercentage = Exchange.SafeFloat(position, "maintenanceMarginPercentage");
        initialMargin = Exchange.SafeFloat(position, "initialMargin");
        initialMarginPercentage = Exchange.SafeFloat(position, "initialMarginPercentage");
        marginRatio = Exchange.SafeFloat(position, "marginRatio");
        lastUpdateTimestamp = Exchange.SafeFloat(position, "lastUpdateTimestamp");
        lastPrice = Exchange.SafeFloat(position, "lastPrice");
        percentage = Exchange.SafeFloat(position, "percentage");
        takeProfitPrice = Exchange.SafeFloat(position, "takeProfitPrice");
        stopLossPrice = Exchange.SafeFloat(position, "stopLossPrice");
    }

}

public struct LeverageTier
{
    public Int64? tier;
    public string? currency;
    public double? minNotional;
    public double? maxNotional;
    public double? maintenanceMarginRate;
    public double? maxLeverage;
    public Dictionary<string, object>? info;

    public LeverageTier(object leverageTier)
    {
        tier = Exchange.SafeInteger(leverageTier, "tier");
        currency = Exchange.SafeString(leverageTier, "currency");
        minNotional = Exchange.SafeFloat(leverageTier, "minNotional");
        maxNotional = Exchange.SafeFloat(leverageTier, "maxNotional");
        maintenanceMarginRate = Exchange.SafeFloat(leverageTier, "maintenanceMarginRate");
        maxLeverage = Exchange.SafeFloat(leverageTier, "maxLeverage");
        info = Exchange.SafeValue(leverageTier, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(leverageTier, "info") : null;
    }
}

public struct LedgerEntry
{
    public string? id;
    public Dictionary<string, object>? info;
    public Int64? timestamp;
    public string? datetime;
    public string? direction;
    public string? account;
    public string? referenceId;
    public string? referenceAccount;
    public string? type;
    public string? currency;
    public double? amount;
    public double? before;
    public double? after;
    public string? status;
    public Fee? fee;

    public LedgerEntry(object ledgerEntry)
    {
        id = Exchange.SafeString(ledgerEntry, "id");
        info = Exchange.SafeValue(ledgerEntry, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(ledgerEntry, "info") : null;
        timestamp = Exchange.SafeInteger(ledgerEntry, "timestamp");
        datetime = Exchange.SafeString(ledgerEntry, "datetime");
        direction = Exchange.SafeString(ledgerEntry, "direction");
        account = Exchange.SafeString(ledgerEntry, "account");
        referenceId = Exchange.SafeString(ledgerEntry, "referenceId");
        referenceAccount = Exchange.SafeString(ledgerEntry, "referenceAccount");
        type = Exchange.SafeString(ledgerEntry, "type");
        currency = Exchange.SafeString(ledgerEntry, "currency");
        amount = Exchange.SafeFloat(ledgerEntry, "amount");
        before = Exchange.SafeFloat(ledgerEntry, "before");
        after = Exchange.SafeFloat(ledgerEntry, "after");
        status = Exchange.SafeString(ledgerEntry, "status");
        fee = Exchange.SafeValue(ledgerEntry, "fee") != null ? new Fee(Exchange.SafeValue(ledgerEntry, "fee")) : null;
    }
}

public struct DepositWithdrawFeeNetwork
{
    public double? fee;
    public bool? percentage;

    public DepositWithdrawFeeNetwork(object depositWithdrawFeeNetwork)
    {
        var pct = Exchange.SafeValue(depositWithdrawFeeNetwork, "percentage");
        fee = Exchange.SafeFloat(depositWithdrawFeeNetwork, "fee");
        percentage = pct != null ? (bool)pct : null;
    }
}

public struct DepositWithdrawFee
{
    public Dictionary<string, object>? info;
    public DepositWithdrawFeeNetwork? withdraw;
    public DepositWithdrawFeeNetwork? deposit;
    public Dictionary<string, DepositWithdrawFeeNetwork> networks;

    public DepositWithdrawFee(object depositWithdrawFee)
    {
        info = Exchange.SafeValue(depositWithdrawFee, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(depositWithdrawFee, "info") : null;
        withdraw = Exchange.SafeValue(depositWithdrawFee, "withdraw") != null ? new DepositWithdrawFeeNetwork(Exchange.SafeValue(depositWithdrawFee, "withdraw")) : null;
        deposit = Exchange.SafeValue(depositWithdrawFee, "deposit") != null ? new DepositWithdrawFeeNetwork(Exchange.SafeValue(depositWithdrawFee, "deposit")) : null;
        networks = new Dictionary<string, DepositWithdrawFeeNetwork>();
        if (Exchange.SafeValue(depositWithdrawFee, "networks") != null)
        {
            var networks2 = (Dictionary<string, object>)Exchange.SafeValue(depositWithdrawFee, "networks");
            foreach (var network in networks2)
            {
                networks.Add(network.Key, new DepositWithdrawFeeNetwork(network.Value));
            }
        }
    }
}

public struct TransferEntry
{
    public Dictionary<string, object>? info;

    public string? id;
    public Int64? timestamp;
    public string? datetime;
    public string? currency;
    public double? amount;
    public string? fromAccount;
    public string? toAccount;
    public string? status;

    public TransferEntry(object transfer)
    {
        info = Exchange.SafeValue(transfer, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(transfer, "info") : null;
        id = Exchange.SafeString(transfer, "id");
        timestamp = Exchange.SafeInteger(transfer, "timestamp");
        datetime = Exchange.SafeString(transfer, "datetime");
        currency = Exchange.SafeString(transfer, "currency");
        amount = Exchange.SafeFloat(transfer, "amount");
        fromAccount = Exchange.SafeString(transfer, "fromAccount");
        toAccount = Exchange.SafeString(transfer, "toAccount");
        status = Exchange.SafeString(transfer, "status");
    }
}

public struct OrderRequest
{

    public string? symbol;
    public string? type;
    public string? side;
    public double? amount;
    public double? price;
    public Dictionary<string, object>? parameters;


    public OrderRequest(object request)
    {
        amount = Exchange.SafeFloat(request, "amount");
        price = Exchange.SafeFloat(request, "price");
        type = Exchange.SafeString(request, "type");
        side = Exchange.SafeString(request, "side");
        symbol = Exchange.SafeString(request, "symbol");
        parameters = Exchange.SafeValue(request, "parameters") != null ? (Dictionary<string, object>)Exchange.SafeValue(request, "parameters") : null;
    }
}

public struct FundingHistory
{
    public Dictionary<string, object>? info;

    public string? id;
    public Int64? timestamp;
    public string? code;
    public string? symbol;
    public string? datetime;
    public string? currency;
    public double? amount;

    public FundingHistory(object funding)
    {
        info = Exchange.SafeValue(funding, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(funding, "info") : null;
        id = Exchange.SafeString(funding, "id");
        timestamp = Exchange.SafeInteger(funding, "timestamp");
        datetime = Exchange.SafeString(funding, "datetime");
        currency = Exchange.SafeString(funding, "currency");
        amount = Exchange.SafeFloat(funding, "amount");
        code = Exchange.SafeString(funding, "code");
        symbol = Exchange.SafeString(funding, "symbol");
        amount = Exchange.SafeFloat(funding, "status");
    }
}

public struct MarginMode
{
    public Dictionary<string, object>? info;
    public string? symbol;
    public string? marginMode;

    public MarginMode(object marginMode)
    {
        info = Exchange.SafeValue(marginMode, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(marginMode, "info") : null;
        symbol = Exchange.SafeString(marginMode, "symbol");
        this.marginMode = Exchange.SafeString(marginMode, "marginMode");
    }
}


public struct Greeks
{
    public Dictionary<string, object>? info;
    public Int64? timestamp;
    public string? datetime;
    public double? delta;
    public double? gamma;
    public double? theta;
    public double? vega;
    public double? rho;
    public double? bidSize;
    public double? askSize;
    public double? bidImpliedVolatility;
    public double? askImpliedVolatility;
    public double? markImpliedVolatility;
    public double? bidPrice;
    public double? askPrice;
    public double? markPrice;
    public double? lastPrice;
    public double? underlyingPrice;

    public Greeks(object greeks)
    {
        info = Exchange.SafeValue(greeks, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(greeks, "info") : null;
        timestamp = Exchange.SafeInteger(greeks, "timestamp");
        datetime = Exchange.SafeString(greeks, "datetime"); ;
        delta = Exchange.SafeFloat(greeks, "delta");
        gamma = Exchange.SafeFloat(greeks, "gamma");
        theta = Exchange.SafeFloat(greeks, "theta");
        vega = Exchange.SafeFloat(greeks, "vega");
        rho = Exchange.SafeFloat(greeks, "rho");
        bidSize = Exchange.SafeFloat(greeks, "bidSize");
        askSize = Exchange.SafeFloat(greeks, "askSize");
        bidImpliedVolatility = Exchange.SafeFloat(greeks, "bidImpliedVolatility");
        askImpliedVolatility = Exchange.SafeFloat(greeks, "askImpliedVolatility");
        markImpliedVolatility = Exchange.SafeFloat(greeks, "markImpliedVolatility");
        bidPrice = Exchange.SafeFloat(greeks, "bidPrice");
        askPrice = Exchange.SafeFloat(greeks, "askPrice");
        askPrice = Exchange.SafeFloat(greeks, "askPrice");
        markPrice = Exchange.SafeFloat(greeks, "markPrice");
        lastPrice = Exchange.SafeFloat(greeks, "lastPrice");
        underlyingPrice = Exchange.SafeFloat(greeks, "underlyingPrice");
    }
}


public struct MarketInterface
{

    public Dictionary<string, object>? info;
    public string? uppercaseId;
    public string? lowercaseId;
    public string? symbol;
    public string? baseCurrency;
    public string? quote;
    public string? baseId;
    public string? quoteId;
    public bool? active;
    public string? type;
    public bool? spot;
    public bool? margin;
    public bool? swap;
    public bool? future;
    public bool? option;
    public bool? contract;
    public string settle;
    public string settleId;
    public double? contractSize;
    public bool? linear;
    public bool? inverse;
    public bool? quanto;
    public Int64? expiry;
    public string? expiryDatetime;
    public double? strike;
    public string? optionType;
    public double? taker;
    public double? maker;

    public MarketInterface(object market)
    {
        info = Exchange.SafeValue(market, "info") != null ? (Dictionary<string, object>)Exchange.SafeValue(market, "info") : null;
        uppercaseId = Exchange.SafeString(market, "uppercaseId");
        lowercaseId = Exchange.SafeString(market, "lowercaseId");
        symbol = Exchange.SafeString(market, "symbol");
        baseCurrency = Exchange.SafeString(market, "baseCurrency");
        quote = Exchange.SafeString(market, "quote");
        baseId = Exchange.SafeString(market, "baseId");
        quoteId = Exchange.SafeString(market, "quoteId");
        active = Exchange.SafeValue(market, "active") != null ? (bool)Exchange.SafeValue(market, "active") : null;
        type = Exchange.SafeString(market, "type");
        spot = Exchange.SafeValue(market, "spot") != null ? (bool)Exchange.SafeValue(market, "spot") : null;
        margin = Exchange.SafeValue(market, "margin") != null ? (bool)Exchange.SafeValue(market, "margin") : null;
        swap = Exchange.SafeValue(market, "swap") != null ? (bool)Exchange.SafeValue(market, "swap") : null;
        future = Exchange.SafeValue(market, "future") != null ? (bool)Exchange.SafeValue(market, "future") : null;
        option = Exchange.SafeValue(market, "option") != null ? (bool)Exchange.SafeValue(market, "option") : null;
        contract = Exchange.SafeValue(market, "contract") != null ? (bool)Exchange.SafeValue(market, "contract") : null;
        settle = Exchange.SafeString(market, "settle");
        settleId = Exchange.SafeString(market, "settleId");
        contractSize = Exchange.SafeFloat(market, "contractSize");
        linear = Exchange.SafeValue(market, "linear") != null ? (bool)Exchange.SafeValue(market, "linear") : null;
        inverse = Exchange.SafeValue(market, "inverse") != null ? (bool)Exchange.SafeValue(market, "inverse") : null;
        quanto = Exchange.SafeValue(market, "quanto") != null ? (bool)Exchange.SafeValue(market, "quanto") : null;
        expiry = Exchange.SafeInteger(market, "expiry");
        expiryDatetime = Exchange.SafeString(market, "expiryDatetime");
        strike = Exchange.SafeFloat(market, "strike");
        optionType = Exchange.SafeString(market, "optionType");
        taker = Exchange.SafeFloat(market, "taker");
        maker = Exchange.SafeFloat(market, "maker");
    }
}
// }
