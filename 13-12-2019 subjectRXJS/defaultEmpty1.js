"use strict";
exports.__esModule = true;
// RxJS v6+
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
//emit 'Observable.empty()!' when empty, else any values from source
var example = rxjs_1.empty().pipe(operators_1.defaultIfEmpty('Observable.empty()!'));
//output: 'Observable.empty()!'
var subscribe = example.subscribe(function (val) { return console.log(val); });
