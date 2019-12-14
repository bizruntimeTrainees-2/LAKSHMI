import {of} from 'rxjs';
import {tap,map} from 'rxjs/operators';

const source= of(2,3,4,5,6);
const example  = source.pipe(
  tap(val => console.log('Before Map:${val}')),
  map(val => val + 10),
  tap(val => console.log('After Map:${val}')),
);
const subscribe = example.subscribe(val => console.log(val));
/*
tap is a RxJS pipeable operator that returns identical Observable as source Observable and can be used to perform side effect such as logging each values emitted by source Observable .
*/



/*
Before Map:${val}
After Map:${val}
12
Before Map:${val}
After Map:${val}
13
Before Map:${val}
After Map:${val}
14
Before Map:${val}
After Map:${val}
15
Before Map:${val}
After Map:${val}
16
*/