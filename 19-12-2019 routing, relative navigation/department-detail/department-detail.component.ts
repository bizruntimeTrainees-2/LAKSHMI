import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router, ParamMap} from '@angular/router';
@Component({
  selector: 'app-department-detail',
  template: `
    <h4>
     you selected department with id = {{departmentId}}
     </h4>

     <p>
     <button (click)="ShowOverview()">Overview</button>
     <button (click)="ShowContact()">Contact</button>
     </p>
     <router-outlet></router-outlet>
     <button (click)="goPrevious()">Previous</button>  |
     <button (click)="goNext()">Next</button>

     <div>
     <button (click)="goToDepartments()">Back</button>
     </div>
  `,
  styles: []
})
export class DepartmentDetailComponent implements OnInit {
public departmentId;
  constructor(private route:ActivatedRoute, private router: Router) { }

  ngOnInit() {
    //let id = parseInt(this.route.snapshot.paramMap.get('id'));
    //this.departmentId = id;

    this.route.paramMap.subscribe((params : ParamMap) => {
      let id = parseInt(params.get('id'));
      this.departmentId = id;
    } );
  }

  goPrevious()
  {
      let previousId = this.departmentId - 1;
      this.router.navigate(['/departments',previousId]);
  }
  goNext()
  {
      let nextId = this.departmentId + 1;
      this.router.navigate(['/departments',nextId]);
  }
  goToDepartments()
  {
      let selectedId = this.departmentId ? this.departmentId : null;
     // this.router.navigate(['/departments',{id: selectedId}]);
      this.router.navigate(['../',{id: selectedId}], {relativeTo: this.route});
      //the above ../ means go back one segment in the url(department-list)
  }

  ShowOverview()
  {
      this.router.navigate(['overview'],{relativeTo: this.route});
  }
  ShowContact()
  {
      this.router.navigate(['contact'],{relativeTo: this.route});
  }

}
