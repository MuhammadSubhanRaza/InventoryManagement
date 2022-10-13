import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Category } from 'src/app/models/category';
import { Product } from 'src/app/models/product';
import { CategoryService } from 'src/app/services/category.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  categories : Category[]

  constructor(public service:ProductService, private toastr:ToastrService) { }

  ngOnInit(): void {
    this.loadCategories()
  }


  onSubmit(form:NgForm)
  {
    this.service.postProduct().subscribe(
      res => {
        this.toastr.success("Product added successfully! ")
        this.resetForm(form)
        this.loadCategories()
      },
      err =>{
        console.log(err)
      }
    )
  }

  loadCategories()
  {
    this.service.getCategories().subscribe(
      res=>{
        this.categories = res as Category[]
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  
  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Product();
  }

}
