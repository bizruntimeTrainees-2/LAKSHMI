"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var source = rxjs_1.of(2, 3, 4, 5, 6);
var example = source.pipe(operators_1.tap(function (val) { return console.log('Before Map:${val}'); }), operators_1.map(function (val) { return val + 10; }), operators_1.tap(function (val) { return console.log('After Map:${val}'); }));
var subscribe = example.subscribe(function (val) { return console.log(val); });
