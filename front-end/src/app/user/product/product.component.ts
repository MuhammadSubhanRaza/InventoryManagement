import { AfterViewInit, Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit,AfterViewInit {

  dtOptions: any = {};

  products : Product[]

  constructor(public service:ProductService, private toastr:ToastrService) {
    
    this.loadAllProducts()
   }

   
  ngAfterViewInit(): void {
  }

  ngOnInit(): void {
    // this.loadAllProducts()
    this.ExtendDataTable()
  }



  loadAllProducts()
  {
    this.service.getProducts().subscribe(
      res=>{
        this.products = res as Product[]
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
