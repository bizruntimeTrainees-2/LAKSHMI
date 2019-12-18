import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { IEmployee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmpServiceService {
private _url:string = "/assets/data/employees.json";
  constructor(private http: HttpClient) { }
  getEmployees():Observable<IEmployee[]>
  {
    /*
    return [
      {"id" : 1, "name":"Anand","age":30},
      {"id" : 2, "name":"pallavi","age":15},
      {"id" : 3, "name":"suguna","age":27},
      {"id" : 4, "name":"vihari","age":19}
    ];
    */
   return this.http.get<IEmployee[]>(this._url);
  }
}
