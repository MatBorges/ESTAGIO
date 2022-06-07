import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './areas/cadastro/cadastro.component';
import { UsuarioComponent } from './areas/usuario/usuario.component';


const routes: Routes = [
  {path:'usuario', component: UsuarioComponent},
  {path:'cadastro', component: CadastroComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
