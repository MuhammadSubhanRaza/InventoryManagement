import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  constructor(public service:EmployeeService, private toastr:ToastrService) { 
    
  }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm)
  {
    this.service.postEmployee().subscribe(
      res => {
        this.toastr.success("Product added successfully! ")
        this.resetForm(form)
      },
      err =>{
        console.log(err)
      }
    )
  }

  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Employee();
  }

}
