import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class-binding',
  template: `
  <h2>
  Welcome {{name}}
  </h2>
  <h2 class = "text-success" >CodeEvolution</h2>
  <h2 [class]= "successClass">CodeEvolution</h2>
  <h2 [class.text-danger]="hasError">CodeEvolution</h2>
  <h2 [ngClass] = "messageClasses">CodeEvolution</h2>`,
  styles: [`
  .text-success {
    color: green;
  }
  .text-danger {
    color: red;
  }
  .text-special {
    font-style : italic;
  }
  `]
})
export class ClassBindingComponent implements OnInit {
public name = "CodeEvolution";
public successClass = "text-success";
public hasError = true;
public isSpecial = true;
public messageClasses = {
  "text-success" : !this.hasError, 
  "text-danger" : this.hasError,
  "text-special" : !this.isSpecial
}
  constructor() { }

  ngOnInit() {
  }

}
