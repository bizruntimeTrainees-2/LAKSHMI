"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var weight = rxjs_1.of(70, 72, 76, 79, 75);
var height = rxjs_1.of(1.76, 1.77, 1.78);
var bmi = rxjs_1.combineLatest(weight, height).pipe(operators_1.map(function (_a) {
    var w = _a[0], h = _a[1];
    return w / (h * h);
}));
bmi.subscribe(function (x) { return console.log('BMI is ' + x); });
