import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Stock } from 'src/app/models/stock';
import { StockService } from 'src/app/services/stock.service';

@Component({
  selector: 'app-stock',
  templateUrl: './stock.component.html',
  styleUrls: ['./stock.component.css']
})
export class StockComponent implements OnInit {

  dtOptions: any = {};

  stock : Stock[]

  constructor(public service:StockService, private toastr:ToastrService) {
    
    this.loadStock()
   }

  ngOnInit(): void {
    this.ExtendDataTable()
  }


  
  loadStock()
  {
    this.service.getStock().subscribe(
      res=>{
        this.stock = res as Stock[]
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
