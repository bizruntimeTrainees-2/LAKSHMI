"use strict";
/*
import { timer } from 'rxjs';

const numbers = timer(3000, 1000);
numbers.subscribe(x => console.log(x));
*/
exports.__esModule = true;
/*
Creates an Observable that starts emitting after an dueTime and emits ever increasing numbers after each period of time thereafter.
*/
var rxjs_1 = require("rxjs");
var numbers = rxjs_1.timer(3000);
numbers.subscribe(function (x) { return console.log(x); });
