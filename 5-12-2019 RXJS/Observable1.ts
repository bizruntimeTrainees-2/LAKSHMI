import { Observable } from 'rxjs';
 
const observable = new Observable(subscriber => {
  subscriber.next(1);
  subscriber.next(2);
  subscriber.next(3);
  setTimeout(() => {
    subscriber.next(4);
    subscriber.complete();
  }, 1000);
});
 
console.log('just before subscribe');
observable.subscribe({
  next(x) { console.log('got value ' + x); },
  error(err) { console.error('something wrong occurred: ' + err); },
  complete() { console.log('done'); }
});
console.log('just after subscribe');

/*
"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function (subscriber) {
    subscriber.next(1);
    subscriber.next(2);
    subscriber.next(3);
    setTimeout(function () {
        subscriber.next(4);
        subscriber.complete();
    }, 1000);
});
console.log('just before subscribe');
observable.subscribe({
    next: function (x) { console.log('got value ' + x); },
    error: function (err) { console.error('something wrong occurred: ' + err); },
    complete: function () { console.log('done'); }
});
console.log('just after subscribe');
*/


/*
just before subscribe
got value 1
got value 2
got value 3
just after subscribe
got value 4
done
*/