import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  dtOptions: any = {};

  employees : Employee[]

  constructor(public service:EmployeeService, private toastr:ToastrService) {
    this.loadAllEmployees()
   }

  ngOnInit(): void {
    this.ExtendDataTable()
  }

  

  loadAllEmployees()
  {
    this.service.getEmployees().subscribe(
      res=>{
        // console.log(res as Employee[])
        this.employees = res as Employee[]
        // this.ExtendDataTable()
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  

  ExtendDataTable()
  {
    this.dtOptions = {
      dom: 'Blfrtip',
      buttons: [
        'copy',
        'print',
        'csv',
        'excel',
        'pdf'
      ]
    };
  }

}
