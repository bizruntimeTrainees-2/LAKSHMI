import { AsyncSubject } from 'rxjs';

const sub = new AsyncSubject();

sub.subscribe(console.log);

sub.next(123); //nothing logged


sub.subscribe(console.log);

sub.next(456); //nothing logged
sub.complete(); 
/*
it emits latest value to observers upon completion */

/*
456
456
*/

