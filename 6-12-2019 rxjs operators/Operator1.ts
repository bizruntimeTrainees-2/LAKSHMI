import { range } from 'rxjs';

const numbers = range(1, 10);
numbers.subscribe(x => console.log(x)); /*range creates an observable that emits sequence of numbers with in a specified range */

/*
1
2
3
4
5
6
7
8
9
10
*/