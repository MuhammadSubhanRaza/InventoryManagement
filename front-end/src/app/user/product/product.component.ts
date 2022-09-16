import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  dtOptions: any = {};

  products : Product[]

  constructor(public service:ProductService, private toastr:ToastrService) {
    
    this.loadAllProducts()
   }

  ngOnInit(): void {
    this.ExtendDataTable()
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


  loadAllProducts()
  {
    this.service.getProducts().subscribe(
      res=>{
        this.products = res as Product[]
        console.log(res)
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  
}
