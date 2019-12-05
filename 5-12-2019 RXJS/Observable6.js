"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = rxjs_1.from([10, 20, 30]);
var subscription = observable.subscribe(function (x) { return console.log(x); });
// Later:
subscription.unsubscribe();
