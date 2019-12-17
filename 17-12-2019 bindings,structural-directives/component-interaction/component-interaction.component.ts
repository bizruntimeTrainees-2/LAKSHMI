import { Component, OnInit ,Input, EventEmitter, Output} from '@angular/core';

@Component({
  selector: 'app-component-interaction',
  template : `
  <h2>{{"Hello  " + parentData}}</h2>

  <button (click)= "fireEvent()">Send Event</button>
  `,
  styleUrls: []
})
export class ComponentInteractionComponent implements OnInit {
  @Input() public parentData;
/*
the above input() for child component */
@Output() public childEvent = new EventEmitter();
/* so to be able to send childEvent to the parent, we use output decorator */
  constructor() { }

  ngOnInit() {
  }
  fireEvent()
  {
    this.childEvent.emit('Hey Lakshmi Royal');
  }

}
