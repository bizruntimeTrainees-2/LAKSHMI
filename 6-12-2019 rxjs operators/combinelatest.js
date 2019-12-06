"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var firstTimer = rxjs_1.timer(0, 1000); // emit 0, 1, 2... after every second, starting from now
var secondTimer = rxjs_1.timer(500, 1000); // emit 0, 1, 2... after every second, starting 0,5s from now
var combinedTimers = rxjs_1.combineLatest(firstTimer, secondTimer);
combinedTimers.subscribe(function (value) { return console.log(value); });
