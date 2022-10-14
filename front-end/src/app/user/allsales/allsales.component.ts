import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Allsales } from 'src/app/models/allsales';
import { Saleitems } from 'src/app/models/saleitems';
import { SalesService } from 'src/app/services/sales.service';

@Component({
  selector: 'app-allsales',
  templateUrl: './allsales.component.html',
  styleUrls: ['./allsales.component.css']
})
export class AllsalesComponent implements OnInit {

  dtOptions: any = {};

  sales : Allsales[]


  constructor(public service:SalesService, private toastr:ToastrService) { 
    this.loadAllSales()
  }

  ngOnInit(): void {
  }

  
  loadAllSales()
  {
    this.service.getSales().subscribe(
      res=>{
        this.sales = res as Allsales[]
        // this.ExtendDataTable()
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

}
