import { from, of } from 'rxjs';
import { delay } from 'rxjs/internal/operators';
import { concatMap } from 'rxjs/internal/operators';
const myArray = [1,2,3,4];

from(myArray).pipe(
        concatMap( item => of(item).pipe ( delay( 1000 ) ))
    ).subscribe ( timedItem => {
        console.log(timedItem)
    });

    /*
    The Delay operator modifies its source Observable by pausing for a particular increment of time (that you specify) before emitting each of the source Observable's items. 
    */

 /*
1
2
3
4
*/