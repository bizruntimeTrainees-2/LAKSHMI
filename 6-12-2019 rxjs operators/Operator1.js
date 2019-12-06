"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var numbers = rxjs_1.range(1, 10);
numbers.subscribe(function (x) { return console.log(x); });
