import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes',
  template: `
  <h2>{{name}}</h2>
  <h2>{{name | lowercase}}</h2>
  <h2>{{name | uppercase}}</h2>
  <h2>{{message | titlecase}}</h2>
  <h2>{{name |slice:3:7}}</h2>
  <h2>{{person | json}}</h2>

  <h2>{{3.45 | number:'1.2-3'}}</h2>

  <h2>{{0.35 | percent}}</h2>
  <h2>{{0.25 | currency}}</h2>
  <h2>{{0.25 | currency : 'GBP'}}</h2>
 <h2>{{date}}</h2>
 <h2>{{date | date:'short'}}</h2>
 <h2>{{date | date:'shortDate'}}</h2>
 <h2>{{date | date:'shortTime'}}</h2>


  `,
  styles: []
})
export class PipesComponent implements OnInit {
public name = "Angular learning";
public message = "welcome to my family";
public person= {
  "firstName": "lakshmi",
  "lastName" : "Avula"

}
public date = new Date();
  constructor() { }

  ngOnInit() {
  }

}
