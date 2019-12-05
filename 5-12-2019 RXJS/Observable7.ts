
import {Observable} from 'rxjs';
const observable = new Observable(subscribe => {
  // Keep track of the interval resource
  const value = setInterval(() => {
    subscribe.next('hi');
  }, 1000);

  // Provide a way of canceling and disposing the interval resource
  return function unsubscribe() {
    clearInterval(value);
  };
});
console.log(observable);