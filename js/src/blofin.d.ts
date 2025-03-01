import Exchange from './abstract/blofin.js';
import type { Int, OrderSide, OrderType, Trade, OHLCV, Order, FundingRateHistory, OrderRequest, Str, Transaction, Ticker, OrderBook, Balances, Tickers, Market, Strings, Currency, Position, TransferEntry } from './base/types.js';
/**
 * @class blofin
 * @augments Exchange
 */
export default class blofin extends Exchange {
    describe(): any;
    fetchMarkets(params?: {}): Promise<import("./base/types.js").MarketInterface[]>;
    parseMarket(market: any): Market;
    fetchOrderBook(symbol: string, limit?: Int, params?: {}): Promise<OrderBook>;
    parseTicker(ticker: any, market?: Market): Ticker;
    fetchTicker(symbol: string, params?: {}): Promise<Ticker>;
    fetchTickers(symbols?: Strings, params?: {}): Promise<Tickers>;
    parseTrade(trade: any, market?: Market): Trade;
    fetchTrades(symbol: string, since?: Int, limit?: Int, params?: {}): Promise<Trade[]>;
    parseOHLCV(ohlcv: any, market?: Market): OHLCV;
    fetchOHLCV(symbol: string, timeframe?: string, since?: Int, limit?: Int, params?: {}): Promise<OHLCV[]>;
    fetchFundingRateHistory(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<FundingRateHistory[]>;
    parseFundingRate(contract: any, market?: Market): {
        info: any;
        symbol: string;
        markPrice: any;
        indexPrice: any;
        interestRate: number;
        estimatedSettlePrice: any;
        timestamp: any;
        datetime: any;
        fundingRate: number;
        fundingTimestamp: number;
        fundingDatetime: string;
        nextFundingRate: number;
        nextFundingTimestamp: number;
        nextFundingDatetime: string;
        previousFundingRate: any;
        previousFundingTimestamp: any;
        previousFundingDatetime: any;
    };
    fetchFundingRate(symbol: string, params?: {}): Promise<{
        info: any;
        symbol: string;
        markPrice: any;
        indexPrice: any;
        interestRate: number;
        estimatedSettlePrice: any;
        timestamp: any;
        datetime: any;
        fundingRate: number;
        fundingTimestamp: number;
        fundingDatetime: string;
        nextFundingRate: number;
        nextFundingTimestamp: number;
        nextFundingDatetime: string;
        previousFundingRate: any;
        previousFundingTimestamp: any;
        previousFundingDatetime: any;
    }>;
    parseBalanceByType(type: any, response: any): Balances;
    parseTradingBalance(response: any): Balances;
    parseFundingBalance(response: any): Balances;
    parseTradingFee(fee: any, market?: Market): {
        info: any;
        symbol: string;
        maker: number;
        taker: number;
    };
    fetchBalance(params?: {}): Promise<Balances>;
    createOrderRequest(symbol: string, type: OrderType, side: OrderSide, amount: number, price?: number, params?: {}): any;
    parseOrderStatus(status: any): string;
    parseOrder(order: any, market?: Market): Order;
    createOrder(symbol: string, type: OrderType, side: OrderSide, amount: number, price?: number, params?: {}): Promise<Order>;
    createTpslOrderRequest(symbol: string, type: OrderType, side: OrderSide, amount?: number, price?: number, params?: {}): any;
    cancelOrder(id: string, symbol?: Str, params?: {}): Promise<Order>;
    createOrders(orders: OrderRequest[], params?: {}): Promise<Order[]>;
    fetchOpenOrders(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Order[]>;
    fetchMyTrades(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Trade[]>;
    fetchDeposits(code?: Str, since?: Int, limit?: Int, params?: {}): Promise<Transaction[]>;
    fetchWithdrawals(code?: Str, since?: Int, limit?: Int, params?: {}): Promise<Transaction[]>;
    fetchLedger(code?: Str, since?: Int, limit?: Int, params?: {}): Promise<any>;
    parseTransaction(transaction: any, currency?: Currency): Transaction;
    parseTransactionStatus(status: any): string;
    parseLedgerEntryType(type: any): string;
    parseLedgerEntry(item: any, currency?: Currency): {
        id: string;
        info: any;
        timestamp: number;
        datetime: string;
        fromAccount: string;
        toAccount: string;
        type: string;
        currency: string;
        amount: number;
        clientId: string;
        status: string;
    };
    parseIds(ids: any): any;
    cancelOrders(ids: any, symbol?: Str, params?: {}): Promise<Order[]>;
    transfer(code: string, amount: number, fromAccount: any, toAccount: any, params?: {}): Promise<TransferEntry>;
    parseTransfer(transfer: any, currency?: Currency): {
        info: any;
        id: string;
        timestamp: any;
        datetime: any;
        currency: any;
        amount: any;
        fromAccount: any;
        toAccount: any;
        status: any;
    };
    fetchPosition(symbol: string, params?: {}): Promise<Position>;
    fetchPositions(symbols?: string[], params?: {}): Promise<Position[]>;
    parsePosition(position: any, market?: Market): Position;
    fetchLeverage(symbol: string, params?: {}): Promise<any>;
    setLeverage(leverage: any, symbol?: Str, params?: {}): Promise<any>;
    closePosition(symbol: string, side?: OrderSide, params?: {}): Promise<Order>;
    fetchClosedOrders(symbol?: Str, since?: Int, limit?: Int, params?: {}): Promise<Order[]>;
    handleErrors(httpCode: any, reason: any, url: any, method: any, headers: any, body: any, response: any, requestHeaders: any, requestBody: any): any;
    sign(path: any, api?: string, method?: string, params?: {}, headers?: any, body?: any): {
        url: string;
        method: string;
        body: any;
        headers: any;
    };
}
