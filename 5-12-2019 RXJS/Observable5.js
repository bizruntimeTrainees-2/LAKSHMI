"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function (subscribe) {
    console.log('Hello');
    subscribe.next(1);
    subscribe.next(2);
    subscribe.next(3);
    subscribe.next(4);
    subscribe.next(5);
    subscribe.complete(); //nothing will be executed after complete method calling
    subscribe.next(6);
});
console.log('before');
observable.subscribe(function (x) {
    console.log(x);
});
console.log('after');
