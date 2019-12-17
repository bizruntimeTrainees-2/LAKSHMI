import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-two-way-binding',
  template : `
  <input [(ngModel)] = "name" type ="text">
  {{name}}
  `,
  styles: []
})
export class TwoWayBindingComponent implements OnInit {
public name = "";
  constructor() { }

  ngOnInit() {
  }

}
/*
in this program , output is
whatever you will type in textbox , that will be displayed outside of the text box also
*/
