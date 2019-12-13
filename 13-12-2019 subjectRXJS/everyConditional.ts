import {every} from 'rxjs/operators';
import {of} from 'rxjs';

const source = of(1,2,3,4,5);
const example = source.pipe(
  //here the condition is every value even
  every(val => val % 2 == 0)
);
const subscribe = example.subscribe(val => console.log(val));
//here all values not even so the result is false.
/*
false

*/


/*
If all values pass predicate before completion emit true, else false.
*/