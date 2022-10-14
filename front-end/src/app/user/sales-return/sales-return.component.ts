import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { Salesreturn } from 'src/app/models/salesreturn';
import { SalesreturnService } from 'src/app/services/salesreturn.service';
import { TotalsalereturnService } from 'src/app/services/totalsalereturn.service';

@Component({
  selector: 'app-sales-return',
  templateUrl: './sales-return.component.html',
  styleUrls: ['./sales-return.component.css']
})
export class SalesReturnComponent implements OnInit {

  products : Product[]

  constructor(public service:TotalsalereturnService, private toastr:ToastrService) {

    this.loadProducts()
    
   }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm)
  {
    this.service.postSalesReturn().subscribe(
      res => {
        this.toastr.success("Product added successfully! ")
        this.resetForm(form)
        this.loadProducts()
      },
      err =>{
        console.log(err)
      }
    )
  }

  loadProducts()
  {
    this.service.getProducts().subscribe(
      res=>{
        this.products = res as Product[]
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )

  }

  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Salesreturn();
  }



}
