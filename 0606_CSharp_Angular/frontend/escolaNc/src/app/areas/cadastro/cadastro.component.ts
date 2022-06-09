import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ApiService } from 'src/services/api.service';


@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {

  public form!: FormGroup;

  get f():any
  {
    return this.form.controls;
  }

  constructor(private api: ApiService, private fb: FormBuilder)
  {

  }

  ngOnInit() {
    this.validaForm();
  }

  public validaForm(){
    this.form = this.fb.group({
      nome: ['', Validators.required],
      idade: ['', [Validators.required, Validators.min(0)]],
      cpf: ['', [Validators.required, Validators.min(0), Validators.minLength(11), Validators.maxLength(11)]],
      rg: ['', Validators.required],
      data_nasc: ['', Validators.required],
      endereco: ['', Validators.required],
      cidade: ['', Validators.required]
    });
  }

  incluir()
  {
      console.log(this.form.value)
      this.api.post('usuarios/inserir', this.form.value).subscribe(
      (dados: any) => {
        if(dados !== null || dados !== undefined)
        {
          alert(`Dados do usuário ${dados.nome} salvos com sucesso`);
        }
      },
      (erro:any) => {
        alert(erro.error);
      }
    );
  }

}
