import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Aluno } from '../models/Aluno';


@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public modalRef?: BsModalRef;
  public alunoForm: FormGroup;
  public titulo = 'Alunos';
  public alunoSelecionado!: Aluno;
  public textSimple: string;

  public alunos = [
  {id: 1, nome: 'Raquel Silva', cpf:'875.363.800-03', email:'raquelsilva276@gmail.com', telefone:'55119548345', sexo:'feminino', nascimento:'08/09/2004',},
  {id: 2, nome: 'Laura Sousa', cpf:'875.363.800-03', email:'laurinhasous@gmail.com', telefone:'5511899874', sexo:'feminino', nascimento:'12/10/2003',},
  {id: 3, nome: 'Rebeka Vitória', cpf:'566.978.230-54', email:'rbkvitoria245@gmail.com', telefone:'5511986549', sexo:'feminino', nascimento:'21/05/2005',},
  {id: 4, nome: 'Pedro Henrique', cpf:'718.723.720-07', email:'phenriq24@gmail.com', telefone:'5511976548', sexo:'masculino', nascimento:'30/04/2003',},
  {id: 5, nome: 'Otávio Porto', cpf:'141.133.870-79', email:'Otvport985@gmail.com', telefone:'551154325', sexo:'masculino', nascimento:'16/01/2004',},
  {id: 6, nome: 'Luisa Junior', cpf:'161.781.950-60', email:'Juluisa57@gmail.com', telefone:'556614124', sexo:'feminino', nascimento:'05/02/2002',},
  {id: 7, nome: 'Vitor Nobrega', cpf:'778.402.420-73', email:'VitinhoNobrega924@gmail.com', telefone:'556543245', sexo:'masculino', nascimento:'29/07/2004',},
  ];

  /* Modal */

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, 
              private modalService: BsModalService) { 
    this.criarForm();
}

  ngOnInit(): void {
  }

  criarForm() {
    this.alunoForm = this.fb.group({
      nome: ['', Validators.required],
      cpf: ['', Validators.required],
      email: ['', Validators.required],
      telefone: ['', Validators.required],
      sexo: ['', Validators.required],
      nascimento: ['', Validators.required],
    });
  }


alunoSubmit() {
  console.log(this.alunoForm.value);
}


/* Função aluno selecionado*/
  
  alunoSelect(aluno: Aluno) {
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }

/* Função ao voltar deselecionar aluno*/

  voltar() {
    this.alunoSelecionado = null;
  }

}
