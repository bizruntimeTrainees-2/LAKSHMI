import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-example1',
  template: `<h2>
  Welcome {{name}}
  </h2>
  <input [id]="myId" type="text" value="Sita">
  <input disabled id="{{myId}}" type="text" value="Sita">
  <input [disabled]="isDisabled" id="{{myId}}" type="text" value="Sita">

  `,
  styles: []
})
export class Example1Component implements OnInit {
  public name = "code Evolution";
  public myId = "testId";
  public isDisabled = false;
  constructor() { }

  ngOnInit() {
  }

}
