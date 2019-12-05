"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function (subscribe) {
    // Keep track of the interval resource
    var value = setInterval(function () {
        subscribe.next('hi');
    }, 1000);
    // Provide a way of canceling and disposing the interval resource
    return function unsubscribe() {
        clearInterval(value);
    };
});
console.log(observable);
