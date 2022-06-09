import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ApiService } from 'src/services/api.service';

@Component({
  selector: 'app-contratacao',
  templateUrl: './contratacao.component.html',
  styleUrls: ['./contratacao.component.css']
})
export class ContratacaoComponent implements OnInit {

  public cpf = '';
  public verifica: boolean = false;

  public retorno: any = [];
  public servicos: any = [];
  public envio: any = [];

  constructor(private api: ApiService) { }

  ngOnInit() {
    this.carregaServicos();
  }

  public carregaServicos()
  {
    this.api.get('contratacao/servicos').subscribe({
      next: dados => {
        this.servicos = dados;
        console.log(this.servicos);
      },
      error: erro => alert(erro.error)
    })
  }

  public buscaCpf()
  {
    this.api.get(`contratacao/${this.cpf}`).subscribe({
      next: dados => {
        this.retorno = dados;
        dados.forEach((dado: any) => {
          if(dado["descricao"] == null)
            this.verifica = true;

        });
        console.table(this.retorno);
        console.log(this.verifica);
      },
      error: erro => alert(erro.error)
    })
  }

  public insereServico(id: number)
  {
    this.envio.push({
      id_servico: id,
      cpf_usuario: this.cpf
    });
  }

  public contrataServico() {
    if(this.envio.length == 0){
      alert(`Selecione ao menos um serviço`)
      return
    }
    this.api.post('contratação', this.envio).subscribe({

    }),
    (erro: any) => {
      alert(erro.error)
    },
    () => {this.buscaCpf()};
    () => {this.envio()};
  }
}
