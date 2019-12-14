"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/internal/operators");
var operators_2 = require("rxjs/internal/operators");
var myArray = [1, 2, 3, 4];
rxjs_1.from(myArray).pipe(operators_2.concatMap(function (item) { return rxjs_1.of(item).pipe(operators_1.delay(1000)); })).subscribe(function (timedItem) {
    console.log(timedItem);
});
