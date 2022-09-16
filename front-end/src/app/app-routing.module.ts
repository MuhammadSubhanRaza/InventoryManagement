import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Product } from './models/product';
import { AddProductComponent } from './user/add-product/add-product.component';
import { CategoryComponent } from './user/category/category.component';
import { ProductComponent } from './user/product/product.component';

const routes: Routes = [
  {
    component:CategoryComponent,
    path:'category'
  } ,
  {
    component:ProductComponent,
    path:'products'
  } ,
  {
    component:AddProductComponent,
    path:'add-product'
  } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
