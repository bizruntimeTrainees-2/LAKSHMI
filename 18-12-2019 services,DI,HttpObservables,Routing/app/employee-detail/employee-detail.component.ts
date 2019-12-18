import { Component, OnInit } from '@angular/core';

import { EmpServiceService } from '../emp-service.service';

@Component({
  selector: 'app-employee-detail',
  template:`
  <h2>Employee-detail</h2>
  
  <ul *ngFor="let employee of employees">
  <li>{{employee.id}}.  {{employee.name}}.  {{employee.age}}</li>
  </ul>
  `,
  styleUrls: []
})
export class EmployeeDetailComponent implements OnInit {
  /*
  public employees = [
    {"id" : 1, "name":"Anand","age":30},
    {"id" : 2, "name":"pallavi","age":15},
    {"id" : 3, "name":"suguna","age":27},
    {"id" : 4, "name":"vihari","age":19}
  ];
  */
 public employees = [];

  constructor(private _employeeService:EmpServiceService) { }

  ngOnInit()
  {
  /*
  {
    this.employees = this._employeeService.getEmployees();
  }
  */
 this._employeeService.getEmployees().subscribe(data => this.employees = data);

}
}       
