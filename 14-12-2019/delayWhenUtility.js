"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var message = rxjs_1.interval(5);
//emit value after five seconds
var delayForFiveSeconds = function () { return rxjs_1.timer(5000); };
//after 5 seconds, start emitting delayed interval values
var delayWhenExample = message.pipe(operators_1.delayWhen(delayForFiveSeconds));
//log values, delayed for 5 seconds
//ex. output: 5s....1...2...3
var subscribe = delayWhenExample.subscribe(function (val) { return console.log(val); });
