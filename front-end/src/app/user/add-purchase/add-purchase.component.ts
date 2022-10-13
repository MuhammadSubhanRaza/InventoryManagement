import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { Purchase } from 'src/app/models/purchase';
import { Supplier } from 'src/app/models/supplier';
import { PurchaseService } from 'src/app/services/purchase.service';

@Component({
  selector: 'app-add-purchase',
  templateUrl: './add-purchase.component.html',
  styleUrls: ['./add-purchase.component.css']
})
export class AddPurchaseComponent implements OnInit {

  products : Product[]
  suppliers : Supplier[]
  totalAmount : 34

  constructor(public service:PurchaseService, private toastr:ToastrService) { 

    this.loadProducts()
    this.loadSuppliers()
  }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm)
  {
    this.service.postPurchase().subscribe(
      res => {
        this.toastr.success("Product added successfully! ")
        this.resetForm(form)
        this.loadProducts()
        this.loadSuppliers()
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

  loadSuppliers()
  {
    this.service.getSuppliers().subscribe(
      res=>{
        this.suppliers = res as Supplier[]
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  
  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Purchase();
  }



  


}
