"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var sub = new rxjs_1.AsyncSubject();
sub.subscribe(console.log);
sub.next(123); //nothing logged
sub.next(345);
sub.subscribe(console.log);
sub.next(456); //nothing logged
sub.complete();
/*
it emits latest value to observers upon completion */
/*
456
456
*/
