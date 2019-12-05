"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var foo = new rxjs_1.Observable(function (subscriber) {
    console.log('Hello');
    subscriber.next(42);
});
foo.subscribe(function (x) {
    console.log(x);
});
foo.subscribe(function (y) {
    console.log(y);
});
