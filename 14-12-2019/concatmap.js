"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
//emit delay value
var source = rxjs_1.of(2000, 1000); //of means it takes all values in array
// map value from source into inner observable, when complete emit result and move to next
var example = source.pipe(operators_1.concatMap(function (val) { return rxjs_1.of("Delayed by: " + val + "ms").pipe(operators_1.delay(val)); }));
//output: With concatMap: Delayed by: 2000ms, With concatMap: Delayed by: 1000ms
var subscribe = example.subscribe(function (val) {
    return console.log("With concatMap: " + val);
});
// showing the difference between concatMap and mergeMap
var mergeMapExample = source
    .pipe(
// just so we can log this after the first example has run
operators_1.delay(5000), operators_1.mergeMap(function (val) { return rxjs_1.of("Delayed by: " + val + "ms").pipe(operators_1.delay(val)); }))
    .subscribe(function (val) { return console.log("With mergeMap: " + val); });
