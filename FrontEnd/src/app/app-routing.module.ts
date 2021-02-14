import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const homeModule = () => import('./views').then(x => x.HomeModule)

const routes: Routes = [
  { path: '', loadChildren: homeModule }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
