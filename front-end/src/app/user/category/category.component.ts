import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/services/category.service';
import { ToastrService } from 'ngx-toastr'

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  categories : Category[]

  constructor(public service:CategoryService, private toastr:ToastrService) { }

  ngOnInit(): void {
    this.loadCategories()
  }

  onSubmit(form:NgForm)
  {
    this.service.postCategory().subscribe(
      res => {
        this.toastr.success("Catgegory added successfully! ")
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
    this.service.formData = new Category();
  }

}
