import { Component, OnInit } from '@angular/core';

@Component({
  /*
  selector: 'app-style-binding',
  template: `
  <h2>
  Welcome</h2>
 
  <h2 [style.color]="'pink'">Style Binding</h2>
  <h2 [style.color]="hasError ? 'black' : 'orange'"> MY LEARNING </h2>
  <h2 [style.color]="highLightColor">ANGULAR8</h2>
  <h2 [ngStyle]="titleStyles"> I am learning angular </h2> 
  `,
  
  styleUrls: ['./style-binding.component.sass']
})
*/


/*
selector: 'app-event-binding',
template:`
<h2>
Welcome {{name}}
</h2>
<button (click)="onClick($event)">CALL</button>

<button (click)="greeting='welcome family'">CALL</button>
{{greeting}}

`,
styles : []
})
*/
/*here above $event gives all information about the DOM
on second button i gave greeting like template , it directly display in the browser  */

selector: 'app-style-binding',
template:`
<h2>
Welcome {{name}}
</h2>
<input #myInput type = "text">
<button (click)="logMessage(myInput.value)">Log</button>
`,
styles:[]
})
export class StyleBindingComponent implements OnInit {
public name = "LAKSHMI ROYAL";
public hasError = true;
public highLightColor = "red";
public titleStyles = {
  color : "pink",
  fontStyle : "italic"
}
public greeting = "";

  constructor() { }

  ngOnInit() {
  }
  onClick(event)
  {
    console.log(event);
    this.greeting = 'My sweet family';
    /*this.greeting value is displayed not in the console, directly it displayed in the browser, because of interpolation */
  }
  logMessage(value)
  {
    console.log(value);
  }

}

/*
ngg style is used here for multiple style purpose 
*/

