import { of } from 'rxjs';
import { first } from 'rxjs/operators';

first()(of(5, 9, 13)).subscribe((v) => console.log(`value: ${v}`));
/*it will return the first value */

/*
value: 5
*/