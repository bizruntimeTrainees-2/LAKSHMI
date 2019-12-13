"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
//emit 'Observable.of() Empty!' when empty, else any values from source
var exampleOne = rxjs_1.of().pipe(operators_1.defaultIfEmpty('Observable.of() Empty!'));
//output: 'Observable.of() Empty!'
var subscribe = exampleOne.subscribe(function (val) { return console.log(val); });
