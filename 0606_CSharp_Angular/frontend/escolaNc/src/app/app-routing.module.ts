import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsuarioComponent } from './areas/usuario/usuario.component';
import { CadastroComponent } from './areas/cadastro/cadastro.component';
import { ServicosComponent } from './areas/servicos/servicos.component';
import { ContratacaoComponent } from './areas/contratacao/contratacao.component';

const routes: Routes = [
  {path: 'cadastro', component: CadastroComponent},
  {path: 'usuarios', component: UsuarioComponent},
  {path: 'servicos', component: ServicosComponent},
  {path: 'contratacao', component: ContratacaoComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
