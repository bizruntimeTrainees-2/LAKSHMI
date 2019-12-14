"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
//emit next and error notifications
var source = rxjs_1.from([
    rxjs_1.Notification.createNext('SUCCESS!'),
    rxjs_1.Notification.createError('ERROR!')
]).pipe(
//turn notification objects into notification values
operators_1.dematerialize());
//output: 'NEXT VALUE: SUCCESS' 'ERROR VALUE: 'ERROR!'
var subscription = source.subscribe({
    next: function (val) { return console.log("NEXT VALUE: " + val); },
    error: function (val) { return console.log("ERROR VALUE: " + val); }
});
