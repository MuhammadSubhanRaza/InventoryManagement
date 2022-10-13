import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Salesratios } from 'src/app/models/salesratios';
import { SalesreturnService } from 'src/app/services/salesreturn.service';

@Component({
  selector: 'app-set-sales-return',
  templateUrl: './set-sales-return.component.html',
  styleUrls: ['./set-sales-return.component.css']
})
export class SetSalesReturnComponent implements OnInit {

  constructor(public service:SalesreturnService, private toastr:ToastrService) { 
    
  }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm)
  {
    this.service.putSalesratio().subscribe(
      res => {
        this.toastr.success("Updated successfully! ")
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
    this.service.formData = new Salesratios();
  }
}
