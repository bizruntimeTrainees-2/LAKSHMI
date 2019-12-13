"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
//emit 5 values
var allEvens = rxjs_1.of(2, 4, 6, 8, 10);
var example = allEvens.pipe(
//is every value even?
operators_1.every(function (val) { return val % 2 === 0; }));
//output: true
var subscribe = example.subscribe(function (val) { return console.log(val); });
