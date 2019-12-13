"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
var source = rxjs_1.of(1, 2, 3, 4, 5);
var example = source.pipe(operators_1.every(function (val) { return val % 2 == 0; }));
var subscribe = example.subscribe(function (val) { return console.log(val); });
