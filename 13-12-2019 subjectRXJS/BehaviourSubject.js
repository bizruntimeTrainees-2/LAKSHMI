"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var subject = new rxjs_1.BehaviorSubject(123);
// two new subscribers will get initial value => output: 123, 123
subject.subscribe(console.log);
subject.subscribe(console.log);
// two subscribers will get new value => output: 456, 456
subject.next(456);
// new subscriber will get latest value (456) => output: 456
subject.subscribe(console.log);
// all three subscribers will get new value => output: 789, 789, 789
subject.next(789);
// output: 123, 123, 456, 456, 456, 789, 789, 789
/*in this, it requires initial values and emits current value to new subscribers */ 
