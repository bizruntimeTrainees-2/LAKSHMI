import { from } from 'rxjs';

const observable = from([10, 20, 30]);
const subscription = observable.subscribe(x => console.log(x));

subscription.unsubscribe();   //after completion of subscription, call the unsubscribe() method to cancel the execution.

/*
10
20
30
*/