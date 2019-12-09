"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
operators_1.first()(rxjs_1.of(5, 9, 13)).subscribe(function (v) { return console.log("value: " + v); });
/*it will return the first value */
/*
value: 1
*/ 
