import { Component, OnInit } from '@angular/core';
import {Router,ActivatedRoute,ParamMap} from '@angular/router';

@Component({
  selector: 'app-department-list',
  template: `
    <h1>
     Department List 
    </h1>
    <ul class = "items">
    <li (click)="onSelect(department)" [class.selected]="isSelected(department)" *ngFor="let department of departments">
    <span class="badge">{{department.id}}</span>{{department.name}}
    </li>
    </ul>
  `,
  styles: []
})
export class DepartmentListComponent implements OnInit {
  [x: string]: any;
public selectedId;
  departments = [
    {"id":1 ,"name":"Angular"},
    {"id":2 ,"name":"Node"},
    {"id":3 ,"name":"MongoDB"},
    {"id":4 ,"name":"Ruby"},
    {"id":5 ,"name":"BootStrap"}
  ]
  constructor(private router:Router,private route:ActivatedRoute) { }

  ngOnInit() {
    
    this.route.paramMap.subscribe((params : ParamMap) => {
      let id = parseInt(params.get('id'));
      this.selectedId= id;
    } );
  }

  onSelect(department)
  {
    //this.router.navigate(['/departments',department.id]);
    this.router.navigate([department.id],{relativeTo: this.route});
    //the above line means i dont care what the url rightnow , but the current route append the department id
  }

  isSelected(department)
  {
    return department.id === this.selectedId;
  }

}
