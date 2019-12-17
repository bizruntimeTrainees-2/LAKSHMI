import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-struct-directives',
  /*
  template:`
  <h2 *ngIf = "false">
  My Responsibility
  </h2>

  <h2 *ngIf = "displayName">
  It will display only , if the displayName is true
  </h2>
  `,
  */
 /*
 template : `
 <h2 *ngIf="displayName;else elseBlock">
 LAKSHMI ROYAL
 </h2>
 <ng-template #elseBlock>
 <h2>
 Name is hidden
 </h2>
 </ng-template>
 `,
 */
template : `
<div [ngSwitch]="color">
<div *ngSwitchCase="'pink'">you picked pink color</div>
<div *ngSwitchCase="'blue'">you picked blue color</div>
<div *ngSwitchCase="'green'">you picked green color</div>
</div>


<div *ngFor = "let color of colors">
<h2> {{color}}</h2>
</div>

<div *ngFor="let color of colors; index as i">
<h2>{{i}} {{color}} </h2>
</div>

<div *ngFor="let color of colors; odd as o">
<h2>{{o}} {{color}}</h2>`,
  styles: []
})
export class StructDirectivesComponent implements OnInit {

  //displayName = true;
  displayName = false;
  public color = "pink";
  public colors = ["red","blue","green","yellow"];
  constructor() { }

  ngOnInit() {
  }

}/*
if ngIf = true, the html tag value i.e. My Responsibility is displayed in the browser.

if ngIf = false, then html tag i.e My Responsibility not displayed in the browser

same displayName also like that 

*/


