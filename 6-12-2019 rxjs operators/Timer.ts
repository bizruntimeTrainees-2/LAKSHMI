

import { timer } from 'rxjs';

const numbers = timer(3000, 1000);
numbers.subscribe(x => console.log(x));


/*
Creates an Observable that starts emitting after an dueTime and emits ever increasing numbers after each period of time thereafter.
*/

