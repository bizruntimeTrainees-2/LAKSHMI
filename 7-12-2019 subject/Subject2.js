"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var source = rxjs_1.interval(500);
var subject = new rxjs_1.Subject();
var refCounted = source.pipe(operators_1.multicast(subject), operators_1.refCount());
var subscription1, subscription2;
// This calls `connect()`, because
// it is the first subscriber to `refCounted`
console.log('observerA subscribed');
subscription1 = refCounted.subscribe({
    next: function (v) { return console.log("observerA: " + v); }
});
setTimeout(function () {
    console.log('observerB subscribed');
    subscription2 = refCounted.subscribe({
        next: function (v) { return console.log("observerB: " + v); }
    });
}, 600);
setTimeout(function () {
    console.log('observerA unsubscribed');
    subscription1.unsubscribe();
}, 1200);
// This is when the shared Observable execution will stop, because
// `refCounted` would have no more subscribers after this
setTimeout(function () {
    console.log('observerB unsubscribed');
    subscription2.unsubscribe();
}, 2000);
