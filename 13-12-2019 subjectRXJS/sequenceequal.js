"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var expectedSequence = rxjs_1.from([4, 5, 6]);
rxjs_1.of([1, 2, 3], [4, 5, 6], [7, 8, 9])
    .pipe(operators_1.switchMap(function (arr) { return rxjs_1.from(arr).pipe(operators_1.sequenceEqual(expectedSequence)); }))
    .subscribe(console.log);
//output: false, true, false
