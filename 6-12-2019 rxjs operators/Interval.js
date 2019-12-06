"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var numbers = rxjs_1.interval(500);
var takeSevenNumbers = numbers.pipe(operators_1.take(7));
takeSevenNumbers.subscribe(function (x) { return console.log('Next: ', x); });
