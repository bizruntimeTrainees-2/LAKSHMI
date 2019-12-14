"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
//emit value in sequence every 1 second
var source = rxjs_1.interval(1000);
//output: 0,1,2,3,4,5....
var example = source.pipe(operators_1.take(5), //take only the first 5 values
operators_1.finalize(function () { return console.log('Sequence complete'); }) // Execute when the observable completes
);
var subscribe = example.subscribe(function (val) { return console.log(val); });
