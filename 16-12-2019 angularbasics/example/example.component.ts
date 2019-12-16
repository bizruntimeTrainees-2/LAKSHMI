import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-example',
  template: `
  <h2>
    Welcome {{name}}
    </h2>
    <h2> {{2+2}}</h2>
    <h2> {{"Welcome  " + name}} </h2>
    <h2>{{name.length}}</h2>
    <h2>{{name.toLowerCase()}}</h2>
    <h2>{{greetUser()}}</h2>
    <h2>{{siteUrl}}</h2>`,
  styleUrls: ['./example.component.sass']
})
export class ExampleComponent implements OnInit {
  public name = "LAKSHMI";
  public siteUrl = window.location.href;
  constructor() { }

  ngOnInit() {
  }
    greetUser()
    {
      return "Hello  " + this.name;
    }

}
