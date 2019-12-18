import {Injectable} from '@angular/core';

@Injectable()
export class EmployeeServiceComponent{
  constructor()
  {

  }
  getEmployees()
  {
    return [
      {"id" : 1, "name":"Anand","age":30},
      {"id" : 2, "name":"pallavi","age":15},
      {"id" : 3, "name":"suguna","age":27},
      {"id" : 4, "name":"vihari","age":19}
    ];
  }
}

