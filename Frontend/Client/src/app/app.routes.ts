import { RouterModule, Routes } from '@angular/router';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { NgModule } from '@angular/core';
import { HomeComponent } from './pages/home/home.component';
import { CaixaComponent } from './pages/caixa/caixa.component';

export const routes: Routes = [
  { path:"cardapio", component:CardapioComponent },
  { path:"", component:HomeComponent },
  { path:"caixa", component:CaixaComponent },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }