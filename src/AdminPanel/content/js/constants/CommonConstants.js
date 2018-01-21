﻿var Constants = {
    SERVER_SHUTDOWN: "SERVER_SHUTDOWN",
    SERVER_START: "SERVER_START",
    SERVERLIST_SUBSCRIBE: "SERVERLIST_SUBSCRIBE",
    SERVERLIST_UNSUBSCRIBE: "SERVERLIST_UNSUBSCRIBE",
    LOG_FILTER_SERVER: "LOG_FILTER_SERVER",
    LOG_FILTER_CHARACTER: "LOG_FILTER_CHARACTER",
    LOG_FILTER_LOGGER: "LOG_FILTER_LOGGER",
    LOG_SETAUTOREFRESH: "LOG_SETAUTOREFRESH",
    LOG_SUBSCRIBE: "LOG_SUBSCRIBE",
    LOG_UNSUBSCRIBE: "LOG_UNSUBSCRIBE",
    ACCOUNT_SAVE: "ACCOUNT_SAVE",
    ACCOUNT_DELETE: "ACCOUNT_DELETE"
};

var Contents = {
    SERVER_LIST: 0,
    ACCOUNT_LIST: 1,
    LOG_VIEW: 2
}

var FluxMixin = Fluxxor.FluxMixin(React),
    FluxChildMixin = Fluxxor.FluxChildMixin(React),
    StoreWatchMixin = Fluxxor.StoreWatchMixin;

