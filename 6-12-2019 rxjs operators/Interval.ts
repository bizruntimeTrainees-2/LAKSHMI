import { interval } from 'rxjs';
import { take } from 'rxjs/operators';
 
const numbers = interval(500);
 
const takeSevenNumbers = numbers.pipe(take(7));
 
takeSevenNumbers.subscribe(x => console.log('Next: ', x));
/*Creates an Observable that emits sequential numbers every specified interval of time */

/*
Next:  0
Next:  1
Next:  2
Next:  3
Next:  4
Next:  5
Next:  6

*/