import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { Saleitems } from 'src/app/models/saleitems';
import { SalesService } from 'src/app/services/sales.service';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html',
  styleUrls: ['./sales.component.css']
})
export class SalesComponent implements OnInit {

  itemsList : Saleitems[] = []

  productCode : any
  productQty : Number
  item : Saleitems

  allProducts : Product[]
  fetchedItem:any

  constructor(public service:SalesService, private toastr:ToastrService) { 

    this.loadProducts()

  }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm)
  {
    
    this.fetchedItem = this.fetchProduct(this.productCode)
    
    if(this.fetchedItem==null)
    {
      this.toastr.error("Product not found with this Barcode")
    }
    else{
      this.toastr.success("Product added in queue")
      this.item = new Saleitems();
      this.item.product = this.fetchedItem.name
      this.item.quantity = this.productQty
      this.item.productId = this.fetchedItem.id
      this.item.price = this.fetchedItem.price
      this.itemsList.push(this.item)
      this.resetForm()
    }
    
  }

  confirmBill()
  {
    this.service.postSales(this.itemsList).subscribe(
      res=>{
        this.itemsList = []
      },
      err=>{
        this.toastr.error("Some error occurred while processing")
      }
    )
  }



  fetchProduct(code:string)
  {
    for(let item of this.allProducts)
    {
      if (item.barcode==code)
      {
        return item
      }
    }
    return null
  }


  loadProducts()
  {
    this.service.getProducts().subscribe(
      res=>{
        this.allProducts = res as Product[]
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

    
  resetForm()
  {
    this.productCode = null
    this.productQty = 0
    this.item = new Saleitems();
  }


}
