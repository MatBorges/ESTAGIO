import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ApiService } from 'src/services/api.service';

@Component({
  selector: 'app-servicos',
  templateUrl: './servicos.component.html',
  styleUrls: ['./servicos.component.css']
})

export class ServicosComponent implements OnInit
{
  public servicos: any[] = [];
  public form!: FormGroup;

  get f():any { return this.form.controls; }

  constructor(private api: ApiService, private fb: FormBuilder) { }

  ngOnInit() { this.iniciarPagina(); this.validaForm() }

  public iniciarPagina()
  {
    this.api.get('servicos').subscribe(
      (dados: any) => {
      this.servicos = dados;
      console.table(this.servicos);
      },
      (erro:any) => {
      alert(erro.error);
      }
    )
  }

  public validaForm()
  {
    this.form = this.fb.group({
      id: 0,
      descricao: ['', Validators.required],
      preco: ['', [Validators.required, Validators.pattern('[0-9]+(.([0-9])+)*')]],
    });
  }

  incluir()
  {
    console.log(this.form.value)
    this.api.post('servicos/inserir', this.form.value).subscribe(
    (dados: any) => {
      if(dados !== null || dados !== undefined)
      {
        alert(`Dados do serviço ${dados.descricao} salvos com sucesso`);
        this.iniciarPagina();
      }
    },
    (erro:any) => {
      alert(erro.error);
    }
    );
  }
}
