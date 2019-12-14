import {interval,timer} from 'rxjs';
import {delayWhen} from 'rxjs/operators';
//emits the value every half second
const message = interval(500);
//emit value after five seconds
const delayForFiveSeconds = () => timer(5000);
//after 5 seconds, start emitting delayed interval values
const delayWhenExample = message.pipe(delayWhen(delayForFiveSeconds));
//log values, delayed for 5 seconds
//ex. output: 5s....1...2...3
const subscribe = delayWhenExample.subscribe(val => console.log(val));


/* Delay emitted values determined by provided function. */

/*
1,2,3, -----etc .... continuously infinity values */