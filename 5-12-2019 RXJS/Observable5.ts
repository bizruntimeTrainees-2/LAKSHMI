import {Observable} from 'rxjs';

const observable = new Observable(subscribe =>
{
  console.log('Hello');
subscribe.next(1);
subscribe.next(2);
subscribe.next(3);
subscribe.next(4);
subscribe.next(5);
subscribe.complete(); //nothing will be executed after complete method calling
subscribe.next(6);
});
console.log('before');
observable.subscribe(x => {
  console.log(x);
});
console.log('after');


/*
before
Hello
1
2
3
4
5
after
*/